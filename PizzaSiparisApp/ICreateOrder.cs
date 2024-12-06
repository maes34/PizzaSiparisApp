using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSiparisApp
{
    public interface ICreateOrder
    {
        double CreateOrderInDrink();
        double CreateOrderInDesserts();
    }
}
