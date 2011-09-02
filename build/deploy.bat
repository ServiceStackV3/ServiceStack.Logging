COPY ..\src\ServiceStack.Logging.EventLog\bin\Release\ServiceStack.Logging.EventLog.* release\ServiceStack.Logging\EventLog
COPY ..\src\ServiceStack.Logging.Log4Net\bin\Release\ServiceStack.Logging.Log4Net.* release\ServiceStack.Logging\Log4Net
COPY ..\src\ServiceStack.Logging.Log4Netv129\bin\Release\ServiceStack.Logging.Log4Netv129.* release\ServiceStack.Logging\Log4Netv129
COPY ..\src\ServiceStack.Logging.EventLog\bin\Release\ServiceStack.Logging.Elmah.* release\ServiceStack.Logging\Elmah
COPY ..\lib\log4net.1.2.9.dll release\ServiceStack.Logging\Log4Netv129\
COPY ..\lib\log4net.dll release\ServiceStack.Logging\Log4Net\
COPY ..\lib\Elmah.dll release\ServiceStack.Logging\Elmah\
COPY ..\lib\ServiceStack.Interfaces.dll release\ServiceStack.Logging\

