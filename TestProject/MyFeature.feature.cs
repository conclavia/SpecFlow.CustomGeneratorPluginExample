﻿#error TechTalk.SpecFlow.Generator.Interfaces.TestGenerationError
#error TechTalk.SpecFlow.Generator
#error Server stack trace: 
#error    at TechTalk.SpecFlow.Generator.Plugins.GeneratorPluginLoader.LoadPlugin(PluginDescriptor pluginDescriptor)
#error    at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.<>c__DisplayClass3.<LoadPlugins>b__1(PluginDescriptor pd)
#error    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
#error    at System.Linq.Enumerable.<ConcatIterator>d__59`1.MoveNext()
#error    at System.Linq.Buffer`1..ctor(IEnumerable`1 source)
#error    at System.Linq.Enumerable.ToArray[TSource](IEnumerable`1 source)
#error    at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.LoadPlugins(ObjectContainer container, IGeneratorConfigurationProvider configurationProvider, SpecFlowConfigurationHolder configurationHolder)
#error    at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at System.Runtime.Remoting.Messaging.StackBuilderSink._PrivateProcessMessage(IntPtr md, Object[] args, Object server, Object[]& outArgs)
#error    at System.Runtime.Remoting.Messaging.StackBuilderSink.SyncProcessMessage(IMessage msg)
#error Exception rethrown at [0]: 
#error    at System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg)
#error    at System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type)
#error    at TechTalk.SpecFlow.Generator.Interfaces.ITestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.RemoteAppDomainTestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.GeneratorServices.CreateTestGenerator()
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.IdeSingleFileGenerator.GenerateCode(String inputFilePath, String inputFileContent, GeneratorServices generatorServices, ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.IdeSingleFileGenerator.Generate(String inputFilePath, String inputFileContent, GeneratorServices generatorServices, CodeDomHelper codeDomHelper, ProjectSettings projectSettings)