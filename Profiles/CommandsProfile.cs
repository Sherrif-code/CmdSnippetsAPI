using AutoMapper;
using CmdSnippetsAPI.DTOs;
using CmdSnippetsAPI.Models;

namespace CmdSnippetsAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
        }
    }
}