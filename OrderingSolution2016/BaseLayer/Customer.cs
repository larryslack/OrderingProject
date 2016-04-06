using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLayer
{
    public class Customer
    {
        #region Properties
        public string CustomerID { get;  set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        #endregion

        #region Constructors
        public Customer(string CustomerID)
        {
            this.CustomerID = CustomerID;
        }

        public Customer(string CustomerID, string CompanyName, string Contactname, string ContactTitle, string Address, string City, string Region, string PostalCode, string Country, string Phone, string Fax)
        {
            this.CustomerID = CustomerID;
            this.CompanyName = CompanyName;
            this.ContactTitle = ContactTitle;
            this.Address = Address;
            this.City = City;
            this.Region = Region;
            this.PostalCode = PostalCode;
            this.Country = Country;
            this.Phone = Phone;
            this.Fax = Fax;
            this.ContactName = Contactname;
        }
        #endregion
    }
}
