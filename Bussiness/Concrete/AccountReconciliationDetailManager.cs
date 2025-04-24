﻿using Business.Abstract;
using Business.Constans;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Caching;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entites.Concrete;
using Entities.Concrete;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountReconciliationDetailManager : IAccountReconciliationDetailService
    {
        private readonly IAccountReconciliationDetailDal _accountReconciliationDetailDal;

        public AccountReconciliationDetailManager(IAccountReconciliationDetailDal accountReconciliationDetailDal)
        {
            _accountReconciliationDetailDal = accountReconciliationDetailDal;
        }

        [CacheRemoveAspect("IAccountReconciliationDetailService.Get")]
        public IResult Add(AccountReconciliationDetail accountReconciliationDetail)
        {
            _accountReconciliationDetailDal.Add(accountReconciliationDetail);
            return new SuccessResult(Messages.AddedAccountReconciliationDetail);
        }

        [CacheRemoveAspect("IAccountReconciliationDetailService.Get")]
        [TransactionScopeAspect]
        public IResult AddToExcel(string filePath, int accountReconciliationId)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        string description = reader.GetString(1);

                        if (description != "Açıklama" && description != null)
                        {
                            DateTime date = reader.GetDateTime(0);
                            double currencyId = reader.GetDouble(2);
                            double debit = reader.GetDouble(3);
                            double credit = reader.GetDouble(4);

                            AccountReconciliationDetail accountReconciliationDetail = new AccountReconciliationDetail()
                            {
                                AccountReconciliationId = accountReconciliationId,
                                Description = description,
                                Date = date,
                                CurrencyId = Convert.ToInt16(currencyId),
                                CurrencyDebit = Convert.ToDecimal(debit),
                                CurrencyCredit = Convert.ToDecimal(credit)
                            };
                            _accountReconciliationDetailDal.Add(accountReconciliationDetail);
                        }
                    }
                }
            }
            File.Delete(filePath);

            return new SuccessResult(Messages.AddedAccountReconciliationDetail);
        }

        [CacheRemoveAspect("IAccountReconciliationDetailService.Get")]
        public IResult Delete(AccountReconciliationDetail accountReconciliationDetail)
        {
            _accountReconciliationDetailDal.Delete(accountReconciliationDetail);
            return new SuccessResult(Messages.DeletedAccountReconciliationDetail);
        }

        [CacheAspect(60)]
        public IDataResult<AccountReconciliationDetail> GetById(int id)
        {
            return new SuccessDataResult<AccountReconciliationDetail>(_accountReconciliationDetailDal.Get(p => p.Id == id));
        }

        [CacheAspect(60)]
        public IDataResult<List<AccountReconciliationDetail>> GetList(int accountReconciliationId)
        {
            return new SuccessDataResult<List<AccountReconciliationDetail>>(_accountReconciliationDetailDal.GetList(p => p.AccountReconciliationId == accountReconciliationId ));
        }

        [CacheRemoveAspect("IAccountReconciliationDetailService.Get")]
        public IResult Update(AccountReconciliationDetail accountReconciliationDetail)
        {
            _accountReconciliationDetailDal.Update(accountReconciliationDetail);
            return new SuccessResult(Messages.UpdatedAccountReconciliationDetail);
        }
    }
}
