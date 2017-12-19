using System;
namespace DocApi.Models
{
    public class CarModel
    {
        public string Name
        {
            get;
            set;
        }
        public string Manufacturer
        {
            get
            {
                if (Name.ToUpper() == "CIVIC")
                    return "Honda";
                if (Name.ToUpper() == "CRUZE")
                    return "Chevrolet";
                return "-";
            }
        }
        public DateTime Date
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}