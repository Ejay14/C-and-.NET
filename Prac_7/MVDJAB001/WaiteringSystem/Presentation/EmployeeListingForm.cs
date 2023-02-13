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
        public bool listFormClosed;
        private Collection<Employee> employees;
        private Employee employee;
        private Role.RoleType roleValue;
        private EmployeeController employeeController;
        private FormStates state;

        //Add form states 
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }

        #endregion

        #region Property methods

        public Role.RoleType RoleValue
        {

            set { roleValue = value; }

        }

        #endregion

        #region Constructor

        public EmployeeListingForm(EmployeeController empController)
        {

            InitializeComponent();
            employeeController = empController;
            this.Load += EmployeeListingForm_Load;
            this.Activated += EmployeeListingForm_Activated;
            this.FormClosed += EmployeeListingForm_FormClosed;
            state = FormStates.View;

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
            ShowAll(false,roleValue);
        }
        #endregion

        #region Utility Methods
        private void ShowAll(bool value, Role.RoleType roleType)
        {
            idLabel.Visible = value;
            empIDLabel.Visible = value;
            nameLabel.Visible = value;
            phoneLabel.Visible = value;
            paymentLabel.Visible = value;
            idTextBox.Visible = value;
            empIDTextBox.Visible = value;
            nameTextBox.Visible = value;
            phoneTextBox.Visible = value;
            paymentTextBox.Visible = value;
            //If the form state is View, the Submit button and the Edit button should not be visible
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }
            deleteButton.Visible = value;
            editButton.Visible = value;

            if ((roleType == Role.RoleType.Waiter) || (roleType == Role.RoleType.Runner) && value)
            {
                shiftsLabel.Visible = value;
                shiftsTextBox.Visible = value;
            }
            else
            {
                shiftsLabel.Visible = false;
                shiftsTextBox.Visible = false;
            }

        }
        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                idTextBox.Enabled = !value;
                //do the same for all buttons & textboxes
                empIDTextBox.Enabled = !value;
            }
            else
            {
                idTextBox.Enabled = value;
                empIDTextBox.Enabled = value;
            }
            nameTextBox.Enabled = value;
            phoneTextBox.Enabled = value;
            paymentTextBox.Enabled = value;
            shiftsTextBox.Enabled = value;
            if (state == FormStates.Delete)
            {
                cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                cancelButton.Visible = value;
                submitButton.Visible = value;
            }
        }
        private void ClearAll()
        {
            idTextBox.Text = "";
            empIDTextBox.Text = "";
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
            paymentTextBox.Text = "";
            shiftsTextBox.Text = "";
        }
        private void PopulateTextBoxes(Employee employee)
        {
            HeadWaiter headW;
            Waiter waiter;
            Runner runner;
            idTextBox.Text = employee.ID;
            empIDTextBox.Text = employee.EmployeeID;
            nameTextBox.Text = employee.Name;
            phoneTextBox.Text = employee.Telephone;

            switch (employee.role.getRoleValue)
            {
                case Role.RoleType.Headwaiter:
                    headW = (HeadWaiter)(employee.role);
                    paymentTextBox.Text = Convert.ToString(headW.SalaryAmount);
                    break;
                case Role.RoleType.Waiter:
                    waiter = (Waiter)(employee.role);
                    paymentTextBox.Text = Convert.ToString(waiter.getRate);
                    shiftsTextBox.Text = Convert.ToString(waiter.getShifts);
                    break;
                case Role.RoleType.Runner:
                    runner = (Runner)(employee.role);
                    paymentTextBox.Text = Convert.ToString(runner.getRate);
                    shiftsTextBox.Text = Convert.ToString(runner.getShifts);
                    break;
            }
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

        private void employeeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true, roleValue);
            state = FormStates.View;
            EnableEntries(false);
            if (employeeListView.SelectedItems.Count > 0)   // if you selected an item 
            {
                employee = employeeController.Find(employeeListView.SelectedItems[0].Text);  //selected student becoms current student
                                                                                             // Show the details of the selected student in the controls
                PopulateTextBoxes(employee);
            }
        }
        #endregion

        private void editButton_Click(object sender, EventArgs e)
        {
            FormStates formStates = FormStates.Edit;
            EnableEntries(true);
        }

        private void PopulateObject(Role.RoleType roleType)
        {
            HeadWaiter headW;
            Waiter waiter;
            Runner runner;
            employee = new Employee(roleType);
            employee.ID = idTextBox.Text;
            employee.EmployeeID = empIDTextBox.Text;
            employee.Name = nameTextBox.Text;
            employee.Telephone = phoneTextBox.Text;

            switch (employee.role.getRoleValue)
            {
                case Role.RoleType.Headwaiter:
                    headW = (HeadWaiter)(employee.role);
                    headW.SalaryAmount = decimal.Parse(paymentTextBox.Text);
                    break;
                case Role.RoleType.Waiter:
                    //***waiter to be done later for HW
                    waiter = (Waiter)(employee.role);
                    waiter.getRate = decimal.Parse(paymentTextBox.Text);
                    waiter.getShifts = int.Parse(hoursTextBox.Text);
                    //  waiter.Tips = decimal.Parse(tipsTextBox.Text);
                    break;
                case Role.RoleType.Runner:
                    //***waiter to be done later for HW
                    runner = (Runner)(employee.role);
                    runner.getRate = decimal.Parse(paymentTextBox.Text);
                    runner.getShifts = int.Parse(hoursTextBox.Text);
                    break;
            }
        }



        private void submitButton_Click(object sender, EventArgs e) 
        {
            PopulateObject(roleValue);
            FormStates state = new FormStates();
            if (state == FormStates.Edit)
            {
                EmployeeController emp = new EmployeeController();
                emp.DataMaintenance(anEmp,dBOperation);

            }

            else 
            {
            
            }
            
            ClearAll();
            FormStates state = FormStates.View;
            ShowAll(false,roleValue);
            setUpEmployeeListView();
            
        }


    }
}
