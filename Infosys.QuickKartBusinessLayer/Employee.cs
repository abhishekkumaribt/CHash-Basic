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
        public DateTime DateOfBirth { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool Gender { get; set; }
        public short NumberOfDependents { get { return numberOfDependents; } set { if (value < 0) numberOfDependents = 0; else if (value > 3) numberOfDependents = 3; else numberOfDependents = value; } }
        public string this[int dependentId]
        {
            get
            {
                if (dependentId >= 1 && dependentId <= 3)
                    return dependents[dependentId];
                else
                    return null;
            }
            set
            {
                if (dependentId >= 1 && dependentId <= 3)
                {
                    if (dependents[dependentId] == null)
                        NumberOfDependents++;
                    if (value == null)
                        NumberOfDependents--;
                    dependents[dependentId] = value;
                }
            }
        }
        public string this[string dependentRelation]
        {
            get
            {
                if (dependentRelation == "Spouse")
                    return dependents[0];
                else if (dependentRelation == "Child1")
                    return dependents[1];
                else if (dependentRelation == "Child2")
                    return dependents[2];
                else
                    return null;
            }
            set
            {
                if(dependentRelation == "Spouse" || dependentRelation == "Child1" || dependentRelation == "Child2")
                {
                    if (dependentRelation == "Spouse")
                    {
                        if (dependents[0] == null)
                            NumberOfDependents++;
                    }
                    else if (dependentRelation == "Child1")
                    {
                        if (dependents[1] == null)
                            NumberOfDependents++;
                    }
                    else if (dependentRelation == "Child2")
                    {
                        if (dependents[2] == null)
                            NumberOfDependents++;
                    }
                    if (value == null)
                        NumberOfDependents--;
                    if (dependentRelation == "Spouse")
                    {
                        dependents[0] = value;
                    }
                    else if (dependentRelation == "Child1")
                    {
                        dependents[1] = value;
                    }
                    else if (dependentRelation == "Child2")
                    {
                        dependents[2] = value;
                    }
                }
            }
        }
        static Employee()
        {
            nextEmployeeNumber = 1001;
        }
        private Employee()
        {
            EmployeeId = nextEmployeeNumber;
            nextEmployeeNumber += 1;
            dependents = new string[3];
        }
        public Employee(out int employeeId, string employeeName,DateTime dateOfBirth,bool gender):this()
        {
            EmployeeName = employeeName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            employeeId = EmployeeId;
        }
        public Employee(out int employeeId, string employeeName, DateTime dateOfBirth, bool gender,ref short numberOfDependents,params string[] dependents) : this(out employeeId, employeeName,dateOfBirth,gender)
        {
            if (numberOfDependents < 0)
                numberOfDependents = 0;
            else if (numberOfDependents > 3)
                numberOfDependents = 3;
            else if (numberOfDependents > dependents.Length)
                numberOfDependents = Convert.ToInt16(dependents.Length);
            NumberOfDependents = numberOfDependents;
            for(int i = 0; i < numberOfDependents; i++)
            {
                this[i] = dependents[i];
            }
        }
        public int AddDependent(string dependentName)
        {
            if (NumberOfDependents < 3)
            {
                this[NumberOfDependents] = dependentName;
                return NumberOfDependents;
            }
            else
            {
                return 0;
            }
        }
        public bool UpdateDependents(string dependentName, int dependentId)
        {
            if(dependentId>0 && dependentId<=NumberOfDependents)
            {
                this[dependentId - 1] = dependentName;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
