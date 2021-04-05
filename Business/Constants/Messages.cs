using Core.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string UnitPriceInvalid = "Ürünler fiyatı geçersiz";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 ürün olablir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var ";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için ürün eklenemedi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "kayıt oldu";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "parola hatası";
        public static string SuccessfulLogin = "başarılı giriş";
        public static string UserAlreadyExists = "kullanıcı mevcut";
        public static string AccessTokenCreated = "token oluşturuldu";
    }
}
