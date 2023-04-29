using HotelRatesFilterAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Net.Mail;
using System.IO;

namespace HotelRatesFilterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelRatesFilterController : ControllerBase
    {

        [HttpGet]
        public HotelRatesData GetHotels(int hotelId, string arrivalDate)
        {
            string json = System.IO.File.ReadAllText("data/hotelrates.json");
            List<HotelRatesData> lstHotelData = JsonConvert.DeserializeObject<List<HotelRatesData>>(json);
            HotelRatesData hotelData =  new HotelRatesData();
            if (lstHotelData != null)
            {
                var hotelDataFiltered = lstHotelData.Where(r => r.Hotel.hotelID == hotelId).FirstOrDefault();
                if (hotelDataFiltered != null)
                {
                    DateTime arrivalDay = new DateTime();

                    bool conversionSuccess = DateTime.TryParse(arrivalDate, out arrivalDay);
                    if (conversionSuccess)
                    {
                        hotelData = hotelDataFiltered;
                        hotelData.HotelRates = hotelDataFiltered.HotelRates.Where(rate => rate.TargetDay == arrivalDay).ToList();
                    }
                }
            }
            
            return hotelData;
        }
    }
}
