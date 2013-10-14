# The latest Logging projects have now been merged into the main [ServiceStack](https://github.com/ServiceStack/ServiceStack/) repo.

----

[Join the ServiceStack Google+ group](http://groups.google.com/group/servicestack) or
follow [@ServiceStack](http://twitter.com/servicestack) for project updates.

## An implementation-free logging API for .Net

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

_Commercial support will be available for ServiceStack, contact team@servicestack.net for details_

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

## Copying

Since September 2013, ServiceStack source code is available under GNU Affero General Public License/FOSS License Exception, see license.txt in the source. Alternative commercial licensing is also available, contact team@servicestack.net for details.

## Contributing

Commits should be made to the **v3-fixes** branch so they can be merged into both **v3** and **master** (v4) release branches. 
Contributors need to approve the [Contributor License Agreement](https://docs.google.com/forms/d/16Op0fmKaqYtxGL4sg7w_g-cXXyCoWjzppgkuqzOeKyk/viewform) before any code will be reviewed, see the [Contributing wiki](https://github.com/ServiceStack/ServiceStack/wiki/Contributing) for more details. 
