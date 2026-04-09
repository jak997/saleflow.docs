using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Core
{
    public abstract class ConnectedBaseService<TRepository> : EnvironmentBaseService
    {
        internal TRepository _repository;
        protected ConnectedBaseService(Configuration config, TRepository repository) : base(config)
        {
            _repository = repository;
        }
    }
}
