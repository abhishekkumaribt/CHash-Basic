using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class Insurance
    {
        private int age;
        public string consumerName;
        private static int counter;
        private int creditHistory;
        private string[] documents;
        public string insuranceId;
        static Insurance()
        {
            counter = 1000;
        }
        public Insurance()
        {
            age = 18;
            creditHistory = 45000;
        }
        public Insurance(string consumerName):this()
        {
            this.consumerName = consumerName;
        }
        public Insurance(string consumerName,string[] documents) : this(consumerName)
        {
            this.documents = documents;
        }
        public Insurance(string consumerName, int creditHistory, int age, string[] documents):this(consumerName,documents)
        {
            this.creditHistory = creditHistory;
            this.age = age;
        }
        public bool CheckEligibility()
        {
            if (age > 18 && age <= 30 && creditHistory <= 60000)
                return true;
            if (age > 30 && creditHistory <= 45000)
                return true;
            return false;
        }
        public bool CheckDocuments(string[] acceptabledocuments)
        {
            bool match = false;
            if (CheckEligibility())
            {
                foreach(string doc in documents)
                {
                    foreach(string actdoc in acceptabledocuments)
                    {
                        if (doc == actdoc)
                        {
                            match = true;
                            break;
                        }
                    }
                    if (match == true)
                        break;
                }
            }
            if(match==true)
            {
                insuranceId = "I" + counter.ToString();
                counter += 1;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
