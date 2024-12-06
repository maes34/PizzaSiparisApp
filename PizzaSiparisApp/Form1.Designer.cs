namespace PizzaSiparisApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbCorner = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPizzaSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chckTomato = new System.Windows.Forms.CheckBox();
            this.chckThyme = new System.Windows.Forms.CheckBox();
            this.chckMushroom = new System.Windows.Forms.CheckBox();
            this.chckOnion = new System.Windows.Forms.CheckBox();
            this.chckCheese = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDrinks = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbDesserts = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnCartClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCorner
            // 
            this.cmbCorner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCorner.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbCorner.FormattingEnabled = true;
            this.cmbCorner.Items.AddRange(new object[] {
            "İnce Kenar",
            "Normal Kenar",
            "Kalın Kenar",
            "Dublex Cheddar",
            "Dublex Mozzarella"});
            this.cmbCorner.Location = new System.Drawing.Point(185, 302);
            this.cmbCorner.Name = "cmbCorner";
            this.cmbCorner.Size = new System.Drawing.Size(174, 30);
            this.cmbCorner.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hamur Seçimi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pizza Boyutu :";
            // 
            // cmbPizzaSize
            // 
            this.cmbPizzaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizzaSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPizzaSize.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbPizzaSize.FormattingEnabled = true;
            this.cmbPizzaSize.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük"});
            this.cmbPizzaSize.Location = new System.Drawing.Point(185, 266);
            this.cmbPizzaSize.Name = "cmbPizzaSize";
            this.cmbPizzaSize.Size = new System.Drawing.Size(174, 30);
            this.cmbPizzaSize.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Malzeme Seçimi :";
            // 
            // chckTomato
            // 
            this.chckTomato.AutoSize = true;
            this.chckTomato.Location = new System.Drawing.Point(185, 348);
            this.chckTomato.Name = "chckTomato";
            this.chckTomato.Size = new System.Drawing.Size(84, 20);
            this.chckTomato.TabIndex = 5;
            this.chckTomato.Text = "Domates";
            this.chckTomato.UseVisualStyleBackColor = true;
            // 
            // chckThyme
            // 
            this.chckThyme.AutoSize = true;
            this.chckThyme.Location = new System.Drawing.Point(275, 348);
            this.chckThyme.Name = "chckThyme";
            this.chckThyme.Size = new System.Drawing.Size(62, 20);
            this.chckThyme.TabIndex = 6;
            this.chckThyme.Text = "Kekik";
            this.chckThyme.UseVisualStyleBackColor = true;
            // 
            // chckMushroom
            // 
            this.chckMushroom.AutoSize = true;
            this.chckMushroom.Location = new System.Drawing.Point(185, 374);
            this.chckMushroom.Name = "chckMushroom";
            this.chckMushroom.Size = new System.Drawing.Size(70, 20);
            this.chckMushroom.TabIndex = 7;
            this.chckMushroom.Text = "Mantar";
            this.chckMushroom.UseVisualStyleBackColor = true;
            // 
            // chckOnion
            // 
            this.chckOnion.AutoSize = true;
            this.chckOnion.Location = new System.Drawing.Point(275, 374);
            this.chckOnion.Name = "chckOnion";
            this.chckOnion.Size = new System.Drawing.Size(69, 20);
            this.chckOnion.TabIndex = 8;
            this.chckOnion.Text = "Soğan";
            this.chckOnion.UseVisualStyleBackColor = true;
            // 
            // chckCheese
            // 
            this.chckCheese.AutoSize = true;
            this.chckCheese.Location = new System.Drawing.Point(185, 400);
            this.chckCheese.Name = "chckCheese";
            this.chckCheese.Size = new System.Drawing.Size(108, 20);
            this.chckCheese.TabIndex = 9;
            this.chckCheese.Text = "Beyaz Peynir";
            this.chckCheese.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "İçecek Seçimi :";
            // 
            // cmbDrinks
            // 
            this.cmbDrinks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDrinks.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbDrinks.FormattingEnabled = true;
            this.cmbDrinks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbDrinks.Items.AddRange(new object[] {
            "İstemiyorum",
            "Pepsi Zero Sugar 250 ML",
            "Pepsi Twist 250 ML"});
            this.cmbDrinks.Location = new System.Drawing.Point(185, 427);
            this.cmbDrinks.Name = "cmbDrinks";
            this.cmbDrinks.Size = new System.Drawing.Size(174, 30);
            this.cmbDrinks.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cmbDesserts
            // 
            this.cmbDesserts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDesserts.ForeColor = System.Drawing.Color.OrangeRed;
            this.cmbDesserts.FormattingEnabled = true;
            this.cmbDesserts.Items.AddRange(new object[] {
            "İstemiyorum",
            "Tekli Çikolatalı Sufle",
            "Algida Marai Usulü Cup Dondurma",
            "Pastel de Nata"});
            this.cmbDesserts.Location = new System.Drawing.Point(499, 266);
            this.cmbDesserts.Name = "cmbDesserts";
            this.cmbDesserts.Size = new System.Drawing.Size(174, 30);
            this.cmbDesserts.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(380, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tatlı Seçimi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(466, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Minimum sepet tutarı 300₺";
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(499, 334);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(174, 46);
            this.btnCart.TabIndex = 16;
            this.btnCart.Text = "Sipariş Oluştur";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnCartClear
            // 
            this.btnCartClear.Location = new System.Drawing.Point(499, 386);
            this.btnCartClear.Name = "btnCartClear";
            this.btnCartClear.Size = new System.Drawing.Size(174, 34);
            this.btnCartClear.TabIndex = 17;
            this.btnCartClear.Text = "Seçimleri Kaldır";
            this.btnCartClear.UseVisualStyleBackColor = true;
            this.btnCartClear.Click += new System.EventHandler(this.btnCartClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(696, 488);
            this.Controls.Add(this.btnCartClear);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbDesserts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbDrinks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chckCheese);
            this.Controls.Add(this.chckOnion);
            this.Controls.Add(this.chckMushroom);
            this.Controls.Add(this.chckThyme);
            this.Controls.Add(this.chckTomato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbPizzaSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCorner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Sipariş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCorner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPizzaSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chckTomato;
        private System.Windows.Forms.CheckBox chckThyme;
        private System.Windows.Forms.CheckBox chckMushroom;
        private System.Windows.Forms.CheckBox chckOnion;
        private System.Windows.Forms.CheckBox chckCheese;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDrinks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbDesserts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnCartClear;
    }
}

