using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaiteringSystem.Business;

namespace WaiteringSystem.Presentation
{


    public partial class EmployeeListingForm : Form
    {

        #region Variables
        public bool listFormClosed;//= true;
        private Collection<Employee> employees;
        private Role.RoleType roleValue;
        private EmployeeController employeeController;
        protected FormStates state;
        private Employee employee;
        #endregion

        #region property methods

        public Role.RoleType RoleValue
        {

            set { roleValue = value; }

        }

        #endregion

        #region Constructor
        public EmployeeListingForm()
        {
            InitializeComponent();
            this.Load += EmployeeListingForm_Load;
            this.Activated += EmployeeListingForm_Activated;
            state = EmployeeListingForm.FormStates.View;
        }



        public EmployeeListingForm(EmployeeController empController)
        {

            InitializeComponent();
            employeeController = empController;
            this.Load += EmployeeListingForm_Load;
            this.Activated += EmployeeListingForm_Activated;
            state = EmployeeListingForm.FormStates.View;

        }
        #endregion

        #region Events
        private void EmployeeListingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }
        
        private void EmployeeListingForm_Load(object sender, EventArgs e)
        {
            employeeListView.View = View.Details;
        }

        private void EmployeeListingForm_Activated(object sender, EventArgs e)
        {
            employeeListView.View = View.Details;
        }
        #endregion

