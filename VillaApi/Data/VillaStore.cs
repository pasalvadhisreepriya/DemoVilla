using VillaApi.Models.DTO;

namespace VillaApi.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>{
            new VillaDTO{Id=1, Name="abc Villa", Sqft=500,Occupancy=5},
            new VillaDTO{Id=2, Name="def Villa", Sqft=400,Occupancy=6}
           };
    }
}
