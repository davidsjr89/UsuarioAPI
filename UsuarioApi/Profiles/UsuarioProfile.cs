using AutoMapper;
using UsuarioApi.Data.Dtos;
using UsuarioApi.Data.Models;

namespace UsuarioApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>().ReverseMap();
        }
    }
}
