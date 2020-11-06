using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Week8Project.Core.Entities;
using System.Collections;

namespace Week8Project.Core.Exceptions.Repositories
{
    public interface IProductRepository 
    {
        public IEnumerable getProduct(Guid Product);
    }
}
