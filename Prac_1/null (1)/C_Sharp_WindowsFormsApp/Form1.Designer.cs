
namespace C_Sharp_WindowsFormsApp
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
            this.rdNone = new System.Windows.Forms.RadioButton();
            this.rd10 = new System.Windows.Forms.RadioButton();
            this.rd20 = new System.Windows.Forms.RadioButton();
            this.rdHairstyle = new System.Windows.Forms.RadioButton();
            this.rdMOver = new System.Windows.Forms.RadioButton();
            this.rdManicure = new System.Windows.Forms.RadioButton();
            this.rdPermanent = new System.Windows.Forms.RadioButton();
            this.txtCurrentService = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdNone
            // 
            this.rdNone.AutoSize = true;
            this.rdNone.Location = new System.Drawing.Point(6, 25);
            this.rdNone.Name = "rdNone";
            this.rdNone.Size = new System.Drawing.Size(51, 17);
            this.rdNone.TabIndex = 0;
            this.rdNone.TabStop = true;
            this.rdNone.Text = "None";
            this.rdNone.UseVisualStyleBackColor = true;
            // 
            // rd10
            // 
            this.rd10.AutoSize = true;
            this.rd10.Location = new System.Drawing.Point(6, 48);
            this.rd10.Name = "rd10";
            this.rd10.Size = new System.Drawing.Size(45, 17);
            this.rd10.TabIndex = 1;
            this.rd10.TabStop = true;
            this.rd10.Text = "10%";
            this.rd10.UseVisualStyleBackColor = true;
            // 
            // rd20
            // 
            this.rd20.AutoSize = true;
            this.rd20.Location = new System.Drawing.Point(6, 71);
            this.rd20.Name = "rd20";
            this.rd20.Size = new System.Drawing.Size(45, 17);
            this.rd20.TabIndex = 2;
            this.rd20.TabStop = true;
            this.rd20.Text = "20%";
            this.rd20.UseVisualStyleBackColor = true;
            // 
            // rdHairstyle
            // 
            this.rdHairstyle.AutoSize = true;
            this.rdHairstyle.Location = new System.Drawing.Point(6, 20);
            this.rdHairstyle.Name = "rdHairstyle";
            this.rdHairstyle.Size = new System.Drawing.Size(65, 17);
            this.rdHairstyle.TabIndex = 3;
            this.rdHairstyle.TabStop = true;
            this.rdHairstyle.Text = "Hairstyle";
            this.rdHairstyle.UseVisualStyleBackColor = true;
            // 
            // rdMOver
            // 
            this.rdMOver.AutoSize = true;
            this.rdMOver.Location = new System.Drawing.Point(6, 43);
            this.rdMOver.Name = "rdMOver";
            this.rdMOver.Size = new System.Drawing.Size(73, 17);
            this.rdMOver.TabIndex = 4;
            this.rdMOver.TabStop = true;
            this.rdMOver.Text = "Makeover";
            this.rdMOver.UseVisualStyleBackColor = true;
            // 
            // rdManicure
            // 
            this.rdManicure.AutoSize = true;
            this.rdManicure.Location = new System.Drawing.Point(6, 66);
            this.rdManicure.Name = "rdManicure";
            this.rdManicure.Size = new System.Drawing.Size(69, 17);
            this.rdManicure.TabIndex = 5;
            this.rdManicure.TabStop = true;
            this.rdManicure.Text = "Manicure";
            this.rdManicure.UseVisualStyleBackColor = true;
            // 
            // rdPermanent
            // 
            this.rdPermanent.AutoSize = true;
            this.rdPermanent.Location = new System.Drawing.Point(6, 89);
            this.rdPermanent.Name = "rdPermanent";
            this.rdPermanent.Size = new System.Drawing.Size(76, 17);
            this.rdPermanent.TabIndex = 6;
            this.rdPermanent.TabStop = true;
            this.rdPermanent.Text = "Permanent";
            this.rdPermanent.UseVisualStyleBackColor = true;
            // 
            // txtCurrentService
            // 
            this.txtCurrentService.Location = new System.Drawing.Point(212, 211);
            this.txtCurrentService.Name = "txtCurrentService";
            this.txtCurrentService.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentService.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(212, 249);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total for all services";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd10);
            this.groupBox1.Controls.Add(this.rdNone);
            this.groupBox1.Controls.Add(this.rd20);
            this.groupBox1.Location = new System.Drawing.Point(48, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdHairstyle);
            this.groupBox2.Controls.Add(this.rdMOver);
            this.groupBox2.Controls.Add(this.rdManicure);
            this.groupBox2.Controls.Add(this.rdPermanent);
            this.groupBox2.Location = new System.Drawing.Point(225, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 119);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCurrentService);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdNone;
        private System.Windows.Forms.RadioButton rd10;
        private System.Windows.Forms.RadioButton rd20;
        private System.Windows.Forms.RadioButton rdHairstyle;
        private System.Windows.Forms.RadioButton rdMOver;
        private System.Windows.Forms.RadioButton rdManicure;
        private System.Windows.Forms.RadioButton rdPermanent;
        private System.Windows.Forms.TextBox txtCurrentService;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

