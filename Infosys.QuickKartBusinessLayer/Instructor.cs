using System;
using System.Collections.Generic;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    public class Instructor
    {
        private float avgFeedback;
        private int experience;
        private string instructorName;
        private string[] instructorSkill;
        public Instructor()
        {

        }
        public Instructor(string instructorName,float avgFeedback,int experience,string[] instructorSkill)
        {
            this.instructorName = instructorName;
            this.avgFeedback = avgFeedback;
            this.experience = experience;
            this.instructorSkill = instructorSkill;
        }
        public bool ValidateEligibility()
        {
            bool eligibility = false;
            if (experience > 3 && avgFeedback >= 4.5)
                eligibility = true;
            if (experience <= 3 && avgFeedback >= 4)
                eligibility = true;
            return eligibility;
        }
        public bool CheckSkill(string technology)
        {
            bool eligible = false;
            if(ValidateEligibility())
            {
                foreach(string skill in instructorSkill)
                {
                    if (skill == technology)
                    {
                        eligible = true;
                        break;
                    }
                }
            }
            return eligible;
        }
    }
}
