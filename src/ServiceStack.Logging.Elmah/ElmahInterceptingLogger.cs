using System;
using System.Web;
using Elmah;

namespace ServiceStack.Logging.Elmah
{
	/// <summary>	Writes Elmah intercepting logger.  </summary>
	/// <remarks>	9/2/2011. </remarks>
	public class ElmahInterceptingLogger 
		: ILog
	{
		private readonly ILog _log;
		private readonly ErrorLog _errorLog;

		/// <summary>	Constructor. </summary>
		/// <remarks>
		/// Logs to Elmahs ErrorLog.GetDefault.  Only Error and Fatal are passed along to Elmah, while all other errors will be written to the
		/// wrapped logger.
		/// </remarks>
		/// <param name="log">	The underlying log to write to. </param>
		///
		/// <exception cref="ArgumentNullException">	Thrown when the wrapped log is null. </exception>
		public ElmahInterceptingLogger(ILog log)
			: this(log, ErrorLog.GetDefault(HttpContext.Current))
		{ }

		/// <summary>	Constructor. </summary>
		/// <remarks>
		/// Logs to the given Elmah ErrorLog.  Only Error and Fatal are passed along to Elmah, while all other errors will be written to the
		/// wrapped logger.
		/// </remarks>
		/// <exception cref="ArgumentNullException">	Thrown when either the wrapped ILog or Elmah ErrorLog are null. </exception>
		/// <param name="log">	   	The underlying log to write to. </param>
		/// <param name="errorLog">	The error log. </param>
		public ElmahInterceptingLogger(ILog log, ErrorLog errorLog)
		{
			if (null == log) { throw new ArgumentNullException("log"); }
			if (null == errorLog) { throw new ArgumentNullException("errorLog"); }

			_log = log;
			_errorLog = errorLog;
		}

		public void Debug(object message, Exception exception)
		{
			_log.Debug(message, exception);
		}

		public void Debug(object message)
		{
			_log.Debug(message);
		}

		public void DebugFormat(string format, params object[] args)
		{
			_log.DebugFormat(format, args);
		}

		public void Error(object message, Exception exception)
		{
			_errorLog.Log(new Error(exception, HttpContext.Current));
			_log.Error(message, exception);
		}

		public void Error(object message)
		{
			_errorLog.Log(new Error(new System.ApplicationException(message.ToString()), HttpContext.Current));
			_log.Error(message);
		}

		public void ErrorFormat(string format, params object[] args)
		{
			_errorLog.Log(new Error(new System.ApplicationException(string.Format(format, args)), HttpContext.Current));
			_log.ErrorFormat(format, args);
		}

		public void Fatal(object message, Exception exception)
		{
			_errorLog.Log(new Error(exception, HttpContext.Current));
			_log.Fatal(message, exception);
		}

		public void Fatal(object message)
		{
			_errorLog.Log(new Error(new System.ApplicationException(message.ToString()), HttpContext.Current));
			_log.Fatal(message);
		}

		public void FatalFormat(string format, params object[] args)
		{
			_errorLog.Log(new Error(new System.ApplicationException(string.Format(format, args)), HttpContext.Current));
			_log.FatalFormat(format, args);
		}

		public void Info(object message, Exception exception)
		{
			_log.Info(message, exception);
		}

		public void Info(object message)
		{
			_log.Info(message);
		}

		public void InfoFormat(string format, params object[] args)
		{
			_log.InfoFormat(format, args);
		}

		public bool IsDebugEnabled
		{
			get { return _log.IsDebugEnabled; }
		}

		public void Warn(object message, Exception exception)
		{
			_log.Warn(message, exception);
		}

		public void Warn(object message)
		{
			_log.Warn(message);
		}

		public void WarnFormat(string format, params object[] args)
		{
			_log.WarnFormat(format, args);
		}
	}
}