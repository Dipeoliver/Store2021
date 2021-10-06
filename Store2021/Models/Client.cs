using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store2021.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }

        public ICollection<SalesRecord> SalesRecord { get; set; } = new List<SalesRecord>();

        public Client() { }

        public Client(int id, string document, string name, string phone, string address, string number)
        {
            Id = id;
            Document = document;
            Name = name;
            Phone = phone;
            Address = address;
            Number = number;
        }
    }
}
