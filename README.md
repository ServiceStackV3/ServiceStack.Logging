##ServiceStack.Logging an implementation-free logging interface for your app logic to bind to.

Even in the spirit of **Bind to interfaces, not implemenations**, many .NET projects still have
a hard dependency to [log4net](http://logging.apache.org/log4net/index.html). 

Although log4net is the standard for logging in .NET, potential problems can arise from your libraries having a hard dependency on it:

* Your library needs to be shipped with a third-party dependency
* Potential conflicts can occur when different libraries have dependency on different versions of log4net (e.g. the 1.2.9 / 1.2.10 dependency problem).
* You may want to use a different logging provider (i.e. network distributed logging)
* You want your logging for Unit and Integration tests to redirect to the Console or Debug logger without any configuraiton.

ServiceStack.Logging solves these problems by providing an implementation-free ILog interface that your application logic can bind to 
where your Application Host project can bind to the concrete logging implementation at deploy or runtime.

ServiceStack.Logging also includes adapters for the following logging providers:

* Log4Net 1.2.10+
* Log4Net 1.2.9
* EventLog
* Console Log
* Debug Log
