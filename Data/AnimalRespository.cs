

using Zoo_Project_Homework.Models;

namespace Zoo_Project_Homework.Data;

public class AnimalRespository : IAnimalRepository
{
    private readonly List<Animal> _animals;
    public AnimalRespository()
    {
        _animals = new List<Animal>()
        { 
           new Animal() {ID=1,AnimalName="Pej",Age=3,Gender='M',Type="Kedi",ZookeeperID=4},
           new Animal() {ID=2,AnimalName="Luci",Age=2,Gender='F',Type="Kedi",ZookeeperID=2},
           new Animal() {ID=3,AnimalName="Nasa",Age=1,Gender='M',Type="Köpek",ZookeeperID=2},
           new Animal() {ID=4,AnimalName="Suşi",Age=2,Gender='F',Type="Köpek",ZookeeperID=3},
           new Animal() {ID=5,AnimalName="Zeus",Age=3,Gender='M',Type="Köpek",ZookeeperID=1},
           new Animal() {ID=6,AnimalName="Lili",Age=1,Gender='F',Type="Kedi",ZookeeperID=2},
           new Animal() {ID=7,AnimalName="Mia",Age=2,Gender='F',Type="Kedi",ZookeeperID=1},
           new Animal() {ID=8,AnimalName="Aşil",Age=3,Gender='M',Type="Köpek",ZookeeperID=4},
           new Animal() {ID=9,AnimalName="Zeyna",Age=4,Gender='M',Type="Kedi",ZookeeperID=3},
           new Animal() {ID=10,AnimalName="Leo",Age=1,Gender='M',Type="Köpek",ZookeeperID=4},


        };
    }

    public void Add(Animal animal)
    {
        _animals.Add(animal);
       
    }

    public void Delete(int ID)
    {
        Animal? animal = _animals.SingleOrDefault(x => x.ID == ID);
        if (animal is not null)
        {
            _animals.Remove(animal);
        }
    }

    public List<Animal> GetAll()
    {
        return _animals.ToList();
        
    }

    public Animal GetByID(int ID)
    {
        Animal? animal = _animals.FirstOrDefault(x => x.ID == ID);
        if (animal is not null)
        {
            return animal;
        }
        return null;
    }
}
