using System;
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
        public static string AuthorizationDenied = "Authorization Denied";
        public static string UserRegistered = "User Registered";
        public static string UserNotFound = "User Not Found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Successfully Logged In";
        public static string UserAlreadyExists = "User Already Exists";
        public static string AccessTokenCreated = "Token Created Successfully";
        public static string TransactionAborted = "Transactional Process Is Not Completed. One or more method could not completed.";
        public static string ListIsNull = "The List you are trying to get is Empty or there is no entered data in it.";
    }
}
