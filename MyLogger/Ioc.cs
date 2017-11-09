using Autofac;
using MyLogger.Interfaces;
using MyLogger.Strategies.Config;
using MyLogger.Strategies.Formatter;
using MyLogger.Strategies.Logger;
using MyLogger.Strategies.Reader;
using MyLogger.Strategies.Writer;

namespace MyLogger
{
    internal class Ioc
    {
        private static IContainer _container;

        public static IContainer Container
        {
            get
            {
                if (_container == null)
                    RegisterComponents();
                return _container;
            }
            set { _container = value; }
        }

        public static void RegisterComponents()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FileReader>().As<IReader>();
            builder.RegisterType<TextLogWriter>().As<IWriter>();
            builder.RegisterType<ConfigFile>().As<ILogConfigReader>();
            builder.RegisterType<TextLogFormatter>().As<ILogFormatter>();
            builder.RegisterType<TextLogger>().As<ILogger>();

            Container = builder.Build();
        }
    }
}