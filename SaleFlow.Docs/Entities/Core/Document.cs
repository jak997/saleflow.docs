using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Core
{
    public abstract class Document : BaseUniqueIdentifiedEntity
    {
        //header
        public required DocumentTypeEnum Type { get; set; }
        public required string Number { get; set; }
        public required string Description { get; set; }
        public required string CustomerId { get; set; }
        public required List<Item> items { get; set; }
        public required int TotalUnits { get; set; }
        public required float TotalPrice { get; set; }
        public required string Currency { get; set; }

        //log
        public required DateTime CreatedDateTime { get; set; }
        public required string CreatedByUserId { get; set; }

        public Guid version;

    }
    public abstract class Item : BaseUniqueIdentifiedEntity
    {
        public required string Code { get; set; }
        public string Description { get; set; }
        public required float Price { get; set; }
        public required int Units { get; set; }

    }

    public enum DocumentTypeEnum : int
    {
        Quote = 0,
        SalesOrder = 1,
        Invoice = 2,
    }
}
