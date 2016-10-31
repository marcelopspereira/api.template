using api.template.ApplicationService.Services;
using api.template.Domain.Repository;
using api.template.Domain.Services;
using api.template.Infra.DataContexts;
using api.template.Infra.Repository;
using api.template.Infra.UnitOfWork;
using SimpleInjector;


namespace api.template.CrossCutting.IoC
{
  public  class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // App
            container.Register<IPropostaApplicationService, PropsotaApplicationService>(Lifestyle.Scoped);

            // Domain
            container.Register<IPropostaService, PropostaService>(Lifestyle.Scoped);

            // Data
            container.Register<IPropostaRepository, PropostaRepository>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<AppDataContext>(Lifestyle.Scoped);
        }
    }
}
