using System.Reflection;

// EasyNetQ version number: <major>.<minor>.0.<build>
[assembly: AssemblyVersion("0.6.0.1")]

// 0.6 Introduced IAdvancedBus, refactored IBus
// 0.5 Added IPublishChannel and moved Publish and Request to it from IBus
// 0.4 Topic based routing
// 0.3 Upgrade to RabbitMQ.Client 2.8.1.0
// 0.2 Upgrade to RabbitMQ.Client 2.7.0.0
// 0.1 Initial