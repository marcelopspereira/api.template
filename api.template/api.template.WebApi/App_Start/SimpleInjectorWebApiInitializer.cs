﻿
using System.Web.Http;
using api.template.CrossCutting.IoC;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(api.template.WebApi.SimpleInjectorWebApiInitializer), "Initialize")]
namespace api.template.WebApi
{
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            BootStrapper.RegisterServices(container);
        }
    }
}