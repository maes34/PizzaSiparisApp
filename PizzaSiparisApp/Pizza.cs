using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparisApp
{
    public class Pizza : IPizza
    {

        public string PizzaSize { get; set; }
        public string PizzaCorner { get; set; }
        public bool SelectTomato { get; set; }
        public bool SelectThyme { get; set; }
        public bool SelectMushroom { get; set; }
        public bool SelectOnion { get; set; }
        public bool SelectCheese { get; set; }

        public double SelectPizzaCorner()
        {
            if (string.IsNullOrEmpty(PizzaCorner))
            {
                return 0;
            }
             double pizzaCornerPrice = 0;
            switch (PizzaCorner)
            {
                case "İnce Kenar":
                    pizzaCornerPrice = 10;
                    break; ;
                case "Normal Kenar":
                    pizzaCornerPrice = 20;
                    break;
                case "Kalın Kenar":
                    pizzaCornerPrice = 45;
                    break;
                case "Dublex Cheddar":
                    pizzaCornerPrice = 65;
                    break;
                case "Dublex Mozzarella":
                    pizzaCornerPrice = 95;
                    break;
            }
            return pizzaCornerPrice;
        }

        public double SelectPizzaSize()
        {
            double pizzaSizePrice = 0;

            if (string.IsNullOrEmpty(PizzaSize))
            {
                return 0;
            }

            switch (PizzaSize)
            {
                case "Küçük":
                    pizzaSizePrice = 190;
                    break; ;
                case "Orta":
                    pizzaSizePrice = 230;
                    break;
                case "Büyük":
                    pizzaSizePrice = 275;
                    break;
            }
            return pizzaSizePrice;
        }
        public double SelectPizzaSpecs()
        {
            double extraSelect = 0;
            extraSelect += SelectCheese ? 10 : 0;
            extraSelect += SelectMushroom ? 10 : 0;
            extraSelect += SelectOnion ? 10 : 0;
            extraSelect += SelectThyme ? 10 : 0;
            extraSelect += SelectTomato ? 10 : 0;

            return extraSelect;
        }
    }
}
