using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID_Case_Answer.Case_Answer_4_ISP
{
    #region Bad Code
    // Segregated logging interfaces
    public interface IMessageLogger
    {
        void LogMessage(string message);
    }

    public interface IWarningLogger
    {
        void LogWarning(string message);
    }

    public interface IErrorLogger
    {
        void LogError(string message);
    }

    public class FileLogger : IMessageLogger , IWarningLogger
    {
        public void LogMessage(string message)
        {
            // Log message to file
        }

        public void LogWarning(string message)
        {
            // Log warning to file
        }
    }

    public class DatabaseLogger : IWarningLogger, IMessageLogger, IErrorLogger
    {
        public void LogError(string message)
        {
            // Log message to database
        }

        public void LogMessage(string message)
        {
            // Log message to database
        }

        public void LogWarning(string message)
        {
            // Log warning to database
        }
    }

    #endregion
}
