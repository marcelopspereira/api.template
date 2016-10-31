using api.template.ApplicationService.ViewModels;
using api.template.Domain.Entities;
using AutoMapper;

namespace api.template.ApplicationService.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<PropostaViewModel, Proposta>();
            CreateMap<PropostaVeiculoViewModel, Proposta>();
            CreateMap<VeiculoViewModel, Veiculo>();
            CreateMap<PropostaVeiculoViewModel, Veiculo>();
        }
    }
}