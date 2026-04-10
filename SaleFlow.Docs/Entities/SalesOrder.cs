using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class SalesOrder : Entities.Core.Document
    {
        public SalesOrder()
        {
            Type = Core.DocumentTypeEnum.SalesOrder;
            Status = SalesOrderStatusEnum.Draft;
        }

        public required string ShippingAddress { get; set; }
        public required string ParentQuoteId { get; set; }
        public required SalesOrderStatusEnum Status
        {
            get; set;
        }

        public enum SalesOrderStatusEnum : int
        {
            Draft = 0,
            Sent = 1,
            Completed = 2,
        }
    }
}
