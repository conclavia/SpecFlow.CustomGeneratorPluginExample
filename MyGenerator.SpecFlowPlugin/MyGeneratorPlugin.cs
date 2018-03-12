using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using TechTalk.SpecFlow.Generator.Configuration;
using TechTalk.SpecFlow.Generator.Plugins;

namespace MyGenerator.SpecFlowPlugin
{
    public class MyGeneratorPlugin : IGeneratorPlugin
    {
        public void RegisterConfigurationDefaults(SpecFlowProjectConfiguration specFlowConfiguration) { }

        public void RegisterCustomizations(ObjectContainer container,
            SpecFlowProjectConfiguration generatorConfiguration)
        { }

        public void RegisterDependencies(ObjectContainer container) { }
    }
}
