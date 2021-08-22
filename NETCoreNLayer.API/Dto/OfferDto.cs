using System;

namespace NETCoreNLayer.API.Dto
{
    public class OfferDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string ColorCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Owner { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerTCKN { get; set; }
        public string OwnerPhone { get; set; }
        public string Price { get; set; }
        public string Amount { get; set; }
    }
}
