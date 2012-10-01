using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace _2___AnnoyingDependencies
{
    public class AgeCalculator
    {
        private readonly ILog logger;
        private DateTime now;

        public AgeCalculator(ILog logger, DateTime now)
        {
            this.logger = logger;
            this.now = now;
        }

        public void CalculateAgeInDays(string enteredbirthday)
        {
            DateTime birthday = DateTime.Parse(enteredbirthday);

            logger.Info("You entered your birthday as: " + birthday.ToShortDateString());

            TimeSpan diff = this.now - birthday;
            
            logger.Info(diff.Days + " days have passed since that day.");
        }
    }
}
