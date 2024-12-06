using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparisApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pizza p = new Pizza();
        CreateOrder cOrder = new CreateOrder();
        Random rnd = new Random();
        double sonuc;
        private void btnCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbPizzaSize.Text) || string.IsNullOrEmpty(cmbCorner.Text) ||
                    string.IsNullOrEmpty(cmbDesserts.Text) || string.IsNullOrEmpty(cmbDesserts.Text))
                {
                    MessageBox.Show("Lütfen geçerli bir seçim yapınız.");
                }
                else
                {
                    p.PizzaSize = cmbPizzaSize.Text;
                    p.PizzaCorner = cmbCorner.Text;
                    cOrder.SelectedDrink = cmbDrinks.Text;
                    cOrder.SelectedDessert = cmbDesserts.Text;
                }                
                p.SelectTomato = chckTomato.Checked;
                p.SelectThyme = chckThyme.Checked;
                p.SelectMushroom = chckMushroom.Checked;
                p.SelectOnion = chckOnion.Checked;
                p.SelectCheese = chckCheese.Checked;
                int siparisNo = rnd.Next(99999);
                double maxCartLimit = 300;

                sonuc = p.SelectPizzaSize()
                    + p.SelectPizzaCorner()
                    + p.SelectPizzaSpecs()
                    + cOrder.CreateOrderInDrink()
                    + cOrder.CreateOrderInDesserts();

                if (sonuc >= maxCartLimit)
                {
                    MessageBox.Show
                       ("Siparişiniz Başarı İle Oluşturuldu.\n" +
                       "Pizza Boyutu : " + cmbPizzaSize.Text + " (+" + p.SelectPizzaSize() + "₺)" + "\n" +
                       "Kenar ve Hamur : " + cmbCorner.Text + " (+" + p.SelectPizzaCorner() + "₺)" + "\n" +
                       "Ekstra Seçim Tutarı : " + "(+" + p.SelectPizzaSpecs() + "₺)" + "\n" +
                       "Tatlı Seçimi : " + cmbDesserts.Text + " (+" + cOrder.CreateOrderInDesserts() + "₺)" + "\n" +
                       "İçecek Seçimi : " + cmbDrinks.Text + " (+" + cOrder.CreateOrderInDrink() + "₺)" + "\n" +


                       "\nToplam Sipariş Tutarı : " + sonuc + "₺" +
                       "\nBizi tercih ettiğiniz için teşekkür ederiz...\n" + "Sipariş No : " + "#" + siparisNo
                       );
                }
                else
                {
                    MessageBox.Show("Min. sipariş tutarı 300₺ olmalıdır.");
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCartClear_Click(object sender, EventArgs e)
        {
            cmbDesserts.SelectedIndex = -1;
            cmbDrinks.SelectedIndex = -1;
            cmbPizzaSize.SelectedIndex = -1;
            cmbCorner.SelectedIndex = -1;
            chckMushroom.Checked = false;
            chckOnion.Checked = false;
            chckThyme.Checked = false;
            chckTomato.Checked = false;
        }
    }
}
