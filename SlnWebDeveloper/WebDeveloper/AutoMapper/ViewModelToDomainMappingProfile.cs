using AutoMapper;
using WebDeveloper.Domain.Entities;
using WebDeveloper.ViewModels;

namespace WebDeveloper.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomain"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<DesenvolvedorViewModel, Desenvolvedor>();
        }

    }
}