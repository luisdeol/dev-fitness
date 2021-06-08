using AutoMapper;
using DevFitness.API.Core.Entities;
using DevFitness.API.Models.InputModels;
using DevFitness.API.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Profiles
{
    public class MealProfile : Profile
    {
        public MealProfile()
        {
            CreateMap<Meal, MealViewModel>();
            CreateMap<CreateMealInputModel, Meal>();
        }
    }
}
