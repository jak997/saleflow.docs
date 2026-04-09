using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Core
{
    public abstract class EnvironmentBaseService
    {
        protected Configuration _config;
        protected EnvironmentBaseService(Configuration config)
        {
            _config = config;
        }
    }
}
