using AutoMapper;
using CleanArchitecture.SharedLibrary.Common.DTOs;
using JamaicaOpenData.SharedLibrary.Common.DTOs;

namespace CleanArchitecture.Infrastructure.Common.Mappings
{
    public class PaginatedListMappingProfile: Profile
    {
        public PaginatedListMappingProfile()
        {
            CreateMap(typeof(JoaResultDto<>), typeof(PaginatedList<>));
        }
    }
}
