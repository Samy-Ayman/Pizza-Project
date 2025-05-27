namespace Pizza_Project
{
    partial class PizzaOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOptions));
            this.label1 = new System.Windows.Forms.Label();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbcrust = new System.Windows.Forms.GroupBox();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbThik = new System.Windows.Forms.RadioButton();
            this.gbWhere = new System.Windows.Forms.GroupBox();
            this.rbHome = new System.Windows.Forms.RadioButton();
            this.rbResturant = new System.Windows.Forms.RadioButton();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMushroum = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkGreenPapper = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lebel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEat = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblcrust = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbcrust.SuspendLayout();
            this.gbWhere.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make Your Pizza";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.ForeColor = System.Drawing.Color.Lime;
            this.rbLarge.Location = new System.Drawing.Point(12, 124);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(132, 40);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Tag = "50";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.ForeColor = System.Drawing.Color.Lime;
            this.rbMedium.Location = new System.Drawing.Point(12, 77);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(163, 40);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "40";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.ForeColor = System.Drawing.Color.Lime;
            this.rbSmall.Location = new System.Drawing.Point(12, 30);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(127, 40);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "30";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Font = new System.Drawing.Font("Snap ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbSize.Location = new System.Drawing.Point(12, 57);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(255, 179);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // gbcrust
            // 
            this.gbcrust.BackColor = System.Drawing.Color.Transparent;
            this.gbcrust.Controls.Add(this.rbThin);
            this.gbcrust.Controls.Add(this.rbThik);
            this.gbcrust.Font = new System.Drawing.Font("Snap ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbcrust.Location = new System.Drawing.Point(12, 251);
            this.gbcrust.Name = "gbcrust";
            this.gbcrust.Size = new System.Drawing.Size(255, 132);
            this.gbcrust.TabIndex = 5;
            this.gbcrust.TabStop = false;
            this.gbcrust.Text = "Crust Type";
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.ForeColor = System.Drawing.Color.Lime;
            this.rbThin.Location = new System.Drawing.Point(12, 28);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(213, 40);
            this.rbThin.TabIndex = 4;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // rbThik
            // 
            this.rbThik.AutoSize = true;
            this.rbThik.ForeColor = System.Drawing.Color.Lime;
            this.rbThik.Location = new System.Drawing.Point(12, 66);
            this.rbThik.Name = "rbThik";
            this.rbThik.Size = new System.Drawing.Size(218, 40);
            this.rbThik.TabIndex = 5;
            this.rbThik.TabStop = true;
            this.rbThik.Tag = "20";
            this.rbThik.Text = "Thik Trust";
            this.rbThik.UseVisualStyleBackColor = true;
            this.rbThik.CheckedChanged += new System.EventHandler(this.rbThik_CheckedChanged);
            // 
            // gbWhere
            // 
            this.gbWhere.BackColor = System.Drawing.Color.Transparent;
            this.gbWhere.Controls.Add(this.rbHome);
            this.gbWhere.Controls.Add(this.rbResturant);
            this.gbWhere.Font = new System.Drawing.Font("Snap ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbWhere.Location = new System.Drawing.Point(12, 406);
            this.gbWhere.Name = "gbWhere";
            this.gbWhere.Size = new System.Drawing.Size(274, 213);
            this.gbWhere.TabIndex = 6;
            this.gbWhere.TabStop = false;
            this.gbWhere.Text = "Where To Eat";
            // 
            // rbHome
            // 
            this.rbHome.AutoSize = true;
            this.rbHome.ForeColor = System.Drawing.Color.Lime;
            this.rbHome.Location = new System.Drawing.Point(12, 92);
            this.rbHome.Name = "rbHome";
            this.rbHome.Size = new System.Drawing.Size(171, 40);
            this.rbHome.TabIndex = 6;
            this.rbHome.TabStop = true;
            this.rbHome.Tag = "20";
            this.rbHome.Text = "In Home";
            this.rbHome.UseVisualStyleBackColor = true;
            this.rbHome.CheckedChanged += new System.EventHandler(this.rbHome_CheckedChanged);
            // 
            // rbResturant
            // 
            this.rbResturant.AutoSize = true;
            this.rbResturant.ForeColor = System.Drawing.Color.Lime;
            this.rbResturant.Location = new System.Drawing.Point(12, 138);
            this.rbResturant.Name = "rbResturant";
            this.rbResturant.Size = new System.Drawing.Size(254, 40);
            this.rbResturant.TabIndex = 7;
            this.rbResturant.TabStop = true;
            this.rbResturant.Tag = "10";
            this.rbResturant.Text = "in Resturant";
            this.rbResturant.UseVisualStyleBackColor = true;
            this.rbResturant.CheckedChanged += new System.EventHandler(this.rbResturant_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.ForeColor = System.Drawing.Color.Lime;
            this.chkOnion.Location = new System.Drawing.Point(357, 42);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(131, 40);
            this.chkOnion.TabIndex = 11;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkMushroum
            // 
            this.chkMushroum.AutoSize = true;
            this.chkMushroum.ForeColor = System.Drawing.Color.Lime;
            this.chkMushroum.Location = new System.Drawing.Point(6, 173);
            this.chkMushroum.Name = "chkMushroum";
            this.chkMushroum.Size = new System.Drawing.Size(222, 40);
            this.chkMushroum.TabIndex = 10;
            this.chkMushroum.Tag = "5";
            this.chkMushroum.Text = "Mushroums";
            this.chkMushroum.UseVisualStyleBackColor = true;
            this.chkMushroum.CheckedChanged += new System.EventHandler(this.chkMushroum_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.ForeColor = System.Drawing.Color.Lime;
            this.chkTomatoes.Location = new System.Drawing.Point(6, 103);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(193, 40);
            this.chkTomatoes.TabIndex = 9;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.ForeColor = System.Drawing.Color.Lime;
            this.chkCheese.Location = new System.Drawing.Point(6, 47);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(269, 40);
            this.chkCheese.TabIndex = 8;
            this.chkCheese.Tag = "5";
            this.chkCheese.Text = "Extra Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            this.chkCheese.CheckedChanged += new System.EventHandler(this.chkCheese_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.ForeColor = System.Drawing.Color.Lime;
            this.chkOlives.Location = new System.Drawing.Point(343, 98);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(145, 40);
            this.chkOlives.TabIndex = 12;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkGreenPapper
            // 
            this.chkGreenPapper.AutoSize = true;
            this.chkGreenPapper.ForeColor = System.Drawing.Color.Lime;
            this.chkGreenPapper.Location = new System.Drawing.Point(234, 173);
            this.chkGreenPapper.Name = "chkGreenPapper";
            this.chkGreenPapper.Size = new System.Drawing.Size(287, 40);
            this.chkGreenPapper.TabIndex = 13;
            this.chkGreenPapper.Tag = "5";
            this.chkGreenPapper.Text = "Green Peppers";
            this.chkGreenPapper.UseVisualStyleBackColor = true;
            this.chkGreenPapper.CheckedChanged += new System.EventHandler(this.chkGreenPapper_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkCheese);
            this.gbToppings.Controls.Add(this.chkGreenPapper);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMushroum);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbToppings.Location = new System.Drawing.Point(347, 62);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(527, 225);
            this.gbToppings.TabIndex = 13;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Snap ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(889, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 90);
            this.button1.TabIndex = 15;
            this.button1.Text = "Order ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Snap ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1096, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 90);
            this.button2.TabIndex = 16;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Snap ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1275, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 90);
            this.button3.TabIndex = 17;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thin Crust :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toppings :";
            // 
            // lebel
            // 
            this.lebel.AutoSize = true;
            this.lebel.ForeColor = System.Drawing.Color.White;
            this.lebel.Location = new System.Drawing.Point(18, 311);
            this.lebel.Name = "lebel";
            this.lebel.Size = new System.Drawing.Size(344, 40);
            this.lebel.TabIndex = 4;
            this.lebel.Text = "Where To Eat : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Salary :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 40);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(214, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 40);
            this.label8.TabIndex = 7;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSize.Location = new System.Drawing.Point(149, 55);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(168, 40);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "No Size";
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderSummary.Controls.Add(this.label5);
            this.gbOrderSummary.Controls.Add(this.lblSalary);
            this.gbOrderSummary.Controls.Add(this.lblEat);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.lblcrust);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.label8);
            this.gbOrderSummary.Controls.Add(this.label7);
            this.gbOrderSummary.Controls.Add(this.label6);
            this.gbOrderSummary.Controls.Add(this.lebel);
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Font = new System.Drawing.Font("Ravie", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbOrderSummary.Location = new System.Drawing.Point(328, 293);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(886, 495);
            this.gbOrderSummary.TabIndex = 14;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order summary";
            this.gbOrderSummary.Enter += new System.EventHandler(this.gbOrderSummary_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(439, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "$";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.ForeColor = System.Drawing.Color.Lime;
            this.lblSalary.Location = new System.Drawing.Point(355, 393);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(40, 40);
            this.lblSalary.TabIndex = 12;
            this.lblSalary.Tag = "0";
            this.lblSalary.Text = "0";
            // 
            // lblEat
            // 
            this.lblEat.AutoSize = true;
            this.lblEat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblEat.Location = new System.Drawing.Point(372, 311);
            this.lblEat.Name = "lblEat";
            this.lblEat.Size = new System.Drawing.Size(363, 40);
            this.lblEat.TabIndex = 11;
            this.lblEat.Text = "No Where to Eat";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblToppings.Location = new System.Drawing.Point(31, 210);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(262, 40);
            this.lblToppings.TabIndex = 10;
            this.lblToppings.Text = "No Toppings";
            // 
            // lblcrust
            // 
            this.lblcrust.AutoSize = true;
            this.lblcrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblcrust.Location = new System.Drawing.Point(300, 118);
            this.lblcrust.Name = "lblcrust";
            this.lblcrust.Size = new System.Drawing.Size(198, 40);
            this.lblcrust.TabIndex = 9;
            this.lblcrust.Text = "No Crust";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizza_Project.Properties.Resources.Thin_Pizza;
            this.pictureBox1.Location = new System.Drawing.Point(983, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1060, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 41);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(1258, 534);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1252, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 32);
            this.label10.TabIndex = 21;
            this.label10.Text = "label10";
           // this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // PizzaOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1445, 782);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbWhere);
            this.Controls.Add(this.gbcrust);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PizzaOptions";
            this.Text = "Pizza Options";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbcrust.ResumeLayout(false);
            this.gbcrust.PerformLayout();
            this.gbWhere.ResumeLayout(false);
            this.gbWhere.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbcrust;
        private System.Windows.Forms.RadioButton rbThik;
        private System.Windows.Forms.GroupBox gbWhere;
        private System.Windows.Forms.RadioButton rbHome;
        private System.Windows.Forms.RadioButton rbResturant;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMushroum;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkGreenPapper;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lebel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblEat;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblcrust;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label10;
    }
}