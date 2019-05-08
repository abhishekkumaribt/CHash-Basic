using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infosys.QuickKartBusinessLayer
{
    class Trainee
    {
        private string[] focusArea;
        private float[] marks;
        public Trainee(string[] focusArea,float[] marks)
        {
            this.focusArea = focusArea;
            this.marks = marks;
        }
        public float CalculateScore(out float percentage, out char grade, out string message, bool isRetest = false)
        {
            float totalScore;
            totalScore = marks.Sum();
            if (isRetest)
                totalScore = totalScore * 0.9f;
            percentage = totalScore / marks.Length;
            if (percentage >= 85)
                grade = 'A';
            else if (percentage >= 75 && percentage <= 84)
                grade = 'B';
            else if (percentage >= 0 && percentage < 75)
                grade = 'C';
            else
                grade = 'N';
            if (percentage >= 50)
                message = "Qualified";
            else
                message = "Not Qualified";
            return totalScore;
        }
    }
}
