using RealEstate_Dapper_Api.Dtos.SubFeatureDtos;
using RealEstate_Dapper_Api.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_Api.Repositories.SubFeatureRepository
{
    public interface ISubFeatureRepository
    {
        Task<List<ResultSubFeatureDto>> GetAllSubFeatureAsync();
    }
}
