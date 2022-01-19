namespace Mnogookno
{
    partial class ModMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModMenu));
            this.EditMenuList = new System.Windows.Forms.ListBox();
            this.ChangeImageBut = new System.Windows.Forms.Button();
            this.AddInMenu = new System.Windows.Forms.Button();
            this.RmvOutMenu = new System.Windows.Forms.Button();
            this.NamePizza = new System.Windows.Forms.TextBox();
            this.CostPizza = new System.Windows.Forms.TextBox();
            this.DeskPizza = new System.Windows.Forms.TextBox();
            this.ExitButMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SavenExit = new System.Windows.Forms.Button();
            this.EditImgMenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditImgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // EditMenuList
            // 
            this.EditMenuList.FormattingEnabled = true;
            this.EditMenuList.ItemHeight = 16;
            this.EditMenuList.Location = new System.Drawing.Point(3, 1);
            this.EditMenuList.Name = "EditMenuList";
            this.EditMenuList.Size = new System.Drawing.Size(260, 260);
            this.EditMenuList.TabIndex = 0;
            this.EditMenuList.SelectedIndexChanged += new System.EventHandler(this.EditMenuList_SelectedIndexChanged);
            // 
            // ChangeImageBut
            // 
            this.ChangeImageBut.Location = new System.Drawing.Point(269, 268);
            this.ChangeImageBut.Name = "ChangeImageBut";
            this.ChangeImageBut.Size = new System.Drawing.Size(260, 64);
            this.ChangeImageBut.TabIndex = 2;
            this.ChangeImageBut.Text = "Изменить";
            this.ChangeImageBut.UseVisualStyleBackColor = true;
            // 
            // AddInMenu
            // 
            this.AddInMenu.Location = new System.Drawing.Point(3, 267);
            this.AddInMenu.Name = "AddInMenu";
            this.AddInMenu.Size = new System.Drawing.Size(122, 64);
            this.AddInMenu.TabIndex = 3;
            this.AddInMenu.Text = "+";
            this.AddInMenu.UseVisualStyleBackColor = true;
            // 
            // RmvOutMenu
            // 
            this.RmvOutMenu.Location = new System.Drawing.Point(131, 268);
            this.RmvOutMenu.Name = "RmvOutMenu";
            this.RmvOutMenu.Size = new System.Drawing.Size(132, 64);
            this.RmvOutMenu.TabIndex = 4;
            this.RmvOutMenu.Text = "-";
            this.RmvOutMenu.UseVisualStyleBackColor = true;
            // 
            // NamePizza
            // 
            this.NamePizza.Location = new System.Drawing.Point(269, 339);
            this.NamePizza.Multiline = true;
            this.NamePizza.Name = "NamePizza";
            this.NamePizza.Size = new System.Drawing.Size(260, 57);
            this.NamePizza.TabIndex = 5;
            // 
            // CostPizza
            // 
            this.CostPizza.Location = new System.Drawing.Point(269, 402);
            this.CostPizza.Multiline = true;
            this.CostPizza.Name = "CostPizza";
            this.CostPizza.Size = new System.Drawing.Size(260, 57);
            this.CostPizza.TabIndex = 6;
            this.CostPizza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostPizza_KeyPress);
            // 
            // DeskPizza
            // 
            this.DeskPizza.Location = new System.Drawing.Point(269, 465);
            this.DeskPizza.Multiline = true;
            this.DeskPizza.Name = "DeskPizza";
            this.DeskPizza.Size = new System.Drawing.Size(260, 136);
            this.DeskPizza.TabIndex = 7;
            // 
            // ExitButMod
            // 
            this.ExitButMod.Location = new System.Drawing.Point(535, 555);
            this.ExitButMod.Name = "ExitButMod";
            this.ExitButMod.Size = new System.Drawing.Size(257, 46);
            this.ExitButMod.TabIndex = 8;
            this.ExitButMod.Text = "Выйти";
            this.ExitButMod.UseVisualStyleBackColor = true;
            this.ExitButMod.Click += new System.EventHandler(this.ExitButMod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(97, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Стоимость:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(97, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Описание:";
            // 
            // SavenExit
            // 
            this.SavenExit.Location = new System.Drawing.Point(535, 500);
            this.SavenExit.Name = "SavenExit";
            this.SavenExit.Size = new System.Drawing.Size(257, 49);
            this.SavenExit.TabIndex = 12;
            this.SavenExit.Text = "Сохранить и Выйти";
            this.SavenExit.UseVisualStyleBackColor = true;
            this.SavenExit.Click += new System.EventHandler(this.SavenExit_Click);
            // 
            // EditImgMenu
            // 
            this.EditImgMenu.Location = new System.Drawing.Point(269, 1);
            this.EditImgMenu.Name = "EditImgMenu";
            this.EditImgMenu.Size = new System.Drawing.Size(260, 260);
            this.EditImgMenu.TabIndex = 1;
            this.EditImgMenu.TabStop = false;
            // 
            // ModMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 603);
            this.Controls.Add(this.SavenExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButMod);
            this.Controls.Add(this.DeskPizza);
            this.Controls.Add(this.CostPizza);
            this.Controls.Add(this.NamePizza);
            this.Controls.Add(this.RmvOutMenu);
            this.Controls.Add(this.AddInMenu);
            this.Controls.Add(this.ChangeImageBut);
            this.Controls.Add(this.EditImgMenu);
            this.Controls.Add(this.EditMenuList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModMenu";
            this.Text = "Оформление заказа";
            ((System.ComponentModel.ISupportInitialize)(this.EditImgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox EditImgMenu;
        private System.Windows.Forms.Button ChangeImageBut;
        private System.Windows.Forms.Button AddInMenu;
        private System.Windows.Forms.Button RmvOutMenu;
        private System.Windows.Forms.TextBox NamePizza;
        private System.Windows.Forms.TextBox CostPizza;
        private System.Windows.Forms.TextBox DeskPizza;
        private System.Windows.Forms.Button ExitButMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SavenExit;
        public System.Windows.Forms.ListBox EditMenuList;
    }
}