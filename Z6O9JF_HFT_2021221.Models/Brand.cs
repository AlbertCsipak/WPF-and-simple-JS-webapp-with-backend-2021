﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Z6O9JF_HFT_2021221.Models
{
    public class Brand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        [NotMapped]
        public virtual ICollection<Car> Cars { get; set; }

        [NotMapped]
        public virtual ICollection<Engine> Engines { get; set; }
        public override string ToString()
        {
            string name = "-";
            if (Name != null)
            {
                name = Name;
            }
            string location = "-";
            if (Location != null)
            {
                location = Location;
            }
            return $"BrandId: {BrandId}\tName: {name}\t\tLocation: {location}\t";

        }

        public Brand()
        {
            Cars = new HashSet<Car>();
            Engines = new HashSet<Engine>();
        }
    }
}
