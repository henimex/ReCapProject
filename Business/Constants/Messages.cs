﻿using System;
using System.Collections.Generic;
using System.Text;
using Entites.Concrete;
using Entites.DTOs;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Added Successfully.";
        public static string BrandNameInvalid = "Brand Name Invalid.";
        public static string CarsListed = "Available Cars Listed.";
        public static string MaintenanceTime = "Server Is Busy Right Now.";
        public static string DailyPrice = "Daily Price Must Be Greater Than Zero(0).";
        public static string Updated = "Updated Successfully.";
        public static string Deleted = "Deleted Successfully.";
        public static string ColorsListed = "All Available Colors Are Listed.";
        public static string NameInvalid = "Name Is Invalid or too Short.";
        public static string ItemsListed = "Items Listed.";
        public static string RequiredParamIsNull = "Given Parameter Type is Wrong Or Null.";
        public static string SingleResult = "Your Request Completed Successfully.";
        public static string RentingDate = "Rent Date Cant be Earlier Than Today and Must be Returned.";
        public static string CarAlreadyRented = "Car is Already Rented. Need to be Returned First.";
        public static string CarDelivered = "Car Delivered.";
        public static string CarReturnError = "Car Deliver Failed.";
        public static string CarInRent = "Car In Rent.";
        public static string AvailableForRent = "Car is Available For Rent.";
        public static string NotNull = "Can't be Null or Empty & At least 4 Character Required.";
        public static string ImageLimitPerCar = $"Image Limit Per Car is {OptionVariables.MaxImagePerCar}. You can't add any more pictures for this car.";
        public static string NullImagePath = "Could not get image path or image path is null";
        public static string AuthorizationDenied = "Yetkilendirme reddedildi.";
        public static string UserRegistered = "Kullanıcı Kaydedildi.";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Hatalı Şifre";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Var";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
