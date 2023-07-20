using StGenetics.Farms.ShoppingCar.Utils;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StGenetics.Farms.ShoppingCar.Models
{
    public class Animal : ISelectable, INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bred { get; set; }
        public Gender Gender { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime BirthDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Price { get; set; }
        public Status Status { get; set; }
        public bool IsSelected { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    public enum Status
    {
        Active = 0,
        Inactive = 1,
    }
}
