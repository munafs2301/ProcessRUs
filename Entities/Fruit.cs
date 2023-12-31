﻿using ProcessRUs.Helpers;
using System.ComponentModel.DataAnnotations;

namespace ProcessRUs.Entities
{
    public class Fruit
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public FruitType Type { get; set; }

    }
}
