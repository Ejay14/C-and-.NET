
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListingForm));
            this.listLabel = new System.Windows.Forms.Label();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.shiftsTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.shiftsLabel = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.empIDLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(16, 6);
            this.listLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(59, 20);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "label1";
            // 
            // employeeListView
            // 
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(16, 31);
            this.employeeListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(1119, 312);
            this.employeeListView.TabIndex = 1;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.SelectedIndexChanged += new System.EventHandler(this.employeeListView_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(852, 550);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(85, 42);
            this.submitButton.TabIndex = 50;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(711, 551);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 42);
            this.cancelButton.TabIndex = 49;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Location = new System.Drawing.Point(852, 351);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(60, 42);
            this.deleteButton.TabIndex = 48;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Location = new System.Drawing.Point(764, 350);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(60, 42);
            this.editButton.TabIndex = 47;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // shiftsTextBox
            // 
            this.shiftsTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftsTextBox.Location = new System.Drawing.Point(236, 561);
            this.shiftsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shiftsTextBox.Name = "shiftsTextBox";
            this.shiftsTextBox.Size = new System.Drawing.Size(188, 27);
            this.shiftsTextBox.TabIndex = 46;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTextBox.Location = new System.Drawing.Point(236, 516);
            this.paymentTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(188, 27);
            this.paymentTextBox.TabIndex = 45;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(236, 462);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(188, 27);
            this.phoneTextBox.TabIndex = 44;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(236, 410);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(416, 27);
            this.nameTextBox.TabIndex = 43;
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDTextBox.Location = new System.Drawing.Point(552, 356);
            this.empIDTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(100, 27);
            this.empIDTextBox.TabIndex = 42;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(236, 354);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 27);
            this.idTextBox.TabIndex = 41;
            // 
            // shiftsLabel
            // 
            this.shiftsLabel.AutoSize = true;
            this.shiftsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftsLabel.Location = new System.Drawing.Point(55, 561);
            this.shiftsLabel.Name = "shiftsLabel";
            this.shiftsLabel.Size = new System.Drawing.Size(151, 20);
            this.shiftsLabel.TabIndex = 40;
            this.shiftsLabel.Text = "Number of Shifts";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.Location = new System.Drawing.Point(55, 516);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(81, 20);
            this.paymentLabel.TabIndex = 39;
            this.paymentLabel.Text = "Payment";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(55, 466);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(61, 20);
            this.phoneLabel.TabIndex = 38;
            this.phoneLabel.Text = "Phone";
            // 
            // empIDLabel
            // 
            this.empIDLabel.AutoSize = true;
            this.empIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIDLabel.Location = new System.Drawing.Point(419, 361);
            this.empIDLabel.Name = "empIDLabel";
            this.empIDLabel.Size = new System.Drawing.Size(115, 20);
            this.empIDLabel.TabIndex = 37;
            this.empIDLabel.Text = "Employee ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(55, 415);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 20);
            this.nameLabel.TabIndex = 36;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(55, 359);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 20);
            this.idLabel.TabIndex = 35;
            this.idLabel.Text = "ID";
            // 
            // EmployeeListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 645);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.shiftsTextBox);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.shiftsLabel);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.empIDLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.employeeListView);
            this.Controls.Add(this.listLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox shiftsTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label shiftsLabel;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label empIDLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
    }
}