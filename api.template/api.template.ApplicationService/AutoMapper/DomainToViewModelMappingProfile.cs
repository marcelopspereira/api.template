using api.template.ApplicationService.ViewModels;
using api.template.Domain.Entities;
using AutoMapper;


namespace api.template.ApplicationService.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        protected  override void Configure()
        {
            CreateMap<Proposta, PropostaViewModel>();
            CreateMap<Proposta, PropostaVeiculoViewModel>();
            CreateMap<Veiculo, VeiculoViewModel>();
            CreateMap<Veiculo, PropostaVeiculoViewModel>();
        }
    }
}
