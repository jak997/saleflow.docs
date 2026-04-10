using BLL.DTO;
using BLL.Repositories;
using BLL.Services.Core;
using Entities;
using System.Collections;
using System.Linq.Expressions;

namespace BLL.Services
{
    public class QuoteService : ConnectedBaseService<IQuoteRepository>, IQuoteService
    {
        public QuoteService(IQuoteRepository repository) : base(repository) { }

        public async Task Create(DTO.Quote quote)
        {
            string invalidReasonText = String.Empty;
            Entities.Quote quoteEntity;

            if (!IsNewQuoteValid(quote, out invalidReasonText))
            {
                throw new Exception(invalidReasonText);
            }

            quoteEntity = GetEntityFromDTO(quote);
            this._repository.Add(quoteEntity);
            await this._repository.SaveChangesAsync();
        }

        public Task Delete(DTO.Quote quote)
        {
            throw new NotImplementedException();
        }

        public Task<DTO.Quote> GetById(string id)
        {
            throw new NotImplementedException(); //todo
        }

        public Task Update(DTO.Quote quote, string version)
        {
            throw new NotImplementedException();
        }

        #region Utils
        public bool IsNewQuoteValid(BLL.DTO.Quote quote, out string invalidReasonText)
        {
            bool retValue = true;
            float calculatedTotal = quote.items.Sum(i => i.Price * i.Units);
            invalidReasonText = "";

            try
            {
                if (quote == null) throw new ArgumentNullException(nameof(quote));

                if ((quote.Type != DocumentTypeEnum.Quote))
                    throw new Exception("Invalid document type.");

                if (string.IsNullOrWhiteSpace(quote.CustomerId))
                    throw new Exception("Empty customerId.");

                if (string.IsNullOrWhiteSpace(quote.Number))
                    throw new Exception("Empty Number.");

                if (string.IsNullOrWhiteSpace(quote.CustomerId))
                    throw new Exception("Empty customerId.");

                if (quote.items == null || !quote.items.Any())
                    throw new Exception("Empty Items.");

                if (quote.items.Any(i => i.Price < 0 || i.Units <= 0))
                    throw new Exception("All items must have price and units greather than zero.");

                //todo

            }
            catch (Exception ex)
            {
                invalidReasonText = ex.Message;
                retValue = false;
            }
            return retValue;
        }

        private Entities.Quote GetEntityFromDTO(BLL.DTO.Quote quote)
        {
            Entities.Quote quoteEntity = new Entities.Quote
            {
                Number = quote.Number,
                Description = quote.Description,
                CustomerId = quote.CustomerId,
                Currency = quote.Currency,
                TotalUnits = quote.items.Sum(i => i.Units),
                TotalPrice = quote.TotalPrice,
                Status = (Entities.QuoteStatusEnum)quote.Status,
                Type = Entities.Core.DocumentTypeEnum.Quote,
                CreatedDateTime = DateTime.UtcNow,
                CreatedByUserId = "", //todo prendere dal token nel controller e passare al service
                items = (from i in quote.items
                         select new Entities.Core.Item
                         {
                             Code = i.Code,
                             Description = i.Description,
                             Price = i.Price,
                             Units = i.Units
                         }).ToList()
            };
            return quoteEntity;
        }

        #endregion
    }
}