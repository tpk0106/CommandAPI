using CommandAPI.Dtos;
using CommandAPI.Models;
using AutoMapper;
namespace CommandAPI.Profiles
{
    public class CommandProfiles:Profile
    {
        public CommandProfiles()
        {
            CreateMap<Command,CommandReadDto>();
            CreateMap<CommandCreateDto,Command>();
            CreateMap<CommandUpdateDto,Command>();
            CreateMap<Command,CommandUpdateDto>();
        }
    }
}