using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Infosys.QuickKartBusinessLayer
{
    public class Category
    {
        private int categoryId;
        private string categoryName;
        public int CategoryId { get { return categoryId; } set { categoryId = value; } }
        public string CategoryName
        {
            get
            {
                return categoryName;
            }
            set
            {
                Validator validate = new Validator();
                if (validate.IsName(value))
                    categoryName = value;
            }
        }
        public Category(int categoryId,string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }
    }
}
