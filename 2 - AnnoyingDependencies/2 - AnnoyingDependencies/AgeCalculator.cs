using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___AnnoyingDependencies
{
    public class AgeCalculator
    {
        public void CalculateAgeInDays(string enteredbirthday)
        {
            DateTime birthday = DateTime.Parse(enteredbirthday);

            Logger.LogInfo("You entered your birthday as: " + birthday.ToShortDateString());

            TimeSpan diff = DateTime.Now - birthday;
            
            Logger.LogInfo(diff.Days + " days have passed since that day.");
        }
    }
}
