using System;
using System.ComponentModel.DataAnnotations;

namespace ShopBridgeModels
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public float Price { get; set; }

        public string ImageSource { get; set; }
    }
}
