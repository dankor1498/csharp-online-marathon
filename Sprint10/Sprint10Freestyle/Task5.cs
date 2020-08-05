using System;
using System.IO;

namespace Sprint10Freestyle
{
    namespace Task5
    {
        public interface ILogger
        {
            void LogMessage(string message);
        }
        
        public class DbLogger : ILogger
        {
            public void LogMessage(string mMessage)
            {
                //Code to write message in database.  
            }
        }

        public class FileLogger : ILogger
        {
            public void LogMessage(string mStackTrace)
            {
                //code to log stack trace into a file.  
            }
        }

        public class ExceptionLogger
        {
            private ILogger _logger;

            public ExceptionLogger(ILogger logger)
            {
                this._logger = logger;
            }

            public void LogException(Exception mException)
            {
                _logger.LogMessage(GetUserReadableMessage(mException));
            }

            private string GetUserReadableMessage(Exception ex)
            {
                string strMessage = string.Empty;
                //code to convert Exception's stack trace and message to user   
                // readable format.  
                return strMessage;
            }
        }

        public class DataExporter
        {
            public void ExportDataFromFile()
            {
                try
                {
                    //code to export data from files to database.  
                }
                catch (IOException ex)
                {
                    new ExceptionLogger(new DbLogger()).LogException(ex);
                }
                catch (Exception ex)
                {
                    new ExceptionLogger(new FileLogger()).LogException(ex);
                }
            }
        }
    }
}
