using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Entities
{
    public class Quote : Entities.Core.Document
    {
        public Quote()
        {
            Type = Core.DocumentTypeEnum.Quote;
            Status = QuoteStatusEnum.Draft
        };
        public required QuoteStatusEnum Status { get; set; }
    }

    public enum QuoteStatusEnum : int
    {
        Draft = 0,
        Sent = 1,
        Accepted = 2,
        Refused = 3,
    }
}
