using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }
        [ValidationAspect(typeof(CompanyValidator))]
        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult(Messages.AddedCompany);        
        }
        [ValidationAspect(typeof(CompanyValidator))]
        [TransactionScopeAspect]
        public IResult AddCompanyAndUserCompany(CompanyDto companyDto)
        {
            _companyDal.Add(companyDto.Company);
            _companyDal.UserCompanyAdd(companyDto.UserId, companyDto.Company.Id);
            return new SuccessResult(Messages.AddedCompany);
        }

        public IResult CompanyExists(Company company)
        {
            var result = _companyDal.Get(c => c.Name == company.Name && c.TaxDepartment == company.TaxDepartment && c.TaxIdNumber == company.TaxIdNumber && c.IdentityNumber == company.IdentityNumber);
            if (result != null)
            {
                return new ErrorResult(Messages.CompanyAlreadyExsits);
            }
            return new SuccessResult();
        }

        public IDataResult<Company> GetById(int id)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(p => p.Id == id));
        }

        public IDataResult<UserCompany> GetCompany(int userId)
        {
            return new SuccessDataResult<UserCompany>(_companyDal.GetCompany(userId));
        }

        public IDataResult<List<Company>> GetList()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetList());
        }

        public IResult Update(Company company)
        {
            _companyDal.Update(company);
            return new SuccessResult(Messages.UpdatedCompany);
        }

        public IResult UserCompanyAdd(int userId, int compantId)
        {
            _companyDal.UserCompanyAdd(userId, compantId);
            return new SuccessResult();
        }
    }
}
