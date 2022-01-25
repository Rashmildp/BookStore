using Autofac;
using PracticeAPI.Services;

namespace PracticeAPI.Dependency
{
    public class DependencyRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookSqlService>().As<IbookRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AuthorSqlRepository>().As<IAuthorRepository>().InstancePerLifetimeScope();

        }

    }
}
