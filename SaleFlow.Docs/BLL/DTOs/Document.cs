using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class Document
    {
        //header
        public string Id { get; set; }
        public DocumentTypeEnum Type { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public string CustomerId { get; set; }
        public List<Item> items { get; set; }
        public int TotalUnits { get; set; }
        public float TotalPrice { get; set; }
        public string Currency { get; set; }

        //log
        public Guid version { get; set; }

    }
    public class Item
    {
        public  string Id { get; set; }
        public  string Code { get; set; }
        public string Description { get; set; }
        public  float Price { get; set; }
        public int Units { get; set; }

    }

    public enum DocumentTypeEnum : int
    {
        Quote = 0,
        SalesOrder = 1,
        Proforma = 2,
    }
}
