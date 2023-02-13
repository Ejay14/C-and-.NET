
namespace WaiteringSystem.Presentation
{
    partial class EmployeeListingForm
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
            this.listLabel = new System.Windows.Forms.Label();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.EmpIDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfShiftsTextBox = new System.Windows.Forms.TextBox();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(12, 5);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(52, 17);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "label1";
            // 
            // employeeListView
            // 
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(12, 25);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(695, 224);
            this.employeeListView.TabIndex = 1;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.SelectedIndexChanged += new System.EventHandler(this.employeeListView_SelectedIndexChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(167, 274);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(38, 278);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            this.idLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.Location = new System.Drawing.Point(429, 274);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeIDTextBox.TabIndex = 4;
            this.employeeIDTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EmpIDLabel
            // 
            this.EmpIDLabel.AutoSize = true;
            this.EmpIDLabel.Location = new System.Drawing.Point(319, 278);
            this.EmpIDLabel.Name = "EmpIDLabel";
            this.EmpIDLabel.Size = new System.Drawing.Size(67, 13);
            this.EmpIDLabel.TabIndex = 5;
            this.EmpIDLabel.Text = "Employee ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(38, 314);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(167, 304);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(362, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(38, 339);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(38, 13);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Phone";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(167, 336);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(163, 20);
            this.phoneTextBox.TabIndex = 9;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Location = new System.Drawing.Point(167, 375);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(163, 20);
            this.paymentTextBox.TabIndex = 10;
            // 
            // NumberOfShiftsTextBox
            // 
            this.NumberOfShiftsTextBox.Location = new System.Drawing.Point(167, 401);
            this.NumberOfShiftsTextBox.Name = "NumberOfShiftsTextBox";
            this.NumberOfShiftsTextBox.Size = new System.Drawing.Size(163, 20);
            this.NumberOfShiftsTextBox.TabIndex = 11;
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Location = new System.Drawing.Point(38, 369);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(48, 13);
            this.paymentLabel.TabIndex = 13;
            this.paymentLabel.Text = "Payment";
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Location = new System.Drawing.Point(41, 404);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(85, 13);
            this.shiftLabel.TabIndex = 14;
            this.shiftLabel.Text = "Number of Shifts";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(575, 401);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(672, 401);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 16;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WaiteringSystem.Properties.Resources.deleteIcon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(711, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.BackgroundImage = global::WaiteringSystem.Properties.Resources.editIcon;
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditButton.Location = new System.Drawing.Point(609, 274);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(83, 37);
            this.EditButton.TabIndex = 17;
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // EmployeeListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.NumberOfShiftsTextBox);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.EmpIDLabel);
            this.Controls.Add(this.employeeIDTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.listLabel);
            this.Name = "EmployeeListingForm";
            this.Text = "Employee Listing";
            this.Activated += new System.EventHandler(this.EmployeeListingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeListingForm_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.Label EmpIDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.TextBox NumberOfShiftsTextBox;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button button2;
    }
}