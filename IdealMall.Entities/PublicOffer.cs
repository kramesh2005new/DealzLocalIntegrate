using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations; // Added by Varadha
using DORM;

namespace IdealMall.Entities
{
    [SP("GetOfferProducts_Public")]
    public class PublicOffers
    {
        [RSIndex(1)]
        public List<PublicOffer> Offers { get; set; }
        [RSIndex(2)]
        public int Totalcount { get; set; }
        [RSIndex(3)]
        public List<LocalShop> local { get; set; }
    }
    
    public class PublicOffersFilterCriteria
    {
        public string PostCode { get; set; }
        public double Radius { get; set; }
        public int PageIndex { get; set; }
        public int ShopId { get; set; }
        public string Product { get; set; }
        public int Pagesize { get; set; }
    }
    public class PublicOffer
    {
        public int ID { get; set; }

       
        public LocalShop Shop { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }

        [Display(Name = "OFFER RATE (£)")] // Added by Varadha
        public float OfferRate { get; set; }

        [Display(Name = "Volume")] // Added by Varadha
        public string Volume { get; set; }
        public string PostCode { get; set; }
        public string ImageURL { get; set; }

        [Display(Name = "Offer Rate%")] // Added by Varadha
        public float OfferRatePercent { get; set; }
        [Display(Name = "POR (%)")]
        public float POR { get; set; }

        public string Sell_Price { get; set; }
         public float VAT { get; set; }
        [Display(Name = "ADDITIONAL OFFER")]
        public string Additional_offer { get; set; }
         public string OfferEnddate { get; set; }
         public decimal? Previous_Prize { get; set; }
         public string Shop_Orginal_Name { get; set; }
    }
    [SP("GetOfferProducts_Public")]
    public class LocalShopsOffers
    {
        public string PostCode { get; set; }
        public LocalShopsOffers()
        {
            Offers = new List<PublicOffer>();
            Products = new List<Product>();
            local = new List<LocalShop>();
            AllLocalShops = new List<AllLocalShops>();
        }
         [RSIndex(1)]
        public List<PublicOffer> Offers { get; set; }
         [RSIndex(2)]
         public int Totalcount { get; set; }
         [RSIndex(3)]
         public List<LocalShop> local { get; set; }
        public List<Product> Products { get; set; }
        public List<AllLocalShops> AllLocalShops { get; set; }
        public string PostCodeToDisplayInPublicIndex { get; set; }
        public string UserName { get; set; }
        public int Pages
        {
            get
            {
                return (Totalcount / 10) + ((Totalcount % 10) > 0 ? 1 : 0);
            }
        }
    }
}
