namespace Cafe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.basket = new System.Windows.Forms.Button();
            this.borsch = new System.Windows.Forms.Button();
            this.solyanka = new System.Windows.Forms.Button();
            this.chi = new System.Windows.Forms.Button();
            this.goroh = new System.Windows.Forms.Button();
            this.pure = new System.Windows.Forms.Button();
            this.makaroshki = new System.Windows.Forms.Button();
            this.kapusta = new System.Windows.Forms.Button();
            this.grechka = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.kurKot = new System.Windows.Forms.Button();
            this.otbiv = new System.Windows.Forms.Button();
            this.frik = new System.Windows.Forms.Button();
            this.vegan = new System.Windows.Forms.Button();
            this.sosiska = new System.Windows.Forms.Button();
            this.myasPirog = new System.Windows.Forms.Button();
            this.kapustPirog = new System.Windows.Forms.Button();
            this.hotdog = new System.Windows.Forms.Button();
            this.mors = new System.Windows.Forms.Button();
            this.chai = new System.Windows.Forms.Button();
            this.kofe = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пожалуйста, выберите блюда, а затем перейдите в корзину";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Первые блюда";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вторые блюда";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выпечка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Напитки";
            // 
            // basket
            // 
            this.basket.BackColor = System.Drawing.Color.White;
            this.basket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basket.BackgroundImage")));
            this.basket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.basket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.basket.Location = new System.Drawing.Point(689, 344);
            this.basket.Name = "basket";
            this.basket.Size = new System.Drawing.Size(99, 94);
            this.basket.TabIndex = 5;
            this.basket.UseVisualStyleBackColor = false;
            this.basket.Click += new System.EventHandler(this.basket_Click);
            // 
            // borsch
            // 
            this.borsch.Location = new System.Drawing.Point(37, 94);
            this.borsch.Name = "borsch";
            this.borsch.Size = new System.Drawing.Size(100, 50);
            this.borsch.TabIndex = 6;
            this.borsch.Text = "Борщ - 30р";
            this.borsch.UseVisualStyleBackColor = true;
            this.borsch.Click += new System.EventHandler(this.borsch_Click);
            // 
            // solyanka
            // 
            this.solyanka.Location = new System.Drawing.Point(37, 176);
            this.solyanka.Name = "solyanka";
            this.solyanka.Size = new System.Drawing.Size(100, 50);
            this.solyanka.TabIndex = 7;
            this.solyanka.Text = "Солянка - 45р";
            this.solyanka.UseVisualStyleBackColor = true;
            this.solyanka.Click += new System.EventHandler(this.solyanka_Click);
            // 
            // chi
            // 
            this.chi.Location = new System.Drawing.Point(37, 255);
            this.chi.Name = "chi";
            this.chi.Size = new System.Drawing.Size(100, 50);
            this.chi.TabIndex = 8;
            this.chi.Text = "Щи - 20р";
            this.chi.UseVisualStyleBackColor = true;
            this.chi.Click += new System.EventHandler(this.chi_Click);
            // 
            // goroh
            // 
            this.goroh.Location = new System.Drawing.Point(37, 333);
            this.goroh.Name = "goroh";
            this.goroh.Size = new System.Drawing.Size(100, 50);
            this.goroh.TabIndex = 9;
            this.goroh.Text = "Гороховый -20р";
            this.goroh.UseVisualStyleBackColor = true;
            this.goroh.Click += new System.EventHandler(this.goroh_Click);
            // 
            // pure
            // 
            this.pure.Location = new System.Drawing.Point(170, 94);
            this.pure.Name = "pure";
            this.pure.Size = new System.Drawing.Size(100, 50);
            this.pure.TabIndex = 10;
            this.pure.Text = "Картофельное Пюре - 15р";
            this.pure.UseVisualStyleBackColor = true;
            this.pure.Click += new System.EventHandler(this.pure_Click);
            // 
            // makaroshki
            // 
            this.makaroshki.Location = new System.Drawing.Point(170, 176);
            this.makaroshki.Name = "makaroshki";
            this.makaroshki.Size = new System.Drawing.Size(100, 50);
            this.makaroshki.TabIndex = 11;
            this.makaroshki.Text = "Макароны - 15р";
            this.makaroshki.UseVisualStyleBackColor = true;
            this.makaroshki.Click += new System.EventHandler(this.makaroshki_Click);
            // 
            // kapusta
            // 
            this.kapusta.Location = new System.Drawing.Point(170, 255);
            this.kapusta.Name = "kapusta";
            this.kapusta.Size = new System.Drawing.Size(100, 50);
            this.kapusta.TabIndex = 12;
            this.kapusta.Text = "Капуста - 15р";
            this.kapusta.UseVisualStyleBackColor = true;
            this.kapusta.Click += new System.EventHandler(this.kapusta_Click);
            // 
            // grechka
            // 
            this.grechka.Location = new System.Drawing.Point(170, 333);
            this.grechka.Name = "grechka";
            this.grechka.Size = new System.Drawing.Size(100, 50);
            this.grechka.TabIndex = 13;
            this.grechka.Text = "Гречка - 15р";
            this.grechka.UseVisualStyleBackColor = true;
            this.grechka.Click += new System.EventHandler(this.grechka_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "К гарниру";
            // 
            // kurKot
            // 
            this.kurKot.Location = new System.Drawing.Point(299, 94);
            this.kurKot.Name = "kurKot";
            this.kurKot.Size = new System.Drawing.Size(100, 50);
            this.kurKot.TabIndex = 15;
            this.kurKot.Text = "Котлета из курицы - 30р";
            this.kurKot.UseVisualStyleBackColor = true;
            this.kurKot.Click += new System.EventHandler(this.kurKot_Click);
            // 
            // otbiv
            // 
            this.otbiv.Location = new System.Drawing.Point(299, 176);
            this.otbiv.Name = "otbiv";
            this.otbiv.Size = new System.Drawing.Size(100, 50);
            this.otbiv.TabIndex = 16;
            this.otbiv.Text = "Отбивная из свинины - 45р";
            this.otbiv.UseVisualStyleBackColor = true;
            this.otbiv.Click += new System.EventHandler(this.otbiv_Click);
            // 
            // frik
            // 
            this.frik.Location = new System.Drawing.Point(299, 255);
            this.frik.Name = "frik";
            this.frik.Size = new System.Drawing.Size(100, 50);
            this.frik.TabIndex = 17;
            this.frik.Text = "Фрикадельки - 30р";
            this.frik.UseVisualStyleBackColor = true;
            this.frik.Click += new System.EventHandler(this.frik_Click);
            // 
            // vegan
            // 
            this.vegan.Location = new System.Drawing.Point(299, 333);
            this.vegan.Name = "vegan";
            this.vegan.Size = new System.Drawing.Size(100, 50);
            this.vegan.TabIndex = 18;
            this.vegan.Text = "Вегетарианская котлета - 25р";
            this.vegan.UseVisualStyleBackColor = true;
            this.vegan.Click += new System.EventHandler(this.vegan_Click);
            // 
            // sosiska
            // 
            this.sosiska.Location = new System.Drawing.Point(432, 94);
            this.sosiska.Name = "sosiska";
            this.sosiska.Size = new System.Drawing.Size(100, 50);
            this.sosiska.TabIndex = 19;
            this.sosiska.Text = "Сосиска в тесте - 20р";
            this.sosiska.UseVisualStyleBackColor = true;
            this.sosiska.Click += new System.EventHandler(this.sosiska_Click);
            // 
            // myasPirog
            // 
            this.myasPirog.Location = new System.Drawing.Point(432, 176);
            this.myasPirog.Name = "myasPirog";
            this.myasPirog.Size = new System.Drawing.Size(100, 50);
            this.myasPirog.TabIndex = 20;
            this.myasPirog.Text = "Пирожок с мясом - 25р";
            this.myasPirog.UseVisualStyleBackColor = true;
            this.myasPirog.Click += new System.EventHandler(this.myasPirog_Click);
            // 
            // kapustPirog
            // 
            this.kapustPirog.Location = new System.Drawing.Point(432, 255);
            this.kapustPirog.Name = "kapustPirog";
            this.kapustPirog.Size = new System.Drawing.Size(100, 50);
            this.kapustPirog.TabIndex = 21;
            this.kapustPirog.Text = "Пирожок с капустой - 20р";
            this.kapustPirog.UseVisualStyleBackColor = true;
            this.kapustPirog.Click += new System.EventHandler(this.kapustPirog_Click);
            // 
            // hotdog
            // 
            this.hotdog.Location = new System.Drawing.Point(432, 333);
            this.hotdog.Name = "hotdog";
            this.hotdog.Size = new System.Drawing.Size(100, 50);
            this.hotdog.TabIndex = 22;
            this.hotdog.Text = "Хот-дог - 25р";
            this.hotdog.UseVisualStyleBackColor = true;
            this.hotdog.Click += new System.EventHandler(this.hotdog_Click);
            // 
            // mors
            // 
            this.mors.Location = new System.Drawing.Point(565, 94);
            this.mors.Name = "mors";
            this.mors.Size = new System.Drawing.Size(100, 50);
            this.mors.TabIndex = 23;
            this.mors.Text = "Морс клюквенный - 10р";
            this.mors.UseVisualStyleBackColor = true;
            this.mors.Click += new System.EventHandler(this.mors_Click);
            // 
            // chai
            // 
            this.chai.Location = new System.Drawing.Point(565, 176);
            this.chai.Name = "chai";
            this.chai.Size = new System.Drawing.Size(100, 50);
            this.chai.TabIndex = 24;
            this.chai.Text = "Чай черный - 5р";
            this.chai.UseVisualStyleBackColor = true;
            this.chai.Click += new System.EventHandler(this.chai_Click);
            // 
            // kofe
            // 
            this.kofe.Location = new System.Drawing.Point(565, 333);
            this.kofe.Name = "kofe";
            this.kofe.Size = new System.Drawing.Size(100, 50);
            this.kofe.TabIndex = 25;
            this.kofe.Text = "Кофе - 10р";
            this.kofe.UseVisualStyleBackColor = true;
            this.kofe.Click += new System.EventHandler(this.kofe_Click);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(565, 255);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(100, 50);
            this.green.TabIndex = 26;
            this.green.Text = "Чай зеленый - 5р";
            this.green.UseVisualStyleBackColor = true;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(704, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Корзина";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 462);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.green);
            this.Controls.Add(this.kofe);
            this.Controls.Add(this.chai);
            this.Controls.Add(this.mors);
            this.Controls.Add(this.hotdog);
            this.Controls.Add(this.kapustPirog);
            this.Controls.Add(this.myasPirog);
            this.Controls.Add(this.sosiska);
            this.Controls.Add(this.vegan);
            this.Controls.Add(this.frik);
            this.Controls.Add(this.otbiv);
            this.Controls.Add(this.kurKot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grechka);
            this.Controls.Add(this.kapusta);
            this.Controls.Add(this.makaroshki);
            this.Controls.Add(this.pure);
            this.Controls.Add(this.goroh);
            this.Controls.Add(this.chi);
            this.Controls.Add(this.solyanka);
            this.Controls.Add(this.borsch);
            this.Controls.Add(this.basket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(826, 500);
            this.MinimumSize = new System.Drawing.Size(826, 500);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button basket;
        private System.Windows.Forms.Button borsch;
        private System.Windows.Forms.Button solyanka;
        private System.Windows.Forms.Button chi;
        private System.Windows.Forms.Button goroh;
        private System.Windows.Forms.Button pure;
        private System.Windows.Forms.Button makaroshki;
        private System.Windows.Forms.Button kapusta;
        private System.Windows.Forms.Button grechka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kurKot;
        private System.Windows.Forms.Button otbiv;
        private System.Windows.Forms.Button frik;
        private System.Windows.Forms.Button vegan;
        private System.Windows.Forms.Button sosiska;
        private System.Windows.Forms.Button myasPirog;
        private System.Windows.Forms.Button kapustPirog;
        private System.Windows.Forms.Button hotdog;
        private System.Windows.Forms.Button mors;
        private System.Windows.Forms.Button chai;
        private System.Windows.Forms.Button kofe;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}