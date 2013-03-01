using System;

namespace ServiceStack.Logging.Log4Net
{
    /// <summary>
    /// Wrapper over the log4net.1.2.10 and above logger 
    /// </summary>
	public class Log4NetLogger : ILog
    {
        private readonly log4net.ILog _log;

        public Log4NetLogger(string typeName)
        {
            _log = log4net.LogManager.GetLogger(typeName);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log4NetLogger"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public Log4NetLogger(Type type)
        {
            _log = log4net.LogManager.GetLogger(type);
        }

		public bool IsDebugEnabled { get { return _log.IsDebugEnabled; } }
	
		/// <summary>
        /// Logs a Debug message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(object message)
        {
            if (_log.IsDebugEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Debug, message, null);
        }

        /// <summary>
        /// Logs a Debug message and exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Debug(object message, Exception exception)
        {
            if (_log.IsDebugEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Debug, message, exception);
		}

        /// <summary>
        /// Logs a Debug format message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void DebugFormat(string format, params object[] args)
        {
            if (_log.IsDebugEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Debug, String.Format (format, args), null);
        }

        /// <summary>
        /// Logs a Error message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Error(object message)
        {
            if (_log.IsErrorEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Error, message, null);
        }

        /// <summary>
        /// Logs a Error message and exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Error(object message, Exception exception)
        {
            if (_log.IsErrorEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Error, message, exception);
        }

        /// <summary>
        /// Logs a Error format message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void ErrorFormat(string format, params object[] args)
        {
            if (_log.IsErrorEnabled)
            _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Error, String.Format (format, args), null);
        }

        /// <summary>
        /// Logs a Fatal message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Fatal(object message)
        {
            if (_log.IsFatalEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Fatal, message, null);
        }

        /// <summary>
        /// Logs a Fatal message and exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Fatal(object message, Exception exception)
        {
            if (_log.IsFatalEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Fatal, message, exception);
        }

        /// <summary>
        /// Logs a Error format message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void FatalFormat(string format, params object[] args)
        {
            if (_log.IsFatalEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Fatal, String.Format(format, args), null);
        }

        /// <summary>
        /// Logs an Info message and exception.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Info(object message)
        {
            if (_log.IsInfoEnabled)
				_log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Info, message, null);
        }

        /// <summary>
        /// Logs an Info message and exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Info(object message, Exception exception)
        {
            if (_log.IsInfoEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Info, message, exception);
        }

        /// <summary>
        /// Logs an Info format message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void InfoFormat(string format, params object[] args)
        {
            if (_log.IsInfoEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Info, String.Format (format, args), null);
        }

        /// <summary>
        /// Logs a Warning message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Warn(object message)
        {
            if (_log.IsWarnEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Warn, message, null);
        }

        /// <summary>
        /// Logs a Warning message and exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Warn(object message, Exception exception)
        {
            if (_log.IsWarnEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Warn, message, exception);
        }

        /// <summary>
        /// Logs a Warning format message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void WarnFormat(string format, params object[] args)
        {
            if (_log.IsWarnEnabled)
                _log.Logger.Log(typeof(Log4NetLogger), log4net.Core.Level.Warn, String.Format(format, args), null);
        }
    }
}