using AutoMapper;
using PortfolioApps.DTOs;
using PortfolioApps.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PortfolioApps.Utilidades
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile() 
        {
            CreateMap<CreacionElementoDTO, Elemento>();
            CreateMap<Elemento, ElementoDTO>();
            CreateMap<Grupo, GenericDTO>();
            CreateMap<GenericCreacionDTO, Grupo>();
            CreateMap<Reaccion, GenericDTO>();
            CreateMap<GenericCreacionDTO, Reaccion>();
            //CreateMap<ElementoReaccion, ElementoReaccionDTO>();
        }

    }
}
