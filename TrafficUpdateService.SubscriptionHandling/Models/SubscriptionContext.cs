using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrafficUpdateService.SubscriptionHandling.Models;

namespace TrafficUpdateService.SubscriptionHandling.Models
{
    public class SubscriptionContext : DbContext
    {
        public SubscriptionContext(DbContextOptions<SubscriptionContext> options) : base(options)
        {

        }

        public DbSet<Subscription> Subscriptions;

        public DbSet<TrafficUpdateService.SubscriptionHandling.Models.Subscription> Subscription { get; set; }
    }
}
