using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public class Messages
    {
        public static string AddedCompany = "Şirket kaydı başarıyla tamamlandı";
        public static string UpdatedCompany = "Şirket kaydı başarıyla güncellendi";
        public static string CompanyAlreadyExsits = "Bu şirket daha önce kayıt edilmiş";
        public static string LoginIsNotActive = "Bu kullanıcı pasif durumdadır. Lütfen yöneticinize başvurunuz..";


        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre Yanlış";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserRegistered = "Kullanıcı kaydı başarılı";
        public static string UserAlreadtExists = "Bu kullanıcı mevcut";
        public static string UserMailConfirmSuccesful = "Mailiniz başarıyla onaylandı.";
        public static string MailConfirmSendSuccessful = "Onay maili tekrar gönderildi.";
        public static string MailAlreadyConfirm = "Mailiniz zaten onaylı. Tekrar gönderim yapılamaz.";
        public static string MailConfirmTimeHasNotExpired = "Mail onayını 5 dakikada bir gönderebilirsiniz..";

        public static string MailParameterUpdated = "Mail Parametreleri başarıyla güncellendi";
        public static string MailSendSucessful = "Mail başarıyla gönderildi.";


        public static string MailTemplateAdded = "Mail şablonu başarıyla kaydedildi.";
        public static string MailTemplateDeleted = "Mail şablonu başarıyla silindi.";
        public static string MailTemplateUpdated = "Mail şablonu başarıyla güncellendi.";

        public static string AddedCurrencyAccount = "Cari kaydı başarıyla eklendi.";
        public static string UpdatedCurrencyAccount = "Cari kaydı başarıyla güncellendi.";
        public static string DeletedCurrencyAccount = "Cari kaydı başarıyla silindi.";

        public static string AddedAccountReconciliation = "Cari mutabakat kaydı başarılıyla eklendi";
        public static string DeletedAccountReconciliation = "Cari mutabakat kaydı başarılıyla silindi.";
        public static string UpdatedAccountReconciliation = "Cari mutabakat kaydı başarılıyla güncellendi.";

    }
}
