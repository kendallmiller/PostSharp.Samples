# PostSharp.Samples

## Aspect Framework


| Example                                                                                                      | Description                                                                                  | Demonstrated PostSharp features                                                           |
| :----------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------- |
| [PostSharp.Samples.CustomLogging](Framework/PostSharp.Samples.CustomLogging/README.md)                       | Logs method calls including parameter values.                                                | Simple features of OnMethodBoundaryAspect, LocationInterceptionAspect.                   |
| [PostSharp.Samples.CustomCaching](Framework/PostSharp.Samples.CustomCaching/README.md)                       | Caches the results of methods calls                                                          | OnMethodBoundaryAspect: FlowBehavior, MethodExecutionTag.                                |
| [PostSharp.Samples.ExceptionHandling](Framework/PostSharp.Samples.ExceptionHandling/README.md)               | Add parameter values to call stack in exception details. Report and then swallow exceptions in entry points.  | OnExceptionAspect including FlowBehavior.  |
| [PostSharp.Samples.AutoRetry](Framework/PostSharp.Samples.AutoRetry/README.md)                               | Automatically retries a method call when it fails.                                           | MethodInterceptionAspect                                                                 |
| [PostSharp.Samples.WeakEvent](Framework/PostSharp.Samples.WeakEvent/README.md)                               | Prevents memory leaks due to events.                                                         | EventInterceptionAspect, IInstanceScopedAspect, InstanceLevelAspect, IntroduceInterface  |
| [PostSharp.Samples.ValidateResourceString](Framework/PostSharp.Samples.ValidateResourceString/README.md)     | Prints a build-time warning when incorrect resource string name is passed to parameter.      | ReferentialConstraint, ReflectionSearch, SyntaxTreeVisitor |
| [PostSharp.Samples.SessionState](Framework/PostSharp.Samples.SessionState/README.md)                         | Stores a field or property in the session state or page view state.                          | LocationInterceptionAspect, IInstanceScopedAspect, ImportMember           |
| [PostSharp.Samples.Transactions](Framework/PostSharp.Samples.Transactions/README.md)                         | Automatically executes a method inside a transaction.                                        | OnMethodBoundaryAspect : MethodExecutionTag                                              |
| [PostSharp.Samples.Profiling](Framework/PostSharp.Samples.Profiling/README.md)                               | Measure different execution times of methods, including async methods.                       | OnMethodBoundaryAspect : async methods, MethodExecutionTag 
| [PostSharp.Samples.Encryption](Framework/PostSharp.Samples.Encryption/README.md)                             | Automatically encrypts and decrypts parameter and fields/properties                          | IAspectProvider, MethodInterceptionAspect, IAdviceProvider, field imports |
| [PostSharp.Samples.MiniProfiler](Framework/PostSharp.Samples.MiniProfiler/README.md)                         | Measures method execution time with MiniProfiler of StackExchange.                           | OnMethodBoundaryAspect, MulticastAttribute. |
| [PostSharp.Samples.Persistence](Framework/PostSharp.Samples.Persistence/README.md)                           | Persists fields or properties into the Windows registry or `app.config`.                     | LocationInterceptionAspect |
| [PostSharp.Samples.AutoDataContract](Framework/PostSharp.Samples.AutoDataContract/README.md)                 | Automatically adds `[DataContract]` and `[DataMember]` attributes to derived classes and all properties | IAspectProvider, CustomAttributeIntroductionAspect, aspect inheritance. |
| [PostSharp.Samples.Authorization](Framework/PostSharp.Samples.Authorization/README.md)                       | Requires permissions before getting or setting fields or executing methods.                  | IAspectProvider, OnMethodBoundaryAspect, LocationInterceptionAspect, serialization |

## Diagnostics

