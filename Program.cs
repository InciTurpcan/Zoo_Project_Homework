using Zoo_Project_Homework.Business;
using Zoo_Project_Homework.Data;
using Zoo_Project_Homework.Models;



IAnimalService animalService = new AnimalService(new AnimalRespository());
Console.WriteLine("Id ye göre getirme:");
animalService.GetById(5 );