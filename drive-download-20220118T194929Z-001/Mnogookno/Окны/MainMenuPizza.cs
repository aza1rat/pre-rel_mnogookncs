using Mnogookno.Окны;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnogookno
{

    public partial class MainMenuPizza : Form
    {
        public double balans;
        public List<Pizza> menus = new List<Pizza>();
        public List<int> ordered = new List<int>();

        public MainMenuPizza()
        {
            InitializeComponent();
        }
        
         void MenuButtons(object sender, EventArgs e)
         {
            Button but=(Button)sender;
            switch (but.Tag)
            {
                case "Zakaz":               
                    MakeOrder makeOrder = new MakeOrder();
                    makeOrder.menusMakeOrder = menus;
                    makeOrder.orderedMakeOrder = ordered;
                    makeOrder.balansMakeOrder = balans;
                    foreach (Pizza pizza in menus)
                    {
                        makeOrder.MenuList.Items.Add(pizza.ToString());
                    }
                    this.Hide();
                    makeOrder.ShowDialog();
                    menus = makeOrder.menusMakeOrder;
                    ordered = makeOrder.orderedMakeOrder;
                    balans = makeOrder.balansMakeOrder;
                    this.Show();
                    break;

                case "Modering":
                    Parol parol = new Parol();
                    parol.menusParol = menus;
                    parol.orderedParol = ordered;
                    this.Hide();
                    parol.ShowDialog();
                    menus = parol.menusParol;
                    ordered = parol.orderedParol;
                    this.Show();
                    break;
                case "PriceList":
                    PriceList priceList = new PriceList();
                    priceList.balansPriceList = balans;
                    priceList.menusPriceList = menus;
                    priceList.orderedPriceList = ordered;
                    foreach (Pizza pizza in menus)
                    {
                        priceList.BuyedList.Items.Add(pizza.ToString());
                    }
                    this.Hide();
                    priceList.ShowDialog();
                    menus = priceList.menusPriceList;
                    ordered = priceList.orderedPriceList;
                    balans = priceList.balansPriceList;
                    this.Show();
                    break;
                case "Exit": this.Close();break;
            }
         }

        private void MainMenuPizza_Load(object sender, EventArgs e)
        {
            
            if (menus.Count == 0)
            {
                Random random = new Random();
                balans = random.Next(2000, 6000);
                menus.Add(new Pizza("Пицца с луком, грибами и травами", 359, "Тонкое тесто и нежнейший соус. Ароматные лесные грибы в сочетании со сладким луком.", "lukgribi"));
                ordered.Add(0);
                menus.Add(new Pizza("Пицца с колбасами,грибами и травами", 489, "Мощный вкус колбас пепперони и нежнейших шампиньонов на толстом тесте не оставит никого голодным!", "kolbasa"));
                ordered.Add(0);
                menus.Add(new Pizza("Пицца с сырным соусом,курицами и грушами", 529, "Тесто из ржаной муки идеально подходит для груш. Фирменный сырный соус и курочка с итальянскими приправами", "grushchick"));
                ordered.Add(0);
                menus.Add(new Pizza("Пицца с сыром", 239, "Настоящий classic. Я бы даже сказал, pleasently", "cheese"));
                ordered.Add(0);
                
            }
        }
    }
}