| Example                                                                                                      | Description                                                                                  | Demonstrated PostSharp features                                                          |
| :----------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------- |
| [PostSharp.Samples.Logging.Customization](Diagnostics/PostSharp.Samples.Logging.Customization/README.md)     | Shows how to customize PostSharp Logging.                                                   | Formatter, IFormattablle, overriding LoggingBackend.                                     |
| [PostSharp.Samples.Logging.Console](Diagnostics/PostSharp.Samples.Logging.Console/README.md)                 | Demonstrates how to configure PostSharp Logging so that it directs its output to the *system console*.  | ConsoleLoggingBackend.                                                                   |
| [PostSharp.Samples.Logging.Etw](Diagnostics/PostSharp.Samples.Logging.Etw/README.md)                 | Demonstrates how to configure PostSharp Logging so that it directs its output to *ETW*.               | EventSourceLoggingBackend.                                                                   |
| [PostSharp.Samples.Logging.Log4Net](Diagnostics/PostSharp.Samples.Logging.Log4Net/README.md)                 | Demonstrates how to configure PostSharp Logging so that it directs its output to *log4net*.   | Log4NetLoggingBackend.                                                                   |
| [PostSharp.Samples.Logging.NLog](Diagnostics/PostSharp.Samples.Logging.NLog/README.md)                 | Demonstrates how to configure PostSharp Logging so that it directs its output to *NLog*.   | NLogLoggingBackend.                                                                   |
| [PostSharp.Samples.Logging.Serilog](Diagnostics/PostSharp.Samples.Logging.Serilog/README.md)                 | Demonstrates how to configure PostSharp Logging so that it directs its output to *Serilog*.   | SerilogLoggingBackend.                                                                   |
| [PostSharp.Samples.Logging.Loupe](Diagnostics/PostSharp.Samples.Logging.Loupe/README.md)                 | Demonstrates how to configure PostSharp Logging so that it directs its output to *Loupe*.   | LoupeLoggingBackend.                                                                   |
| [PostSharp.Samples.Logging.CommonLogging](Diagnostics/PostSharp.Samples.Logging.CommonLogging/README.md)                 | Demonstrates how to configure PostSharp Logging so that it directs its output to *Common.Logging*.   | CommonLoggingLoggingBackend.                                                                   |
| [PostSharp.Samples.Logging.CustomBackend.ServiceStack](Diagnostics/PostSharp.Samples.Logging.CustomBackend.ServiceStack/README.md)  | Demonstrates how to implement a PostSharp Logging adapter for your custom logging framework.   | TextLoggingBackend, LoggingTypeSource, TextLogRecordBuilder. |
| [PostSharp.Samples.Logging.Audit](Diagnostics/PostSharp.Samples.Audit/README.md)  | Shows how to append an audit record to a database when a method is invoked.   | [Audit], AuditServices.RecordPublished. |
| [PostSharp.Samples.Logging.Audit.Extended](Diagnostics/PostSharp.Samples.Audit.Extended/README.md)  | Shows how to add custom pieces of information to the audit record.   | AuditBackend, AuditRecordBuilder. |


## XAML


| Example                                                                                                      | Description                                                                                  | Demonstrated PostSharp features                                                           |
| :----------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------- |
| [PostSharp.Samples.Xaml](Xaml/PostSharp.Samples.Xaml/README.md)                                              | Demonstrates a few ready-made aspects that are useful for XAML                               | NotifyPropertyChanged, Recordable, Code Contracts, Background, ReaderWriterSynchronized     |

## Threading

| Example                                                                                                      | Description                                                                                  | Demonstrated PostSharp features                                                           |
| :----------------------------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------- |
| [PostSharp.Samples.Threading.PingPong](Threading/PostSharp.Samples.Threading.PingPong/README.md)             | The classic educational ping-pong example.                                                   | Actor |
| [PostSharp.Samples.Threading.ThreadDispatching](Threading/PostSharp.Samples.Threading.ThreadDispatching/README.md) | A simple WPF progress bar updated from a background thread.                            | Background, Dispatched |


## How to use these examples

* To **browse online**, use the samples browser at <http://samples.postsharp.net/>.
* To **download**, go to <https://www.github.com/postsharp/PostSharp.Samples>.



 