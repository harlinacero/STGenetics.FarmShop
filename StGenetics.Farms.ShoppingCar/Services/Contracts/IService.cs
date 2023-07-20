namespace StGenetics.Farms.ShoppingCar.Services.Contracts
{
    public interface IService<T> where T : class
    {
        /// <summary>
        /// Get one element of Collection by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(int id);
        /// <summary>
        /// Get All elements of collection
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Insert or update a element in a collection
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Save(T entity);
        /// <summary>
        /// Remove a element of collecion by id
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
