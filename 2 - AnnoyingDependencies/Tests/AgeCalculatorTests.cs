using System;
using System.Collections.Generic;
using _2___AnnoyingDependencies;
using log4net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AgeCalculatorTests
    {
        [TestMethod]
        public void AgeCalculator_CalculatesTheRightNumberOfDays()
        {
            LoggerMock logMock = new LoggerMock();
            DateTime now = new DateTime(1981, 4, 1);
            AgeCalculator ageCalculator = new AgeCalculator(logMock, now);

            ageCalculator.CalculateAgeInDays("31/03/1981");

            Assert.AreEqual(2, logMock.MessagesLogged.Count, "Two messages should be logged");
            Assert.AreEqual("You entered your birthday as: 31-03-1981", logMock.MessagesLogged[0]);
            Assert.AreEqual("1 days have passed since that day.", logMock.MessagesLogged[1]);
        }

        private class LoggerMock : ILog
        {
            // err... propably should have wrapped this api??.. just not having it static... look at how huge the interface is :(  
            // (but if we used a mocking framework this would show just as much)

            public List<string> MessagesLogged = new List<string>();

            public void Info(object message)
            {
                MessagesLogged.Add(message.ToString());
            }

            public void Debug(object message, Exception exception)
            {
                throw new NotImplementedException();
            }

            public void Debug(object message)
            {
                throw new NotImplementedException();
            }

            public void DebugFormat(IFormatProvider provider, string format, params object[] args)
            {
                throw new NotImplementedException();
            }

            public void DebugFormat(string format, object arg0, object arg1, object arg2)
            {
                throw new NotImplementedException();
            }

            public void DebugFormat(string format, object arg0, object arg1)
            {
                throw new NotImplementedException();
            }

            public void DebugFormat(string format, object arg0)
            {
                throw new NotImplementedException();
            }

            public void DebugFormat(string format, params object[] args)
            {
                throw new NotImplementedException();
            }

            public void Error(object message, Exception exception)
            {
                throw new NotImplementedException();
            }

            public void Error(object message)
            {
                throw new NotImplementedException();
            }

            public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
            {
                throw new NotImplementedException();
            }

            public void ErrorFormat(string format, object arg0, object arg1, object arg2)
            {
                throw new NotImplementedException();
            }

            public void ErrorFormat(string format, object arg0, object arg1)
            {
                throw new NotImplementedException();
            }

            public void ErrorFormat(string format, object arg0)
            {
                throw new NotImplementedException();
            }

            public void ErrorFormat(string format, params object[] args)
            {
                throw new NotImplementedException();
            }

            public void Fatal(object message, Exception exception)
            {
                throw new NotImplementedException();
            }

            public void Fatal(object message)
            {
                throw new NotImplementedException();
            }

            public void FatalFormat(IFormatProvider provider, string format, params object[] args)
            {
                throw new NotImplementedException();
            }

            public void FatalFormat(string format, object arg0, object arg1, object arg2)
            {
                throw new NotImplementedException();
            }

            public void FatalFormat(string format, object arg0, object arg1)
            {
                throw new NotImplementedException();
            }

            public void FatalFormat(string format, object arg0)
            {
                throw new NotImplementedException();
            }

            public void FatalFormat(string format, params object[] args)
            {
                throw new NotImplementedException();
            }

            public void Info(object message, Exception exception)
            {
                throw new NotImplementedException();
            }

            public void InfoFormat(IFormatProvider provider, string format, params object[] args)
            {
                throw new NotImplementedException();
            }

            public void InfoFormat(string format, object arg0, object arg1, object arg2)
            {
                throw new NotImplementedException();
            }

            public void InfoFormat(string format, object arg0, object arg1)
            {
                throw new NotImplementedException();
            }

            public void InfoFormat(string format, object arg0)
            {
                throw new NotImplementedException();
            }

            public void InfoFormat(string format, params object[] args)
            {
                throw new NotImplementedException();
            }

            public bool IsDebugEnabled
            {
                get { throw new NotImplementedException(); }
            }

            public bool IsErrorEnabled
            {
                get { throw new NotImplementedException(); }
            }

            public bool IsFatalEnabled
            {
                get { throw new NotImplementedException(); }
            }

            public bool IsInfoEnabled
            {
                get { throw new NotImplementedException(); }
            }

            public bool IsWarnEnabled
            {
                get { throw new NotImplementedException(); }
            }

            public void Warn(object message, Exception exception)
            {
                throw new NotImplementedException();
            }

            public void Warn(object message)
            {
                throw new NotImplementedException();
            }

            public void WarnFormat(IFormatProvider provider, string format, params object[] args)
            {
                throw new NotImplementedException();
            }

            public void WarnFormat(string format, object arg0, object arg1, object arg2)
            {
                throw new NotImplementedException();
            }

            public void WarnFormat(string format, object arg0, object arg1)
            {
                throw new NotImplementedException();
            }

            public void WarnFormat(string format, object arg0)
            {
                throw new NotImplementedException();
            }

            public void WarnFormat(string format, params object[] args)
            {
                throw new NotImplementedException();
            }

            public log4net.Core.ILogger Logger
            {
                get { throw new NotImplementedException(); }
            }
        }
    }
}

/* Steps in getting it to unit test
 * 
 * 1. Write the unit test as should would like the code to be
 * 
 * 2. Refactor it so it compiles
 * 
 * 3. Extract the dendencies you need to stub/mock
 * 
 * 4. Make the test pass
 * 
 */
