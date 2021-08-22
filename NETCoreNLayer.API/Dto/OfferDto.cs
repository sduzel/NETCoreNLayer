using System;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "Ürün sahibini giriniz!")]
        public string Owner { get; set; }
        public string OwnerAddress { get; set; }
        public string OwnerTCKN { get; set; }
        public string OwnerPhone { get; set; }
        [Required(ErrorMessage = "Fiyat bilgisi giriniz!")]
        public string Price { get; set; }
        [Required(ErrorMessage = "Miktar giriniz!")]
        public string Amount { get; set; }
    }
}
