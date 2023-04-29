namespace HotelRatesFilterAPI.Model
{

    public class HotelRatesData
    {
        public Hotel Hotel { get; set; }
        public List<HotelRates> HotelRates { get; set; }

        public HotelRatesData() {
            this.Hotel = new Hotel();
            HotelRates = new List<HotelRates>();
        }

    }
    public class Hotel
    {
       public long hotelID { get; set; }
       public int classification { get; set; }

       public string name { get; set; }

       public decimal reviewScore { get; set; }
    }

    public class HotelRates
    {
        public int adults { get; set; }
        public int los { get; set; }
        public DateTime TargetDay { get; set;}
        public string rateDescription { get; set; }

        public int rateID { get; set; }

        public string rateName { get; set; }    

        public Price Price { get; set; } 

        public List<RateTag> RateTags { get; set; }
    }

    public class Price
    {
        public string Currency { get; set;}
        public decimal NumericFloat { get; set; }

        public int NumericInteger { get; set; }
    }

    public class RateTag
    {
        public string Name { get; set; }
        public bool Shape { get; set; }
    }
}
