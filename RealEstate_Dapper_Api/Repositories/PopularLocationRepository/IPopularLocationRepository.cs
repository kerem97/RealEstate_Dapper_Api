using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.PopularLocationsDtos;
using RealEstate_Dapper_Api.Dtos.ProductDtos;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepository
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllLocationAsync();
        //void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        //void DeleteBottomGrid(int id);
        //void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);

        //Task<GetBottomGridDto> GetBottomGrid(int id);
    }
}
