using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Employee
    {
        private DateTime dateOfBirth;
        private string[] dependents;
        private int employeeId;
        private string employeeName;
        private bool gender;
        private static int nextEmployeeNumber;
        private short numberOfDependents;
        static Employee()
        {
            nextEmployeeNumber = 1001;
        }
        private Employee()
        {
            employeeId = nextEmployeeNumber;
            nextEmployeeNumber += 1;
            dependents = new string[3];
        }
        public Employee(string employeeName,DateTime dateOfBirth,bool gender):this()
        {
            this.employeeName = employeeName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }
        public Employee(string employeeName, DateTime dateOfBirth, bool gender,short numberOfDependents) : this(employeeName,dateOfBirth,gender)
        {
            if (numberOfDependents < 0)
                this.numberOfDependents = 0;
            else if (numberOfDependents > 3)
                this.numberOfDependents = 3;
            else
                this.numberOfDependents = numberOfDependents;
        }
        public int AddDependent(string dependentName)
        {
            if (numberOfDependents < 3)
            {
                dependents[numberOfDependents] = dependentName;
                return numberOfDependents;
            }
            else
            {
                return 0;
            }
        }
        public bool UpdateDependents(string dependentName, int dependentId)
        {
            if(dependentId>0 && dependentId<=numberOfDependents)
            {
                dependents[dependentId - 1] = dependentName;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
