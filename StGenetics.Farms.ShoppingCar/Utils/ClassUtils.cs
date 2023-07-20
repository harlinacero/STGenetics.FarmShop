using System.Reflection;

namespace StGenetics.Farms.ShoppingCar.Utils
{
    
    public static class ClassUtils
    {
        public const string CURRENCY_FORMAT = "en-US";

        public class GridColumn<TItem>
        {
            public string PropertyName { get; set; }
            public string DisplayName { get; set; }
            public Func<TItem, object> GetValue { get; set; }
        }
    }

    public interface ISelectable
    {
        bool IsSelected { get; set; }
    }
}
