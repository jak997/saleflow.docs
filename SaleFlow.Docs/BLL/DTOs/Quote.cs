using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class Quote : BLL.DTO.Document
    {
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