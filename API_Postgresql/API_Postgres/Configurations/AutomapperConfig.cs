using API_Postgres.Business.Models;
using API_Postgres.ViewModels;
using AutoMapper;

namespace API_Postgres.Configurations
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<PessoaVM, Pessoa>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.nome))
                .ForMember(dest => dest.Idade, opt => opt.MapFrom(src => src.idade))
            .ReverseMap();
        }
    }
}
