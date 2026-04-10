using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Core
{
    public abstract class ConnectedBaseService<TRepository>
    {
        internal TRepository _repository;
        protected ConnectedBaseService(TRepository repository)
        {
            _repository = repository;
        }
    }
}
