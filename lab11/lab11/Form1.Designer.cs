namespace lab11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxsurname = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.labeladres = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.comboBoxAdres = new System.Windows.Forms.ComboBox();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.textBoxphone = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.experience5_9 = new System.Windows.Forms.RadioButton();
            this.experience1 = new System.Windows.Forms.RadioButton();
            this.experience10 = new System.Windows.Forms.RadioButton();
            this.experience1_5 = new System.Windows.Forms.RadioButton();
            this.experience0 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CategoryD = new System.Windows.Forms.CheckBox();
            this.CategoryC = new System.Windows.Forms.CheckBox();
            this.CategoryB = new System.Windows.Forms.CheckBox();
            this.CategoryA = new System.Windows.Forms.CheckBox();
            this.labelDriverCAtegory = new System.Windows.Forms.Label();
            this.checkBoxDriverLic = new System.Windows.Forms.CheckBox();
            this.checkBoxCar = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxMaxZP = new System.Windows.Forms.ListBox();
            this.listBoxMinzp = new System.Windows.Forms.ListBox();
            this.labelmaxzp = new System.Windows.Forms.Label();
            this.labelminzp = new System.Windows.Forms.Label();
            this.labelCV = new System.Windows.Forms.Label();
            this.CV = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.ForeColor = System.Drawing.Color.Black;
            this.labelSurname.Location = new System.Drawing.Point(12, 9);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(93, 22);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(55, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 22);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя:";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastname.ForeColor = System.Drawing.Color.Black;
            this.labelLastname.Location = new System.Drawing.Point(9, 72);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(94, 22);
            this.labelLastname.TabIndex = 2;
            this.labelLastname.Text = "Отчество:";
            // 
            // textBoxsurname
            // 
            this.textBoxsurname.Location = new System.Drawing.Point(112, 13);
            this.textBoxsurname.Name = "textBoxsurname";
            this.textBoxsurname.Size = new System.Drawing.Size(261, 22);
            this.textBoxsurname.TabIndex = 3;
            this.textBoxsurname.TextChanged += new System.EventHandler(this.textBoxsurname_TextChanged);
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(111, 43);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(261, 22);
            this.textBoxname.TabIndex = 4;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBoxname_TextChanged);
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Location = new System.Drawing.Point(111, 74);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(261, 22);
            this.textBoxlastname.TabIndex = 5;
            this.textBoxlastname.TextChanged += new System.EventHandler(this.textBoxlastname_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(421, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.ForeColor = System.Drawing.Color.Black;
            this.female.Location = new System.Drawing.Point(7, 56);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(102, 24);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "Женский";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.ForeColor = System.Drawing.Color.Black;
            this.male.Location = new System.Drawing.Point(7, 26);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(102, 24);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Мужской";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.birthday);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(13, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 83);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дата рождения";
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(7, 35);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(200, 26);
            this.birthday.TabIndex = 0;
            this.birthday.ValueChanged += new System.EventHandler(this.birthday_ValueChanged);
            // 
            // labeladres
            // 
            this.labeladres.AutoSize = true;
            this.labeladres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeladres.ForeColor = System.Drawing.Color.Black;
            this.labeladres.Location = new System.Drawing.Point(75, 211);
            this.labeladres.Name = "labeladres";
            this.labeladres.Size = new System.Drawing.Size(175, 22);
            this.labeladres.TabIndex = 8;
            this.labeladres.Text = "Место проживания:";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelemail.ForeColor = System.Drawing.Color.Black;
            this.labelemail.Location = new System.Drawing.Point(16, 242);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(234, 22);
            this.labelemail.TabIndex = 9;
            this.labelemail.Text = "Адрес электронной почты:";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelphone.ForeColor = System.Drawing.Color.Black;
            this.labelphone.Location = new System.Drawing.Point(62, 276);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(188, 22);
            this.labelphone.TabIndex = 10;
            this.labelphone.Text = "Мобильный телефон:";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxemail.Location = new System.Drawing.Point(269, 244);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(339, 26);
            this.textBoxemail.TabIndex = 11;
            this.textBoxemail.TextChanged += new System.EventHandler(this.textBoxemail_TextChanged);
            // 
            // comboBoxAdres
            // 
            this.comboBoxAdres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAdres.FormattingEnabled = true;
            this.comboBoxAdres.Items.AddRange(new object[] {
            "Брестская область",
            "Витебская область",
            "Гомельская область",
            "Гродненская область",
            "Минская область",
            "Могилёвская область"});
            this.comboBoxAdres.Location = new System.Drawing.Point(269, 208);
            this.comboBoxAdres.Name = "comboBoxAdres";
            this.comboBoxAdres.Size = new System.Drawing.Size(339, 24);
            this.comboBoxAdres.TabIndex = 12;
            this.comboBoxAdres.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdres_SelectedIndexChanged);
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "МТС",
            "А1",
            "Life"});
            this.comboBoxOperator.Location = new System.Drawing.Point(269, 278);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(57, 24);
            this.comboBoxOperator.TabIndex = 13;
            this.comboBoxOperator.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperator_SelectedIndexChanged);
            // 
            // textBoxphone
            // 
            this.textBoxphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxphone.Location = new System.Drawing.Point(347, 276);
            this.textBoxphone.Name = "textBoxphone";
            this.textBoxphone.Size = new System.Drawing.Size(261, 26);
            this.textBoxphone.TabIndex = 14;
            this.textBoxphone.TextChanged += new System.EventHandler(this.textBoxphone_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.experience5_9);
            this.groupBox3.Controls.Add(this.experience1);
            this.groupBox3.Controls.Add(this.experience10);
            this.groupBox3.Controls.Add(this.experience1_5);
            this.groupBox3.Controls.Add(this.experience0);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(16, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Опыт работы";
            // 
            // experience5_9
            // 
            this.experience5_9.AutoSize = true;
            this.experience5_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.experience5_9.ForeColor = System.Drawing.Color.Black;
            this.experience5_9.Location = new System.Drawing.Point(253, 55);
            this.experience5_9.Name = "experience5_9";
            this.experience5_9.Size = new System.Drawing.Size(143, 24);
            this.experience5_9.TabIndex = 5;
            this.experience5_9.TabStop = true;
            this.experience5_9.Text = "От 5 лет до 9";
            this.experience5_9.UseVisualStyleBackColor = true;
            this.experience5_9.CheckedChanged += new System.EventHandler(this.experience5_9_CheckedChanged);
            // 
            // experience1
            // 
            this.experience1.AutoSize = true;
            this.experience1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.experience1.ForeColor = System.Drawing.Color.Black;
            this.experience1.Location = new System.Drawing.Point(6, 55);
            this.experience1.Name = "experience1";
            this.experience1.Size = new System.Drawing.Size(143, 24);
            this.experience1.TabIndex = 4;
            this.experience1.TabStop = true;
            this.experience1.Text = "Менее 1 года";
            this.experience1.UseVisualStyleBackColor = true;
            this.experience1.CheckedChanged += new System.EventHandler(this.experience1_CheckedChanged);
            // 
            // experience10
            // 
            this.experience10.AutoSize = true;
            this.experience10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.experience10.ForeColor = System.Drawing.Color.Black;
            this.experience10.Location = new System.Drawing.Point(460, 25);
            this.experience10.Name = "experience10";
            this.experience10.Size = new System.Drawing.Size(140, 24);
            this.experience10.TabIndex = 3;
            this.experience10.TabStop = true;
            this.experience10.Text = "Более 10 лет";
            this.experience10.UseVisualStyleBackColor = true;
            this.experience10.CheckedChanged += new System.EventHandler(this.experience10_CheckedChanged);
            // 
            // experience1_5
            // 
            this.experience1_5.AutoSize = true;
            this.experience1_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.experience1_5.ForeColor = System.Drawing.Color.Black;
            this.experience1_5.Location = new System.Drawing.Point(253, 25);
            this.experience1_5.Name = "experience1_5";
            this.experience1_5.Size = new System.Drawing.Size(153, 24);
            this.experience1_5.TabIndex = 2;
            this.experience1_5.TabStop = true;
            this.experience1_5.Text = "От 1 года до 5";
            this.experience1_5.UseVisualStyleBackColor = true;
            this.experience1_5.CheckedChanged += new System.EventHandler(this.experience1_5_CheckedChanged);
            // 
            // experience0
            // 
            this.experience0.AutoSize = true;
            this.experience0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.experience0.ForeColor = System.Drawing.Color.Black;
            this.experience0.Location = new System.Drawing.Point(6, 25);
            this.experience0.Name = "experience0";
            this.experience0.Size = new System.Drawing.Size(197, 24);
            this.experience0.TabIndex = 1;
            this.experience0.TabStop = true;
            this.experience0.Text = "Прежде не работал";
            this.experience0.UseVisualStyleBackColor = true;
            this.experience0.CheckedChanged += new System.EventHandler(this.experience0_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CategoryD);
            this.groupBox4.Controls.Add(this.CategoryC);
            this.groupBox4.Controls.Add(this.CategoryB);
            this.groupBox4.Controls.Add(this.CategoryA);
            this.groupBox4.Controls.Add(this.labelDriverCAtegory);
            this.groupBox4.Controls.Add(this.checkBoxDriverLic);
            this.groupBox4.Controls.Add(this.checkBoxCar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(16, 459);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(336, 124);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Другие сведения";
            // 
            // CategoryD
            // 
            this.CategoryD.AutoSize = true;
            this.CategoryD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryD.ForeColor = System.Drawing.Color.Black;
            this.CategoryD.Location = new System.Drawing.Point(140, 100);
            this.CategoryD.Name = "CategoryD";
            this.CategoryD.Size = new System.Drawing.Size(39, 20);
            this.CategoryD.TabIndex = 6;
            this.CategoryD.Text = "D";
            this.CategoryD.UseVisualStyleBackColor = true;
            this.CategoryD.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // CategoryC
            // 
            this.CategoryC.AutoSize = true;
            this.CategoryC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryC.ForeColor = System.Drawing.Color.Black;
            this.CategoryC.Location = new System.Drawing.Point(96, 100);
            this.CategoryC.Name = "CategoryC";
            this.CategoryC.Size = new System.Drawing.Size(38, 20);
            this.CategoryC.TabIndex = 5;
            this.CategoryC.Text = "C";
            this.CategoryC.UseVisualStyleBackColor = true;
            this.CategoryC.CheckedChanged += new System.EventHandler(this.CategoryC_CheckedChanged);
            // 
            // CategoryB
            // 
            this.CategoryB.AutoSize = true;
            this.CategoryB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryB.ForeColor = System.Drawing.Color.Black;
            this.CategoryB.Location = new System.Drawing.Point(52, 100);
            this.CategoryB.Name = "CategoryB";
            this.CategoryB.Size = new System.Drawing.Size(38, 20);
            this.CategoryB.TabIndex = 4;
            this.CategoryB.Text = "B";
            this.CategoryB.UseVisualStyleBackColor = true;
            this.CategoryB.CheckedChanged += new System.EventHandler(this.CategoryB_CheckedChanged);
            // 
            // CategoryA
            // 
            this.CategoryA.AutoSize = true;
            this.CategoryA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CategoryA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryA.ForeColor = System.Drawing.Color.Black;
            this.CategoryA.Location = new System.Drawing.Point(6, 100);
            this.CategoryA.Name = "CategoryA";
            this.CategoryA.Size = new System.Drawing.Size(38, 20);
            this.CategoryA.TabIndex = 3;
            this.CategoryA.Text = "А";
            this.CategoryA.UseVisualStyleBackColor = true;
            this.CategoryA.CheckedChanged += new System.EventHandler(this.CategoryA_CheckedChanged);
            // 
            // labelDriverCAtegory
            // 
            this.labelDriverCAtegory.AutoSize = true;
            this.labelDriverCAtegory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDriverCAtegory.ForeColor = System.Drawing.Color.Black;
            this.labelDriverCAtegory.Location = new System.Drawing.Point(6, 79);
            this.labelDriverCAtegory.Name = "labelDriverCAtegory";
            this.labelDriverCAtegory.Size = new System.Drawing.Size(116, 18);
            this.labelDriverCAtegory.TabIndex = 2;
            this.labelDriverCAtegory.Text = "Категория прав";
            // 
            // checkBoxDriverLic
            // 
            this.checkBoxDriverLic.AutoSize = true;
            this.checkBoxDriverLic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxDriverLic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxDriverLic.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDriverLic.Location = new System.Drawing.Point(7, 54);
            this.checkBoxDriverLic.Name = "checkBoxDriverLic";
            this.checkBoxDriverLic.Size = new System.Drawing.Size(240, 22);
            this.checkBoxDriverLic.TabIndex = 1;
            this.checkBoxDriverLic.Text = "Водительское удостоверение";
            this.checkBoxDriverLic.UseVisualStyleBackColor = true;
            this.checkBoxDriverLic.CheckedChanged += new System.EventHandler(this.checkBoxDriverLic_CheckedChanged);
            // 
            // checkBoxCar
            // 
            this.checkBoxCar.AutoSize = true;
            this.checkBoxCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCar.ForeColor = System.Drawing.Color.Black;
            this.checkBoxCar.Location = new System.Drawing.Point(7, 26);
            this.checkBoxCar.Name = "checkBoxCar";
            this.checkBoxCar.Size = new System.Drawing.Size(126, 22);
            this.checkBoxCar.TabIndex = 0;
            this.checkBoxCar.Text = "Наличие авто";
            this.checkBoxCar.UseVisualStyleBackColor = true;
            this.checkBoxCar.CheckedChanged += new System.EventHandler(this.checkBoxCar_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBoxMaxZP);
            this.groupBox5.Controls.Add(this.listBoxMinzp);
            this.groupBox5.Controls.Add(this.labelmaxzp);
            this.groupBox5.Controls.Add(this.labelminzp);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Location = new System.Drawing.Point(413, 459);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 100);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Объём заработной платы";
            // 
            // listBoxMaxZP
            // 
            this.listBoxMaxZP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxMaxZP.FormattingEnabled = true;
            this.listBoxMaxZP.ItemHeight = 20;
            this.listBoxMaxZP.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1200",
            "1400",
            "1600",
            "1800",
            "2000",
            "2200",
            "2400",
            "2600",
            "2800",
            "3000",
            "3200",
            "3400",
            "3600",
            "3800",
            "4000",
            "4200",
            "4400",
            "4600",
            "4800",
            "5000",
            "5200",
            "5400",
            "5600",
            "5800",
            "6000",
            "6200",
            "6400",
            "6600",
            "6800",
            "7000"});
            this.listBoxMaxZP.Location = new System.Drawing.Point(188, 40);
            this.listBoxMaxZP.Name = "listBoxMaxZP";
            this.listBoxMaxZP.Size = new System.Drawing.Size(82, 24);
            this.listBoxMaxZP.TabIndex = 21;
            this.listBoxMaxZP.SelectedIndexChanged += new System.EventHandler(this.listBoxMaxZP_SelectedIndexChanged);
            // 
            // listBoxMinzp
            // 
            this.listBoxMinzp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxMinzp.FormattingEnabled = true;
            this.listBoxMinzp.ItemHeight = 20;
            this.listBoxMinzp.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "1200",
            "1400",
            "1600",
            "1800",
            "2000",
            "2200",
            "2400",
            "2600",
            "2800",
            "3000",
            "3200",
            "3400",
            "3600",
            "3800",
            "4000"});
            this.listBoxMinzp.Location = new System.Drawing.Point(55, 40);
            this.listBoxMinzp.Name = "listBoxMinzp";
            this.listBoxMinzp.Size = new System.Drawing.Size(82, 24);
            this.listBoxMinzp.TabIndex = 20;
            this.listBoxMinzp.SelectedIndexChanged += new System.EventHandler(this.listBoxMinzp_SelectedIndexChanged);
            // 
            // labelmaxzp
            // 
            this.labelmaxzp.AutoSize = true;
            this.labelmaxzp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelmaxzp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelmaxzp.ForeColor = System.Drawing.Color.Black;
            this.labelmaxzp.Location = new System.Drawing.Point(143, 40);
            this.labelmaxzp.Name = "labelmaxzp";
            this.labelmaxzp.Size = new System.Drawing.Size(39, 22);
            this.labelmaxzp.TabIndex = 19;
            this.labelmaxzp.Text = "До:";
            // 
            // labelminzp
            // 
            this.labelminzp.AutoSize = true;
            this.labelminzp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelminzp.ForeColor = System.Drawing.Color.Black;
            this.labelminzp.Location = new System.Drawing.Point(11, 40);
            this.labelminzp.Name = "labelminzp";
            this.labelminzp.Size = new System.Drawing.Size(37, 22);
            this.labelminzp.TabIndex = 18;
            this.labelminzp.Text = "От:";
            // 
            // labelCV
            // 
            this.labelCV.AutoSize = true;
            this.labelCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCV.ForeColor = System.Drawing.Color.Black;
            this.labelCV.Location = new System.Drawing.Point(18, 602);
            this.labelCV.Name = "labelCV";
            this.labelCV.Size = new System.Drawing.Size(154, 22);
            this.labelCV.TabIndex = 18;
            this.labelCV.Text = "Краткое резюме:";
            // 
            // CV
            // 
            this.CV.Location = new System.Drawing.Point(20, 636);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(710, 117);
            this.CV.TabIndex = 19;
            this.CV.Text = "";
            this.CV.TextChanged += new System.EventHandler(this.CV_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Green;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(282, 768);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(170, 35);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Сохранить данные";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(476, 768);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(145, 35);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Очистить форму";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(627, 768);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(775, 803);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.CV);
            this.Controls.Add(this.labelCV);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxphone);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.comboBoxAdres);
            this.Controls.Add(this.textBoxemail);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labeladres);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxsurname);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "Form1";
            this.Text = "Анкетные Данные Струдника";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxsurname;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.Label labeladres;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.ComboBox comboBoxAdres;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.TextBox textBoxphone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton experience5_9;
        private System.Windows.Forms.RadioButton experience1;
        private System.Windows.Forms.RadioButton experience10;
        private System.Windows.Forms.RadioButton experience1_5;
        private System.Windows.Forms.RadioButton experience0;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox CategoryD;
        private System.Windows.Forms.CheckBox CategoryC;
        private System.Windows.Forms.CheckBox CategoryB;
        private System.Windows.Forms.CheckBox CategoryA;
        private System.Windows.Forms.Label labelDriverCAtegory;
        private System.Windows.Forms.CheckBox checkBoxDriverLic;
        private System.Windows.Forms.CheckBox checkBoxCar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBoxMaxZP;
        private System.Windows.Forms.ListBox listBoxMinzp;
        private System.Windows.Forms.Label labelmaxzp;
        private System.Windows.Forms.Label labelminzp;
        private System.Windows.Forms.Label labelCV;
        private System.Windows.Forms.RichTextBox CV;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button1;
    }
}

