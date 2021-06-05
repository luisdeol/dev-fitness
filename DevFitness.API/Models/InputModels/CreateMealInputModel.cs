using System;

namespace DevFitness.API.Models.InputModels
{
    public class CreateMealInputModel
    {
        public string Description { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
    }
}
