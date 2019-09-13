using System;

namespace dummy_api.DataClasses
{
   public class ErrorExceptionResource 
    {
        public string Message { get; set; }

        public string StackTrace { get; set; }

        public ErrorExceptionResource(Exception ex)
        {
            Message = ex.Message;
            StackTrace = ex.StackTrace;
        }
    }
}