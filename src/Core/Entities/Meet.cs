using System;
using System.Collections;
using System.Collections.Generic;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;

namespace GymnasticsScoringSystem.Core.Entities
{
    public class Meet
    {
        public string Id { get; set; } 
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IList<Gymnast> Gymnasts { get; set; }
    }
}