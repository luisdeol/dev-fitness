using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Core.Entities
{
    public class Meal : BaseEntity
    {
        protected Meal()
        {

        }
        public Meal(string description, int calories, DateTime date, int userId) : base()
        {
            Description = description;
            Calories = calories;
            Date = date;
            UserId = userId;
        }

        public string Description { get; private set; }
        public int Calories { get; private set; }
        public DateTime Date { get; private set; }

        public int UserId { get; private set; }

        public void Update(string description, int calories, DateTime date)
        {
            Description = description;
            Calories = calories;
            Date = date;
        }
    }
}
