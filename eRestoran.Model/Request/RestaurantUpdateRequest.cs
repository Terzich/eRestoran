using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRestoran.Model.Request
{
    public class RestaurantUpdateRequest
    {
        [Required]

        public string RestaurantName { get; set; }
        [Required]

        public string Address { get; set; }
        [Required]

        public DateTime? OpenAt { get; set; }
        [Required]

        public DateTime? CloseAt { get; set; }
        

        public int? NumberOfTables { get; set; }
        [Required]

        public int CityId { get; set; }
        public byte[] Image { get; set; }

    }
}
