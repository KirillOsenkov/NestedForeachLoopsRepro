using System;
using System.Collections.Generic;

namespace NestedForeachLoopsRepro.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Quote{
        public List<Bag> Bags { get; set; } = new List<Bag>();
        public Customer QuoteCustomer { get; set; } = new Customer();
        public int Total => 42;
        public string SalesRep => "Sales rep";
    }

    public class Bag{
        public string DisplayName => "Display Name";
    }

    public class Customer{
        public string CompanyName => "Company name";
        public string FName => "FName";
        public string LName => "LName";
    }
}