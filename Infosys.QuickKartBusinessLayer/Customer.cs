using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public enum CustomerCardType
    {
        Silver,
        Gold,
        Platinum
    }
    public class Customer
    {
        private string address;
        private int customerId;
        private string customerName;
        private string customerType;
        private DateTime dateOfBirth;
        private string emailId;
        private Gender gender;
        private string password;
        public static int currentValueForCustomerId;
        public Gender Gender {get { return gender; }set { gender = value; } }
        public string CustomerType { get { return customerType; } set { customerType = value; } }
        public int CustomerId { get { return customerId; } }
        public string CustomerName { get { return customerName; } set { Validator validate = new Validator();if (validate.IsName(value) && validate.HasLength(value, 5, 20)) customerName = value; } }
        public string EmailId { get { return emailId; } set { Validator validate = new Validator();if (validate.IsEmailId(value)) emailId =  value; } }
        public string Address { get { return address; } set { Validator validate = new Validator();if (validate.IsName(value)) address =  value; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } set { Validator validate = new Validator();if (validate.ValidateAge(value, 18)) dateOfBirth = value; } }
        public string Password { get { return password; } set { Validator validate = new Validator();if (validate.HasCapitalLetter(value) && validate.HasSpecialCharacter(value) && validate.HasSmallLetter(value) && validate.HasDigit(value)) password = value; } }
        static Customer()
        {
            currentValueForCustomerId = 1000;
        }
        public Customer()
        {
            customerId = currentValueForCustomerId;
            currentValueForCustomerId += 1;
        }
        public Customer(string customerName, string address,DateTime dateOfBirth,string emailId,Gender gender,string password):this()
        {
            CustomerName = customerName;
            Address = address;
            DateOfBirth = dateOfBirth;
            EmailId = emailId;
            Gender = gender;
            Password = password;
        }
        public double GetDiscount()
        {
            double discount = 0;
            if (customerType == "Privileged")
                discount = 2;
            else if (customerType == "Regular")
                discount = 5;
            else if (customerType == "Elite")
                discount = 7;
            return discount;
        }
        public int CalculateAge()
        {
            int age = 0;
            DateTime zero = new DateTime(1, 1, 1);
            age = (zero+(DateTime.Now - this.dateOfBirth)).Year-1;
            Console.WriteLine("Calculation completed successfully");
            return age;
        }
        public virtual double CalculateDiscount()
        {
            if (currentValueForCustomerId >= 1399)
            {
                return 4;
            }
            return 0;
        }
    }
}
