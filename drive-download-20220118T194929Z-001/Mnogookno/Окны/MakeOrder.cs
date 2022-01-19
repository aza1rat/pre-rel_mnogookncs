using Mnogookno.Окны;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnogookno
{
    public partial class MakeOrder : Form
    {
        public double balansMakeOrder;
        public List<Pizza> menusMakeOrder;
        public List<int> orderedMakeOrder;

        public MakeOrder()
        {
            InitializeComponent();
            
        }
        
        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexItem = Convert.ToInt32(MenuList.SelectedIndex.ToString());
            MainMenuPizza mainMenuPizza = new MainMenuPizza();
            if (indexItem != -1)
            {
                InfoOrder.Text = $"Название: {menusMakeOrder[indexItem].Name}" + Environment.NewLine +
                $"Описание: {menusMakeOrder[indexItem].Description}" + Environment.NewLine +
                $"Стоимость: {menusMakeOrder[indexItem].Price}";
                ChangeImage image = new ChangeImage();
                ImagePizza = image.CImage(menusMakeOrder[indexItem].Image, ImagePizza);
            }
        }

        private void AddOrdButton_Click(object sender, EventArgs e)
        {
            int indexItem = Convert.ToInt32((string)MenuList.SelectedIndex.ToString());
            if (indexItem != -1)
            {
                if (menusMakeOrder[indexItem].Price <= balansMakeOrder)
                {
                    balansMakeOrder -= menusMakeOrder[indexItem].Price;
                    Balance_label.Text = $"Стоимость: {balansMakeOrder}";
                    orderedMakeOrder[indexItem] += 1;
                }
                else
                {
                    Balance_label.Text = $"Недостаточно средств";
                }
            }
            
        }

        private void MakeOrder_Load(object sender, EventArgs e)
        {
            Balance_label.Text = $"Баланс: {balansMakeOrder}";
        }
    }
}
