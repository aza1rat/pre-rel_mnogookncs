﻿using Mnogookno.Окны;
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
    public partial class ModMenu : Form
    {
        public List<Pizza> menusModMenu;
        public List<int> orderedModMenu;
        public bool alarm = false;

        public ModMenu()
        {
            InitializeComponent();
        }

        private void ExitButMod_Click(object sender, EventArgs e)
        {
            alarm = true;
            this.Close();
        }

        private void EditMenuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexItem = Convert.ToInt32(EditMenuList.SelectedIndex.ToString());
            if (indexItem != -1)
            {
                NamePizza.Text = menusModMenu[indexItem].Name;
                CostPizza.Text = menusModMenu[indexItem].Price.ToString();
                DeskPizza.Text = menusModMenu[indexItem].Description;
                ChangeImage image = new ChangeImage();
                EditImgMenu = image.CImage(menusModMenu[indexItem].Image, EditImgMenu);
            }
            
        }

        private void SavenExit_Click(object sender, EventArgs e)
        {
            int indexItem = Convert.ToInt32(EditMenuList.SelectedIndex.ToString());
            if (indexItem != -1)
            {
                menusModMenu[indexItem].Name = NamePizza.Text;
                menusModMenu[indexItem].Description = DeskPizza.Text;
                menusModMenu[indexItem].Price = Convert.ToDouble(CostPizza.Text);
                this.Close();
            }
                
        }

        private void CostPizza_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
