using StGenetics.Farms.ShoppingCar.Models;
using StGenetics.Farms.ShoppingCar.Services.Contracts;

namespace StGenetics.Farms.ShoppingCar.Services.Implements
{
    public class AnimalService : IService<Animal>
    {
        private readonly List<Animal> _animals;
        private int _totalAnimals = 20;
        public AnimalService()
        {
            _animals = new List<Animal>();
        }
        /// <summary>
        /// Remove a animal of collection
        /// </summary>
        /// <param name="id"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Delete(int id)
        {
            var index = _animals.FindIndex(a => a.Id == id);
            if(index != -1)
            {
                _animals.RemoveAt(index);
            }
        }

        /// <summary>
        /// Get Animal of collection
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Animal Get(int id)
        {
            var animal = _animals.FirstOrDefault(a => a.Id == id);
            return animal;
        }

        /// <summary>
        /// Get all animals of collection
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<Animal>? GetAll()
        {
            if (_animals == null || _animals.Count <= 0)
            {
                for (int i = 1; i <= _totalAnimals; i++)
                {
                    Animal animal = BuildAnimal(i);

                    _animals?.Add(animal);
                }
            }

            return _animals;
        }

        private static Animal BuildAnimal(int i)
        {
            string name = i % 2 == 0 ? $"Cow {i}" : $"Bull {i}";
            Gender gender = i % 2 == 0 ? Gender.Female : Gender.Male;
            string bred = i % 2 == 0 ? "Bred A" : "Bred B";
            Animal animal = new()
            {
                Id = i,
                Name = name,
                Gender = gender,
                Bred = bred,
                BirthDate = DateTime.Now.AddDays(-365 * i),
                Price = 1000 * i,
                Status = Status.Active
            };
            return animal;
        }

        /// <summary>
        /// insert or update a annimal into colecction
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Animal Save(Animal entity)
        {
            var index = _animals.FindIndex(a => a.Id == entity.Id);
            if (index != -1)
            {
                _animals[index] = entity;
            } else
            {
                _totalAnimals++;
                entity.Id = _totalAnimals;
                _animals.Add(entity);
            }

            return entity;
        }
    }
}
