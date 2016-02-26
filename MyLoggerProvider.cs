using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace EFLogging
{
    public class MyLoggerProvider2 : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new MyLogger();
        }

        public void Dispose()
        { }

        private class MyLogger : ILogger
        {
          //  'MyLoggerProvider2.MyLogger' does not implement interface member 
          
         //'ILogger.Log<TState>(LogLevel, EventId, TState, Exception, Func<TState, Exception, string>)'
            
            
            public bool IsEnabled(LogLevel logLevel)
            {
                return true;
            }

            //'ILogger.Log<TState>(LogLevel, EventId, TState, Exception, Func<TState, Exception, string>)'
         public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            //Logged.Add(new LoggerData(logLevel, state));
                   Console.WriteLine("--------"+ System.Environment.NewLine+formatter(state, exception));
       
        }
        //  public void Log(LogLevel logLevel, int eventId, object state, Exception exception, Func<object, Exception, string> formatter)
        //     {
        //        // File.AppendAllText(@"C:\temp\log.txt", formatter(state, exception));
        //         Console.WriteLine("--------"+ System.Environment.NewLine+formatter(state, exception));
        //     }

            public IDisposable BeginScopeImpl(object state)
            {
                return null;
            }
        } 
    }
}