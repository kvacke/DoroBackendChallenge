using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using TrafficUpdateService.SubscriptionHandling.Models;


namespace TrafficUpdateService.SubscriptionHandling.Validators
{
    public class SubscriptionValidator : AbstractValidator<Subscription>
    {
        public SubscriptionValidator()
        {
            RuleFor(subscription => subscription.Longitude).NotEmpty();
            RuleFor(subscription => subscription.Latitude).NotEmpty();
            RuleFor(subscription => subscription.Identifier).NotEmpty();
        }

    }
}
