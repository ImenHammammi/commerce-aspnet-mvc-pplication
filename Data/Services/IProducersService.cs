

using commerceApplication.Data.Base;
using commerceApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static commerceApplication.Data.Base.IEntityBaseRepository;

namespace commerceApplication.Data.Services
{
    public interface IProducersService : IEntityBaseRepository<Producer>
    {
    }
}
