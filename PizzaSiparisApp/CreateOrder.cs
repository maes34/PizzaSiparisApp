using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace PizzaSiparisApp
{
    internal class CreateOrder : ICreateOrder
    {
        public string SelectedDrink { get; set; }
        public string SelectedDessert { get; set; }

        public double CreateOrderInDesserts()
        {
            double dessertsMenuPrice;

            if (string.IsNullOrEmpty(SelectedDessert))
            {
                return 0;
            }

            switch (SelectedDessert)
            {
                case "İstemiyorum":
                    dessertsMenuPrice = 0;
                    break;
                default:
                    dessertsMenuPrice = 200;
                    break;  
            }
            return dessertsMenuPrice;
        }

        public double CreateOrderInDrink()
        {
            double drinkMenuPrice;

            if (string.IsNullOrEmpty(SelectedDrink))
            {
                return 0;
            }

            switch (SelectedDrink)
            {
                case "İstemiyorum":
                    drinkMenuPrice = 0;
                        break;
                default:
                    drinkMenuPrice = 75;
                    break;
            }
            return drinkMenuPrice;
        }


        
        
    }
}
