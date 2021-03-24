using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrafficUpdateService.SubscriptionHandling.Models
{
    public class Subscription
    {
        private DateTime _createdAt;

        [Key]
        public string Identifier { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        
        public DateTime CreatedAt { 
            get { return _createdAt; } 
            set { _createdAt = DateTime.Now; }
        }

    }
}
