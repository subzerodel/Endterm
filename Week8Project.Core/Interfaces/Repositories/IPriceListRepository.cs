using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Week8Project.Core.Interfaces.Repositories
{
    interface  IPriceListRepository
    {
        public Task<bool> AddPriceList(PricelistAdd pricelist);
    }
}
