using StGenetics.Farms.ShoppingCar.Models;
using StGenetics.Farms.ShoppingCar.Services.Contracts;

namespace StGenetics.Farms.ShoppingCar.Services.Implements
{
    public class AnimalShoppingTransferService : IDataTransferService<Animal>
    {
        public List<Animal> DataList { get; set; } = new List<Animal>();
    }
}
