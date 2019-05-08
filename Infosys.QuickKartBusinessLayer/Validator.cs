using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Infosys.QuickKartBusinessLayer
{
    class Validator
    {
        public bool HasCapitalLetter(string value)
        {
            if (Regex.IsMatch(value,@"^.*[A-Z].*$"))
                return true;
            return false;
        }
        public bool HasDigit(string value)
        {
            if (Regex.IsMatch(value, @"^.*[\d].*$"))
                return true;
            return false;
        }
        public bool HasLength(string value,int minimumLengeth)
        {
            if (value.Length>=minimumLengeth)
                return true;
            return false;
        }
        public bool HasLength(string value, int minimumLengeth,int maximumLength)
        {
            if (value.Length >= minimumLengeth && value.Length <=maximumLength)
                return true;
            return false;
        }
        public bool HasSmallLetter(string value)
        {
            if (Regex.IsMatch(value, @"^.*[a-z].*$"))
                return true;
            return false;
        }
        public bool HasSpecialCharacter(string value)
        {
            if (Regex.IsMatch(value, @"^[a-zA-Z0-9]*$"))
                return false;
            return true;
        }
        public bool IsAlphabet(string value)
        {
            if (Regex.IsMatch(value, @"^[a-zA-Z]*$"))
                return true;
            return false;
        }
        public bool IsAlphaNumeric(string value)
        {
            if (Regex.IsMatch(value, @"^[a-zA-Z0-9]*$"))
                return true;
            return false;
        }
        public bool IsEmailId(string value)
        {
            if (Regex.IsMatch(value, "^(([^<>()\\[\\]\\\\.,;:\\s\"]+ (\\.[^<>()\\[\\]\\\\.,;:\\s@\"]+)*)|(\".+\"))@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\])|(([a-zA-Z\\-0-9]+\\.)+[a-zA-Z]{2,}))$"))
                return true;
            return false;
        }
        public bool IsInteger(string value)
        {
            int output;
            if (int.TryParse(value,out output))
                return true;
            return false;
        }
        public bool IsName(string value)
        {
            if (Regex.IsMatch(value, @"^[[a-zA-Z\s]*$"))
                return true;
            return false;
        }
        public bool IsNullOrEmpty(string value)
        {
            if (value==null || value.Length==0)
                return true;
            return false;
        }
        public bool ValidateAge(DateTime dateOfBirth,int minimumAge)
        {
            DateTime zero = new DateTime(1, 1, 1);
            int age = (zero + (DateTime.Now - dateOfBirth)).Year-1;
            if (age>=minimumAge)
                return true;
            return false;
        }
        public bool ValidateAge(DateTime dateOfBirth, int minimumAge,int maximumAge)
        {
            DateTime zero = new DateTime(1, 1, 1);
            int age = (zero + (DateTime.Now - dateOfBirth)).Year - 1;
            if (age >= minimumAge && age <= maximumAge)
                return true;
            return false;
        }
    }
}
