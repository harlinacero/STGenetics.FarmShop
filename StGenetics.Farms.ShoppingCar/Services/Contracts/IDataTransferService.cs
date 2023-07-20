namespace StGenetics.Farms.ShoppingCar.Services.Contracts
{
    public interface IDataTransferService<T> where T : class
    {
        List<T> DataList { get; set; }
    }
}
