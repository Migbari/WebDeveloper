using AutoMapper;
using WebDeveloper.Domain.Entities;
using WebDeveloper.ViewModels;

namespace WebDeveloper.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName 
        {
            get { return "DomainToViewModelMappings"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<Desenvolvedor, DesenvolvedorViewModel>();
        }

    }
}