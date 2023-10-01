using System;

namespace Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }

        public Contact()
        {

        }

        public Contact(string Name, string LastName, string PhoneNumber, string Company)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Company = Company;
            this.CreateAt = DateTime.Now;
        }

        public void Update(string Name, string LastName, string PhoneNumber, string Company)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Company = Company;
            this.CreateAt = DateTime.Now;
        }
    }
}
