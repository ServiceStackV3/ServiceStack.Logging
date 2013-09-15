SET NUGET=..\src\.nuget\nuget
%NUGET% pack ServiceStack.Logging.Elmah\servicestack.logging.elmah.nuspec -symbols
%NUGET% pack ServiceStack.Logging.EntLib5\servicestack.logging.entlib5.nuspec -symbols
%NUGET% pack ServiceStack.Logging.EventLog\servicestack.logging.eventlog.nuspec -symbols
%NUGET% pack ServiceStack.Logging.Log4Net\servicestack.logging.log4net.nuspec -symbols
%NUGET% pack ServiceStack.Logging.Log4Netv129\servicestack.logging.log4netv129.nuspec -symbols
%NUGET% pack ServiceStack.Logging.Log4Netv1210\servicestack.logging.log4netv1210.nuspec -symbols
%NUGET% pack ServiceStack.Logging.NLog\servicestack.logging.nlog.nuspec -symbols

