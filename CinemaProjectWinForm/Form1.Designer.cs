namespace CinemaProjectWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelAd = new Label();
            textAd = new TextBox();
            panel1 = new Panel();
            textSoyad = new TextBox();
            labelSoyad = new Label();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            labelYas = new Label();
            panel3 = new Panel();
            ımageList1 = new ImageList(components);
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textFilmName = new TextBox();
            textFilmCategory = new TextBox();
            textTime = new TextBox();
            textPrice = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            listView1 = new ListView();
            Ad = new ColumnHeader();
            Soyad = new ColumnHeader();
            Film = new ColumnHeader();
            Fiyat = new ColumnHeader();
            KoltukNo = new ColumnHeader();
            comboBox2 = new ComboBox();
            panel4 = new Panel();
            buttonCikar = new Button();
            buttonEkle = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelAd.Location = new Point(18, 24);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(28, 20);
            labelAd.TabIndex = 0;
            labelAd.Text = "Ad";
            // 
            // textAd
            // 
            textAd.BackColor = SystemColors.WindowFrame;
            textAd.ForeColor = SystemColors.Window;
            textAd.Location = new Point(75, 21);
            textAd.Name = "textAd";
            textAd.Size = new Size(137, 23);
            textAd.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(18, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 8);
            panel1.TabIndex = 2;
            // 
            // textSoyad
            // 
            textSoyad.BackColor = SystemColors.WindowFrame;
            textSoyad.ForeColor = SystemColors.Window;
            textSoyad.Location = new Point(75, 66);
            textSoyad.Name = "textSoyad";
            textSoyad.Size = new Size(137, 23);
            textSoyad.TabIndex = 3;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelSoyad.Location = new Point(17, 69);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(51, 20);
            labelSoyad.TabIndex = 4;
            labelSoyad.Text = "Soyad";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(17, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 8);
            panel2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.WindowFrame;
            comboBox1.ForeColor = SystemColors.Menu;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1-13", "18+" });
            comboBox1.Location = new Point(75, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 23);
            comboBox1.TabIndex = 6;
            // 
            // labelYas
            // 
            labelYas.AutoSize = true;
            labelYas.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelYas.Location = new Point(18, 112);
            labelYas.Name = "labelYas";
            labelYas.Size = new Size(31, 20);
            labelYas.TabIndex = 7;
            labelYas.Text = "Yas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Location = new Point(17, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(195, 8);
            panel3.TabIndex = 8;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "1.jpg");
            ımageList1.Images.SetKeyName(1, "2.jpg");
            ımageList1.Images.SetKeyName(2, "3.jpg");
            ımageList1.Images.SetKeyName(3, "4.jpg");
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Orange;
            listBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.ForeColor = SystemColors.InfoText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 16;
            listBox1.Items.AddRange(new object[] { "John Wick 4" });
            listBox1.Location = new Point(18, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(141, 164);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(207, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(labelAd);
            groupBox1.Controls.Add(textAd);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(textSoyad);
            groupBox1.Controls.Add(labelYas);
            groupBox1.Controls.Add(labelSoyad);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 168);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kişi Bİlgileri";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(21, 5);
            label1.Name = "label1";
            label1.Size = new Size(123, 18);
            label1.TabIndex = 12;
            label1.Text = "Vizyondaki Fİlmler";
            // 
            // textFilmName
            // 
            textFilmName.Location = new Point(217, 211);
            textFilmName.Name = "textFilmName";
            textFilmName.Size = new Size(159, 23);
            textFilmName.TabIndex = 14;
            textFilmName.TextChanged += textFilmName_TextChanged;
            // 
            // textFilmCategory
            // 
            textFilmCategory.Location = new Point(217, 240);
            textFilmCategory.Name = "textFilmCategory";
            textFilmCategory.Size = new Size(159, 23);
            textFilmCategory.TabIndex = 16;
            // 
            // textTime
            // 
            textTime.Location = new Point(217, 269);
            textTime.Name = "textTime";
            textTime.Size = new Size(159, 23);
            textTime.TabIndex = 17;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(217, 297);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(159, 23);
            textPrice.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(150, 210);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 9;
            label4.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(150, 243);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 19;
            label2.Text = "Tür";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(150, 272);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 20;
            label3.Text = "Süre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(150, 298);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 21;
            label5.Text = "Fiyat";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Ad, Soyad, Film, Fiyat, KoltukNo });
            listView1.LargeImageList = ımageList1;
            listView1.Location = new Point(21, 335);
            listView1.Name = "listView1";
            listView1.Size = new Size(376, 93);
            listView1.SmallImageList = ımageList1;
            listView1.TabIndex = 22;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Ad
            // 
            Ad.Text = "Ad";
            Ad.Width = 80;
            // 
            // Soyad
            // 
            Soyad.Text = "Soyad";
            Soyad.Width = 80;
            // 
            // Film
            // 
            Film.Text = "Film";
            Film.Width = 90;
            // 
            // Fiyat
            // 
            Fiyat.Text = "Fiyat";
            Fiyat.Width = 40;
            // 
            // KoltukNo
            // 
            KoltukNo.Text = "Koltuk No";
            KoltukNo.Width = 80;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(21, 217);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(111, 23);
            comboBox2.TabIndex = 23;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.MouseMove += comboBox2_MouseMove;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientActiveCaption;
            panel4.Controls.Add(buttonCikar);
            panel4.Controls.Add(buttonEkle);
            panel4.Controls.Add(listBox1);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(listView1);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(textFilmName);
            panel4.Controls.Add(textFilmCategory);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(textTime);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textPrice);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(329, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(423, 443);
            panel4.TabIndex = 24;
            // 
            // buttonCikar
            // 
            buttonCikar.BackColor = Color.Orange;
            buttonCikar.Location = new Point(21, 292);
            buttonCikar.Name = "buttonCikar";
            buttonCikar.Size = new Size(75, 23);
            buttonCikar.TabIndex = 26;
            buttonCikar.Text = "Çıkar";
            buttonCikar.UseVisualStyleBackColor = false;
            // 
            // buttonEkle
            // 
            buttonEkle.BackColor = Color.Orange;
            buttonEkle.Location = new Point(21, 263);
            buttonEkle.Name = "buttonEkle";
            buttonEkle.Size = new Size(75, 23);
            buttonEkle.TabIndex = 25;
            buttonEkle.Text = "Ekle";
            buttonEkle.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(21, 190);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 24;
            label6.Text = "Koltuk Seç";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(771, 482);
            Controls.Add(panel4);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelAd;
        private TextBox textAd;
        private Panel panel1;
        private TextBox textSoyad;
        private Label labelSoyad;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label labelYas;
        private Panel panel3;
        private ImageList ımageList1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textFilmName;
        private TextBox textFilmCategory;
        private TextBox textTime;
        private TextBox textPrice;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private ListView listView1;
        private ColumnHeader Ad;
        private ColumnHeader Soyad;
        private ColumnHeader Film;
        private ColumnHeader Fiyat;
        private ComboBox comboBox2;
        private ColumnHeader KoltukNo;
        private Panel panel4;
        private Label label6;
        private Button buttonCikar;
        private Button buttonEkle;
    }
}