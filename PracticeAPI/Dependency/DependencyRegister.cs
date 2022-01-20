using Autofac;
using PracticeAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace PracticeAPI.Dependency
{
    public class DependencyRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookService>().As<IbookRepository>().InstancePerLifetimeScope();
        }

    }
}
