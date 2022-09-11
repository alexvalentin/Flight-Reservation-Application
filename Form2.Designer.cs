
namespace Mini_aplicatie
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPlateste = new System.Windows.Forms.Button();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.textBoxDateCard = new System.Windows.Forms.TextBox();
            this.buttonExitPay = new System.Windows.Forms.Button();
            this.errorProviderCVV = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelCvv = new System.Windows.Forms.Label();
            this.labelDataCard = new System.Windows.Forms.Label();
            this.errorProviderDataCard = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDataCard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add serial number of your card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CVV code";
            // 
            // buttonPlateste
            // 
            this.buttonPlateste.Location = new System.Drawing.Point(331, 246);
            this.buttonPlateste.Name = "buttonPlateste";
            this.buttonPlateste.Size = new System.Drawing.Size(119, 42);
            this.buttonPlateste.TabIndex = 2;
            this.buttonPlateste.Text = "Pay";
            this.buttonPlateste.UseVisualStyleBackColor = true;
            this.buttonPlateste.Click += new System.EventHandler(this.buttonPlateste_Click);
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(317, 185);
            this.textBoxCVV.MaxLength = 3;
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(178, 27);
            this.textBoxCVV.TabIndex = 3;
            this.textBoxCVV.TextChanged += new System.EventHandler(this.textBoxCVV_TextChanged);
            this.textBoxCVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCVV_KeyPress);
            // 
            // textBoxDateCard
            // 
            this.textBoxDateCard.Location = new System.Drawing.Point(317, 109);
            this.textBoxDateCard.MaxLength = 19;
            this.textBoxDateCard.Name = "textBoxDateCard";
            this.textBoxDateCard.Size = new System.Drawing.Size(178, 27);
            this.textBoxDateCard.TabIndex = 4;
            this.textBoxDateCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDateCard_KeyPress);
            // 
            // buttonExitPay
            // 
            this.buttonExitPay.Location = new System.Drawing.Point(331, 327);
            this.buttonExitPay.Name = "buttonExitPay";
            this.buttonExitPay.Size = new System.Drawing.Size(119, 35);
            this.buttonExitPay.TabIndex = 5;
            this.buttonExitPay.Text = "Exit";
            this.buttonExitPay.UseVisualStyleBackColor = true;
            this.buttonExitPay.Click += new System.EventHandler(this.buttonExitPay_Click);
            // 
            // errorProviderCVV
            // 
            this.errorProviderCVV.ContainerControl = this;
            // 
            // labelCvv
            // 
            this.labelCvv.AutoSize = true;
            this.labelCvv.Location = new System.Drawing.Point(514, 186);
            this.labelCvv.Name = "labelCvv";
            this.labelCvv.Size = new System.Drawing.Size(0, 20);
            this.labelCvv.TabIndex = 6;
            // 
            // labelDataCard
            // 
            this.labelDataCard.AutoSize = true;
            this.labelDataCard.Location = new System.Drawing.Point(514, 109);
            this.labelDataCard.Name = "labelDataCard";
            this.labelDataCard.Size = new System.Drawing.Size(0, 20);
            this.labelDataCard.TabIndex = 7;
            // 
            // errorProviderDataCard
            // 
            this.errorProviderDataCard.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDataCard);
            this.Controls.Add(this.labelCvv);
            this.Controls.Add(this.buttonExitPay);
            this.Controls.Add(this.textBoxDateCard);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.buttonPlateste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "PayTicketsFlightDemo";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDataCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPlateste;
        public System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.TextBox textBoxDateCard;
        private System.Windows.Forms.Button buttonExitPay;
        private System.Windows.Forms.ErrorProvider errorProviderCVV;
        private System.Windows.Forms.Label labelCvv;
        private System.Windows.Forms.Label labelDataCard;
        private System.Windows.Forms.ErrorProvider errorProviderDataCard;
    }
}