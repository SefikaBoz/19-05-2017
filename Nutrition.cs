# 19-05-2017


namespace InterFaceReference
{
    interface INutritionType
    {
        void WhatMyNutritionType();
       
    }
     interface ICarnivorous : INutritionType
    {
       
      
    }
     interface IHerbivorous : INutritionType
    {

    }
    interface IAnimals
    {
        string AnimalName { get; set; }
        string AnimalSpecies { get; set; }
    }
}
