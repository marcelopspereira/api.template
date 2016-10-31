using AutoMapper;

namespace api.template.ApplicationService.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();
            });

            // initialize you mapper config
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.AddProfile<DomainToViewModelMappingProfile>();
            //    cfg.AddProfile<ViewModelToDomainMappingProfile>();
            //});

            //var config = new MapperConfiguration(cfg =>
            //{
            //    //cfg.CreateMap<AbcEditViewModel, Abc>();
            //    //cfg.CreateMap<Proposta, PropostaViewModel>();
            //    //cfg.CreateMap<Proposta, PropostaVeiculoViewModel>();
            //    //cfg.CreateMap<Veiculo, VeiculoViewModel>();
            //    //cfg.CreateMap<Veiculo, PropostaVeiculoViewModel>();

            //    cfg.CreateMap<PropostaViewModel, Proposta>();
            //    //cfg.CreateMap<PropostaVeiculoViewModel, Proposta>();
            //    //cfg.CreateMap<VeiculoViewModel, Veiculo>();
            //    //cfg.CreateMap<PropostaVeiculoViewModel, Veiculo>();
            //});

            //IMapper mapper = config.CreateMapper();
            //var source = new PropostaViewModel();
            //var dest = mapper.Map<PropostaViewModel, Proposta>(source);

            //IMapper mapper = config.CreateMapper();
            //var source = new Source();
            //var dest = mapper.Map<Source, Dest>(source);
            //// and then use it
            
        }
    }
}
