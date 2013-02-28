## An implementation-free logging API for .Net

For twitter updates follow <a href="http://twitter.com/demisbellot">@demisbellot</a> or <a href="http://twitter.com/servicestack">@ServiceStack</a>

**ServiceStack.Logging** is an implementation and dependency-free logging API with adapters for all of .NET's popular logging providers.
It allows your business logic to bind to an easily-mockable and testable dependency-free interface whilst providing the flexibility to switch logging providers at runtime.

## Download on NuGet

Currently there are 6 different .NET logging providers available on NuGet:

#### Install-Package [ServiceStack.Logging.NLog](https://nuget.org/packages/ServiceStack.Logging.NLog)
#### Install-Package [ServiceStack.Logging.Elmah](https://nuget.org/packages/ServiceStack.Logging.Elmah)
#### Install-Package [ServiceStack.Logging.Log4Net](https://nuget.org/packages/ServiceStack.Logging.Log4Net)
#### Install-Package [ServiceStack.Logging.Log4Netv129](https://nuget.org/packages/ServiceStack.Logging.Log4Netv129)
#### Install-Package [ServiceStack.Logging.EventLog](https://nuget.org/packages/ServiceStack.Logging.EventLog)
#### Install-Package [ServiceStack.Logging.EnterpriseLibrary5](https://nuget.org/packages/ServiceStack.Logging.EnterpriseLibrary5/)

Note: The ConsoleLogger and DebugLogger and are already built-in and bind to .NET Framework's Console and Debug loggers

-----

Even in the spirit of **Bind to interfaces, not implemenations**, many .NET projects still have
a hard dependency to [log4net](http://logging.apache.org/log4net/index.html). 

Although log4net is the standard for logging in .NET, potential problems can arise from your libraries having a hard dependency on it:

* Your library needs to be shipped with a third-party dependency
* Potential conflicts can occur when different libraries have dependency on different versions of log4net (e.g. the 1.2.9 / 1.2.10 dependency problem).
* You may want to use a different logging provider (i.e. network distributed logging)
* You want your logging for Unit and Integration tests to redirect to the Console or Debug logger without any configuraiton.
* Something better like [elmah](http://code.google.com/p/elmah/) can come along requiring a major rewrite to take advantage of it

ServiceStack.Logging solves these problems by providing an implementation-free ILog interface that your application logic can bind to 
where your Application Host project can bind to the concrete logging implementation at deploy or runtime.

ServiceStack.Logging also includes adapters for the following logging providers:

* Elmah
* NLog
* Log4Net 1.2.10+
* Log4Net 1.2.9
* Enterprise Library 5.0
* EventLog
* Console Log
* Debug Log
* Null / Empty Log

# Usage Examples

Once on your App Startup, either In your AppHost.cs or Global.asax file inject the concrete logging implementation that your app should use, e.g.

## Log4Net
    LogManager.LogFactory = new Log4NetFactory(true); //Also runs log4net.Config.XmlConfigurator.Configure()

## Event Log
    LogManager.LogFactory = new EventLogFactory("ServiceStack.Logging.Tests", "Application");

Then your application logic can bind to and use a lightweight implementation-free ILog which at runtime will be an instance of the concrete implementation configured in your host:

    ILog log = LogManager.GetLogger(GetType());

    log.Debug("Debug Event Log Entry.");
    log.Warn("Warning Event Log Entry.");




