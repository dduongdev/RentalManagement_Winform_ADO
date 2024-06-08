using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement.Entities
{
    public class Home
    {
        private string _homeId;
        private string _homeOwnerName;
        private double _rentalPrice;
        private bool _isRenting;

        public string HomeId { get => _homeId; set => _homeId = value; }
        public string HomeOwnerName { get => _homeOwnerName; set => _homeOwnerName = value; }
        public double RentalPrice { get => _rentalPrice; set => _rentalPrice = value; }
        public bool IsRenting { get => _isRenting; set => _isRenting = value; }

        public Home() { }

        public Home(string homeId, string homeOwnerName, double rentalPrice, bool isRenting)
        {
            this.HomeId = homeId;
            this.HomeOwnerName = homeOwnerName;
            this.RentalPrice = rentalPrice;
            this.IsRenting = IsRenting;
        }
    }
}
