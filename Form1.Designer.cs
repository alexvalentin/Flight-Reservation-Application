
namespace Mini_aplicatie
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.calendarZbor = new System.Windows.Forms.MonthCalendar();
            this.spreCalendar = new System.Windows.Forms.Button();
            this.spreCalculator = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonZbor = new System.Windows.Forms.Button();
            this.clasaZbor = new System.Windows.Forms.GroupBox();
            this.lowCost = new System.Windows.Forms.RadioButton();
            this.businessClass = new System.Windows.Forms.RadioButton();
            this.clasaI = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxAvion = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonHome1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textdeAfisat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonHome2 = new System.Windows.Forms.Button();
            this.alegeData = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.clasaZbor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvion)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1175, 630);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.calendarZbor);
            this.tabPage1.Controls.Add(this.spreCalendar);
            this.tabPage1.Controls.Add(this.spreCalculator);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.buttonExit);
            this.tabPage1.Controls.Add(this.buttonZbor);
            this.tabPage1.Controls.Add(this.clasaZbor);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pictureBoxAvion);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1167, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bilete avion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(854, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pick a date";
            // 
            // calendarZbor
            // 
            this.calendarZbor.Location = new System.Drawing.Point(854, 88);
            this.calendarZbor.Name = "calendarZbor";
            this.calendarZbor.TabIndex = 11;
            this.calendarZbor.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarZbor_DateChanged);
            // 
            // spreCalendar
            // 
            this.spreCalendar.Location = new System.Drawing.Point(231, 497);
            this.spreCalendar.Name = "spreCalendar";
            this.spreCalendar.Size = new System.Drawing.Size(135, 45);
            this.spreCalendar.TabIndex = 10;
            this.spreCalendar.Text = "Spre Calendar";
            this.spreCalendar.UseVisualStyleBackColor = true;
            this.spreCalendar.Click += new System.EventHandler(this.spreCalendar_Click);
            // 
            // spreCalculator
            // 
            this.spreCalculator.Location = new System.Drawing.Point(43, 497);
            this.spreCalculator.Name = "spreCalculator";
            this.spreCalculator.Size = new System.Drawing.Size(136, 45);
            this.spreCalculator.TabIndex = 9;
            this.spreCalculator.Text = "Spre Calculator";
            this.spreCalculator.UseVisualStyleBackColor = true;
            this.spreCalculator.Click += new System.EventHandler(this.spreCalculator_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(517, 328);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(329, 24);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Do you agree with our terms and conditions?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Tomato;
            this.buttonExit.Location = new System.Drawing.Point(510, 434);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(185, 39);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonZbor
            // 
            this.buttonZbor.BackColor = System.Drawing.Color.IndianRed;
            this.buttonZbor.Location = new System.Drawing.Point(510, 370);
            this.buttonZbor.Name = "buttonZbor";
            this.buttonZbor.Size = new System.Drawing.Size(185, 39);
            this.buttonZbor.TabIndex = 6;
            this.buttonZbor.Text = "Click";
            this.buttonZbor.UseVisualStyleBackColor = false;
            this.buttonZbor.Click += new System.EventHandler(this.buttonZbor_Click);
            // 
            // clasaZbor
            // 
            this.clasaZbor.Controls.Add(this.lowCost);
            this.clasaZbor.Controls.Add(this.businessClass);
            this.clasaZbor.Controls.Add(this.clasaI);
            this.clasaZbor.Location = new System.Drawing.Point(510, 99);
            this.clasaZbor.Name = "clasaZbor";
            this.clasaZbor.Size = new System.Drawing.Size(185, 207);
            this.clasaZbor.TabIndex = 5;
            this.clasaZbor.TabStop = false;
            this.clasaZbor.Text = "Flight class";
            this.clasaZbor.Enter += new System.EventHandler(this.clasaZbor_Enter);
            // 
            // lowCost
            // 
            this.lowCost.AutoSize = true;
            this.lowCost.Location = new System.Drawing.Point(35, 140);
            this.lowCost.Name = "lowCost";
            this.lowCost.Size = new System.Drawing.Size(90, 24);
            this.lowCost.TabIndex = 2;
            this.lowCost.TabStop = true;
            this.lowCost.Text = "Low Cost";
            this.lowCost.UseVisualStyleBackColor = true;
            this.lowCost.CheckedChanged += new System.EventHandler(this.lowCost_CheckedChanged);
            // 
            // businessClass
            // 
            this.businessClass.AutoSize = true;
            this.businessClass.Location = new System.Drawing.Point(35, 92);
            this.businessClass.Name = "businessClass";
            this.businessClass.Size = new System.Drawing.Size(122, 24);
            this.businessClass.TabIndex = 1;
            this.businessClass.TabStop = true;
            this.businessClass.Text = "Business Class";
            this.businessClass.UseVisualStyleBackColor = true;
            this.businessClass.CheckedChanged += new System.EventHandler(this.clasaII_CheckedChanged);
            // 
            // clasaI
            // 
            this.clasaI.AutoSize = true;
            this.clasaI.Location = new System.Drawing.Point(35, 40);
            this.clasaI.Name = "clasaI";
            this.clasaI.Size = new System.Drawing.Size(110, 24);
            this.clasaI.TabIndex = 0;
            this.clasaI.TabStop = true;
            this.clasaI.Text = "First class (I)";
            this.clasaI.UseVisualStyleBackColor = true;
            this.clasaI.CheckedChanged += new System.EventHandler(this.clasaI_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Flight options";
            // 
            // pictureBoxAvion
            // 
            this.pictureBoxAvion.Location = new System.Drawing.Point(17, 99);
            this.pictureBoxAvion.Name = "pictureBoxAvion";
            this.pictureBoxAvion.Size = new System.Drawing.Size(431, 335);
            this.pictureBoxAvion.TabIndex = 3;
            this.pictureBoxAvion.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(43, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose airplane company";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonHome1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.textdeAfisat);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1167, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculator Zile";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonHome1
            // 
            this.buttonHome1.Location = new System.Drawing.Point(574, 353);
            this.buttonHome1.Name = "buttonHome1";
            this.buttonHome1.Size = new System.Drawing.Size(148, 39);
            this.buttonHome1.TabIndex = 7;
            this.buttonHome1.Text = "Return Home Menu";
            this.buttonHome1.UseVisualStyleBackColor = true;
            this.buttonHome1.Click += new System.EventHandler(this.buttonHome1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data pana la care ajungem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de la care pornim";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(313, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 192);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textdeAfisat
            // 
            this.textdeAfisat.AutoSize = true;
            this.textdeAfisat.Location = new System.Drawing.Point(293, 423);
            this.textdeAfisat.Name = "textdeAfisat";
            this.textdeAfisat.Size = new System.Drawing.Size(219, 20);
            this.textdeAfisat.TabIndex = 3;
            this.textdeAfisat.Text = "Apasa Calculate si voi functiona";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(508, 288);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 288);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonHome2);
            this.tabPage3.Controls.Add(this.alegeData);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1167, 597);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Calendar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonHome2
            // 
            this.buttonHome2.Location = new System.Drawing.Point(168, 425);
            this.buttonHome2.Name = "buttonHome2";
            this.buttonHome2.Size = new System.Drawing.Size(107, 41);
            this.buttonHome2.TabIndex = 6;
            this.buttonHome2.Text = "Return Home";
            this.buttonHome2.UseVisualStyleBackColor = true;
            this.buttonHome2.Click += new System.EventHandler(this.buttonHome2_Click);
            // 
            // alegeData
            // 
            this.alegeData.Location = new System.Drawing.Point(168, 340);
            this.alegeData.Name = "alegeData";
            this.alegeData.Size = new System.Drawing.Size(111, 42);
            this.alegeData.TabIndex = 5;
            this.alegeData.Text = "Alege data";
            this.alegeData.UseVisualStyleBackColor = true;
            this.alegeData.Click += new System.EventHandler(this.alegeData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(62, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 207);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data initiala de selectat din calendar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(322, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(393, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 268);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(66, 32);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 714);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Flight reservation application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.clasaZbor.ResumeLayout(false);
            this.clasaZbor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textdeAfisat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBoxAvion;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonZbor;
        private System.Windows.Forms.GroupBox clasaZbor;
        private System.Windows.Forms.RadioButton lowCost;
        private System.Windows.Forms.RadioButton businessClass;
        private System.Windows.Forms.RadioButton clasaI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button alegeData;
        private System.Windows.Forms.Button spreCalculator;
        private System.Windows.Forms.Button spreCalendar;
        private System.Windows.Forms.Button buttonHome1;
        private System.Windows.Forms.Button buttonHome2;
        private System.Windows.Forms.MonthCalendar calendarZbor;
        private System.Windows.Forms.Label label6;
    }
}

