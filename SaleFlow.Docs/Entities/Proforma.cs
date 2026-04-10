using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Proforma : Entities.Core.Document
    {
        public Proforma()
        {
            Type = Core.DocumentTypeEnum.Proforma;
            Status = ProformaStatusEnum.Draft;
        }

        public required string BillingAddress { get; set; }
        public required string ParentQuoteId { get; set; }
        public required ProformaStatusEnum Status { get; set; }
    }

    public enum ProformaStatusEnum : int
    {
        Draft = 0,
        Sent = 1,
        Paid = 2
    }
}