        #region ListView set up
        public void setUpEmployeeListView()
        {
            ListViewItem employeeDetails;
            HeadWaiter headW;
            Waiter waiter;
            Runner runner;
            employees = null;
            employeeListView.Clear();

            employeeListView.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(1, "EMPID", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(2, "Name", 120, HorizontalAlignment.Left);
            employeeListView.Columns.Insert(3, "Phone", 120, HorizontalAlignment.Left);


            switch (roleValue)
            {
                case Role.RoleType.NoRole:
                    employees = employeeController.AllEmployees; listLabel.Text = "Listing of all employees";
                    employeeListView.Columns.Insert(4, "Payment", 100, HorizontalAlignment.Center);
                    break;
                case Role.RoleType.Headwaiter:
                    //Add a FindByRole method to the EmployeeController
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Headwaiter);
                    listLabel.Text = "Listing of all Headwaiters";
                    //Set Up Columns of List View
                    employeeListView.Columns.Insert(4, "Salary", 100, HorizontalAlignment.Center);
                    break;
                case Role.RoleType.Waiter:
                    //Add a FindByRole method to the EmployeeController
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Waiter);
                    listLabel.Text = "Listing of all Waiters";
                    //Set Up Columns of List View
                    employeeListView.Columns.Insert(4, "DayRate", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(5, "NoOfShifts", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(6, "Tips", 100, HorizontalAlignment.Center);
                    break;

                case Role.RoleType.Runner:
                    //Add a FindByRole method to the EmployeeController
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Runner);
                    listLabel.Text = "Listing of all Runners";
                    //Set Up Columns of List View
                    employeeListView.Columns.Insert(4, "DayRate", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(5, "NoOfShifts", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(6, "Tips", 100, HorizontalAlignment.Center);
                    break;
            }




            foreach (Employee employee in employees)
            {
                employeeDetails = new ListViewItem();
                employeeDetails.Text = employee.ID.ToString();
                employeeDetails.SubItems.Add(employee.EmployeeID.ToString());
                employeeDetails.SubItems.Add(employee.Name.ToString());
                employeeDetails.SubItems.Add(employee.Telephone.ToString());
                // Do the same for EmpID, Name and Phone
                switch (employee.role.getRoleValue)
                {
                    case Role.RoleType.Headwaiter:
                        headW = (HeadWaiter)employee.role;
                        employeeDetails.SubItems.Add(headW.SalaryAmount.ToString());
                        break;
                    case Role.RoleType.Waiter:
                        waiter = (Waiter)employee.role;
                        employeeDetails.SubItems.Add(waiter.getRate.ToString());
                        employeeDetails.SubItems.Add(waiter.getShifts.ToString());
                        employeeDetails.SubItems.Add(waiter.getTips.ToString());
                        break;
                    case Role.RoleType.Runner:
                        runner = (Runner)employee.role;
                        employeeDetails.SubItems.Add(runner.getRate.ToString());
                        employeeDetails.SubItems.Add(runner.getShifts.ToString());
                        employeeDetails.SubItems.Add(runner.getTips.ToString());
                        break;

                }

                employeeListView.Items.Add(employeeDetails);


            }

            employeeListView.Refresh();
            employeeListView.GridLines = true;
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        #region Enumeration
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        #endregion
        #region  Utility methods
        private void ShowAll(bool value, Role.RoleType roleType)
        {
            idLabel.Visible = value;
            EmpIDLabel.Visible = value;
            nameLabel.Visible = value;
            phoneLabel.Visible = value;
            paymentLabel.Visible = value;
            shiftLabel.Visible = value;
            idTextBox.Visible = value;
            employeeIDTextBox.Visible = value;
            nameTextBox.Visible = value;
            phoneTextBox.Visible = value;
            paymentTextBox.Visible = value;
            NumberOfShiftsTextBox.Visible = value;
            CancelButton.Visible = value;
            SubmitButton.Visible = value;

            if(state == FormStates.View)
            {
                SubmitButton.Visible = false;
                EditButton.Visible = false;
            }

            else
            {
                SubmitButton.Visible = true;
                EditButton.Visible = true;
            }
            if ((roleType == Role.RoleType.Waiter) || (roleType == Role.RoleType.Runner) && value)
            {
                shiftLabel.Visible = value;
                NumberOfShiftsTextBox.Visible = value;

            }
            else
            {
                shiftLabel.Visible = false;
                NumberOfShiftsTextBox.Visible = false;
            }
        }
        private void ClearAll()
        {
            idTextBox.Text = "";
            employeeIDTextBox.Text = "";
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
            paymentTextBox.Text = "";
            NumberOfShiftsTextBox.Text = "";
        }

        private void EnableEntries(bool value)
        {
            if ( state == FormStates.Edit && value)
            {
                idTextBox.Enabled = !value;
                employeeIDTextBox.Enabled = !value;

            }
            else
            {
                idTextBox.Enabled = value;
                employeeIDTextBox.Enabled = value;
            }
            
            nameTextBox.Enabled = value;
            phoneTextBox.Enabled = value;
            paymentTextBox.Enabled = value;
            NumberOfShiftsTextBox.Enabled = value;

            if(state == FormStates.Delete)
            {
                CancelButton.Visible = false;
                SubmitButton.Visible = false;
            }
            else if(state != FormStates.Delete)
            {
                CancelButton.Visible = value;
                SubmitButton.Visible = value;
            }
        }

        #endregion

        #region Populate textbooks
        private void PopulateTextBoxes(Employee employee)
        {
            HeadWaiter headW;
            Runner runner;
            Waiter waiter;
            idTextBox.Text = employee.ID;
            employeeIDTextBox.Text = employee.EmployeeID;
            nameTextBox.Text = employee.Name;
            phoneTextBox.Text = employee.Telephone;

            switch (employee.role.getRoleValue)
                {
                case Role.RoleType.Headwaiter:
                        headW = (HeadWaiter)(employee.role);
                        paymentTextBox.Text = Convert.ToString(headW.SalaryAmount);
                        break;
                case Role.RoleType.Runner:
                    runner = (Runner)(employee.role);
                    paymentTextBox.Text = Convert.ToString(runner.getTips);
                    NumberOfShiftsTextBox.Text = Convert.ToString(runner.getShifts);
                    break;
                case Role.RoleType.Waiter:
                    waiter = (Waiter)(employee.role);
                    paymentTextBox.Text = Convert.ToString(waiter.getTips);
                    NumberOfShiftsTextBox.Text = Convert.ToString(waiter.getShifts);
                    break;
            }
        }
        #endregion

        private void employeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true,roleValue);
            state = FormStates.View;
            EnableEntries(false);
            if (employeeListView.SelectedItems.Count > 0) 
            {
                employee = employeeController.Find(employeeListView.SelectedItems[0].Text);
                PopulateTextBoxes(employee);
            }
        }
    }
}