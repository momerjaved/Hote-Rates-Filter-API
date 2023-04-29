using HotelRatesFilterAPI.Controllers;
using NUnit.Framework;
using System.Security.Cryptography;

namespace HotelRatesUnitTest
{
    public class HotelRatesTest
    {
        private HotelRatesFilterController hotelRatescontroller;

        [SetUp]
        public void SetUp()
        {
            hotelRatescontroller = new HotelRatesFilterController();
        }

        [Test]
        public void Check_HotelData_Is_Not_Null([Range(7294, 7296)] int hotelId)
        {
            Assert.IsNotNull(hotelRatescontroller.GetHotels(hotelId, ""));
        }

        [TestCase(7294, "2016-03-15T00:00:00.000+01:00")]
        public void Check_Correct_No_of_Hotel_Rates_Returned(int hotelId, string arrivalDay)
        {
            var hotelRatesData = hotelRatescontroller.GetHotels(hotelId, arrivalDay);
            Assert.IsTrue(hotelRatesData.HotelRates.Count == 26);
        }

        [TestCase(7295, "2023-05-01T00:00:00.000+01:00")]
        public void Check_Correct_No_of_Hotel_Rates_Returned_7295(int hotelId, string arrivalDay)
        {
            var hotelRatesData = hotelRatescontroller.GetHotels(hotelId, arrivalDay);
            Assert.IsTrue(hotelRatesData.HotelRates.Count == 2);
        }

    }
}
