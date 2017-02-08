namespace winforms01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboAngle = new System.Windows.Forms.ComboBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnToCart = new System.Windows.Forms.Button();
            this.btnToPolar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoPretty = new System.Windows.Forms.RadioButton();
            this.rdoExact = new System.Windows.Forms.RadioButton();
            this.grid = new System.Windows.Forms.Panel();
            this.plot = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoCart = new System.Windows.Forms.RadioButton();
            this.rdoPolar = new System.Windows.Forms.RadioButton();
            this.gbxConv = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grid.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbxConv.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cartesian";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(32, 56);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(32, 29);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboAngle);
            this.groupBox2.Controls.Add(this.txtR);
            this.groupBox2.Controls.Add(this.txtT);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Polar";
            // 
            // cboAngle
            // 
            this.cboAngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAngle.FormattingEnabled = true;
            this.cboAngle.Items.AddRange(new object[] {
            "rad",
            "deg"});
            this.cboAngle.Location = new System.Drawing.Point(139, 55);
            this.cboAngle.Name = "cboAngle";
            this.cboAngle.Size = new System.Drawing.Size(56, 21);
            this.cboAngle.TabIndex = 6;
            this.cboAngle.SelectionChangeCommitted += new System.EventHandler(this.cboAngle_SelectionChangeCommitted);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(33, 29);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 3;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(33, 56);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 20);
            this.txtT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "R :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "ϴ :";
            // 
            // btnToCart
            // 
            this.btnToCart.Location = new System.Drawing.Point(64, 260);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(75, 23);
            this.btnToCart.TabIndex = 5;
            this.btnToCart.Text = "To Cartesian";
            this.btnToCart.UseVisualStyleBackColor = true;
            this.btnToCart.Click += new System.EventHandler(this.btnToCart_Click);
            // 
            // btnToPolar
            // 
            this.btnToPolar.Location = new System.Drawing.Point(63, 125);
            this.btnToPolar.Name = "btnToPolar";
            this.btnToPolar.Size = new System.Drawing.Size(75, 23);
            this.btnToPolar.TabIndex = 2;
            this.btnToPolar.Text = "To Polar";
            this.btnToPolar.UseVisualStyleBackColor = true;
            this.btnToPolar.Click += new System.EventHandler(this.btnToPolar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.btnToCart);
            this.groupBox3.Controls.Add(this.btnToPolar);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 307);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conversions";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoPretty);
            this.groupBox4.Controls.Add(this.rdoExact);
            this.groupBox4.Location = new System.Drawing.Point(6, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 68);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Numeric Precision";
            // 
            // rdoPretty
            // 
            this.rdoPretty.AutoSize = true;
            this.rdoPretty.Location = new System.Drawing.Point(26, 42);
            this.rdoPretty.Name = "rdoPretty";
            this.rdoPretty.Size = new System.Drawing.Size(52, 17);
            this.rdoPretty.TabIndex = 1;
            this.rdoPretty.Text = "Pretty";
            this.rdoPretty.UseVisualStyleBackColor = true;
            // 
            // rdoExact
            // 
            this.rdoExact.AutoSize = true;
            this.rdoExact.Checked = true;
            this.rdoExact.Location = new System.Drawing.Point(26, 19);
            this.rdoExact.Name = "rdoExact";
            this.rdoExact.Size = new System.Drawing.Size(52, 17);
            this.rdoExact.TabIndex = 0;
            this.rdoExact.TabStop = true;
            this.rdoExact.Text = "Exact";
            this.rdoExact.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.White;
            this.grid.Controls.Add(this.plot);
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(500, 500);
            this.grid.TabIndex = 12;
            this.grid.Paint += new System.Windows.Forms.PaintEventHandler(this.grid_Paint);
            // 
            // plot
            // 
            this.plot.BackColor = System.Drawing.Color.Transparent;
            this.plot.Location = new System.Drawing.Point(0, 0);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(500, 500);
            this.plot.TabIndex = 0;
            this.plot.Paint += new System.Windows.Forms.PaintEventHandler(this.plot_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(653, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoCart);
            this.groupBox5.Controls.Add(this.rdoPolar);
            this.groupBox5.Location = new System.Drawing.Point(518, 431);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(93, 73);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // rdoCart
            // 
            this.rdoCart.AutoSize = true;
            this.rdoCart.Checked = true;
            this.rdoCart.Location = new System.Drawing.Point(9, 19);
            this.rdoCart.Name = "rdoCart";
            this.rdoCart.Size = new System.Drawing.Size(69, 17);
            this.rdoCart.TabIndex = 1;
            this.rdoCart.TabStop = true;
            this.rdoCart.Text = "Cartesian";
            this.rdoCart.UseVisualStyleBackColor = true;
            this.rdoCart.CheckedChanged += new System.EventHandler(this.rdoCart_CheckedChanged);
            // 
            // rdoPolar
            // 
            this.rdoPolar.AutoSize = true;
            this.rdoPolar.Location = new System.Drawing.Point(9, 42);
            this.rdoPolar.Name = "rdoPolar";
            this.rdoPolar.Size = new System.Drawing.Size(49, 17);
            this.rdoPolar.TabIndex = 0;
            this.rdoPolar.Text = "Polar";
            this.rdoPolar.UseVisualStyleBackColor = true;
            this.rdoPolar.CheckedChanged += new System.EventHandler(this.rdoPolar_CheckedChanged);
            // 
            // gbxConv
            // 
            this.gbxConv.Controls.Add(this.groupBox3);
            this.gbxConv.Controls.Add(this.groupBox4);
            this.gbxConv.Location = new System.Drawing.Point(518, 12);
            this.gbxConv.Name = "gbxConv";
            this.gbxConv.Size = new System.Drawing.Size(225, 413);
            this.gbxConv.TabIndex = 22;
            this.gbxConv.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Dots";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "CenterCircle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 518);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "WeirdDots";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 547);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Trippy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(174, 518);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Polka";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 595);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbxConv);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grid.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbxConv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnToCart;
        private System.Windows.Forms.Button btnToPolar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoPretty;
        private System.Windows.Forms.RadioButton rdoExact;
        private System.Windows.Forms.Panel grid;
        private System.Windows.Forms.Panel plot;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoCart;
        private System.Windows.Forms.RadioButton rdoPolar;
        private System.Windows.Forms.ComboBox cboAngle;
        private System.Windows.Forms.GroupBox gbxConv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

