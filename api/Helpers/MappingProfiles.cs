using api.Dto;
using api.Models;
using AutoMapper;

namespace api.Helpers
{
  public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>();
        }
    }
}