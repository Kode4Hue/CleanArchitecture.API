
namespace CleanArchitecture.Application.PetrolPrices.DTOs
{
    public class PetrolPriceDto
    {
        public string Id { get; set; }
        public OutletDto Outlet { get; set; }
        public string SurveyDate { get; set; }
        public string Town { get; set; }
        public string Parish { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
