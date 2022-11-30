using System.ComponentModel.DataAnnotations;

namespace Pharmacy_App.Models
{
    public class MedicinesViewModel
    {
        public int MedicineId { get; set; } 

        [Required]
        public string MedicineName { get; set; }
        [Required]
        public string MedicineDescription { get; set; }
        public int MedicinePrice { get; set; }
        /*public IFormFile ProductImage { get; set; }
        public string ProductImageUrl { get; set; }*/
        public string? DosageForm { get; set; }
        public string? MinimumOrderQuantity { get; set; }
        public string? MedicineUsage { get; set; }
        public string? MedicineManufacturedBy { get; set; }

    }
}
