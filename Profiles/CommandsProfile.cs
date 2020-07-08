using AutoMapper;
using CmdSnippetsAPI.DTOs;
using CmdSnippetsAPI.Models;

namespace CmdSnippetsAPI.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}