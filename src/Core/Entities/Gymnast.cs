using System;
using System.Collections.Generic;

namespace GymnasticsScoringSystem.Core.Entities
{
    public class Gymnast
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public IList<EventResult> EventResults { get; set; }
    }
}