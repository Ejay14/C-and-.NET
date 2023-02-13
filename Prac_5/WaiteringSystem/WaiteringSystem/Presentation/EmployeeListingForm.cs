using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using WaiteringSystem.Business;

namespace WaiteringSystem.Presentation
{
    public partial class EmployeeListingForm : Form
    {

        #region Variable Declarations
        public bool listFormClosed = true;
        private Collection<Employee> employees;
        private Role.RoleType roleValue;
        private EmployeeController employeeController;
        #endregion


        #region getter
        public bool getLim
        {
            set { listFormClosed = false; }
            get { return listFormClosed; }
        }
        #endregion
        #region Property Field

        public Role.RoleType RoleValue
        {
            set { roleValue = value; }
        }
        #endregion

        #region Constructor
        public EmployeeListingForm()
        {
            InitializeComponent();
        }

        public EmployeeListingForm(EmployeeController empController)
        {
            //empController = employeeController;
            employeeController = empController;
            // EmployeeController.employeeController = new EmployeeController();
            this.Load += EmployeeListingForm_Load;
            this.Activated += EmployeeListingForm_Activated;
        }
        #endregion

        #region setUpEmployee
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
                    this.employees = employeeController.AllEmployees; 
                    label1.Text = "Listing of all employees";
                    employeeListView.Columns.Insert(4, "Payment", 100, HorizontalAlignment.Center);
                    break;
                case Role.RoleType.Headwaiter:
                    //Add a FindByRole method to the EmployeeController
                    
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Headwaiter);
                    label1.Text = "Listing of all Headwaiters";
                    employeeController = new EmployeeController();
                  //  employeeController.FindByRole(employees,)
                    //Set Up Columns of List View
                    employeeListView.Columns.Insert(4, "Salary", 100, HorizontalAlignment.Center);
                    break;

                case Role.RoleType.Runner:
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Runner);
                    label1.Text = "Listing of all Runners";
                    employeeController = new EmployeeController();

                    employeeListView.Columns.Insert(4, "DayRate", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(5, "NoOfShifts", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(6, "Tips", 100, HorizontalAlignment.Center);
                    break;

                case Role.RoleType.Waiter:
                    employees = employeeController.FindByRole(employeeController.AllEmployees, Role.RoleType.Waiter);
                    label1.Text = "Listing of all Waiters";
                    employeeController = new EmployeeController();

                    employeeListView.Columns.Insert(4, "DayRate", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(5, "NoOfShifts", 100, HorizontalAlignment.Center);
                    employeeListView.Columns.Insert(6, "Tips", 100, HorizontalAlignment.Center);
                    break;




                    foreach (Employee employee in employees)
                    {
                        employeeDetails = new ListViewItem();
                        employeeDetails.Text = employee.ID.ToString();
                        employeeDetails.Text = employee.EmployeeID.ToString();
                        employeeDetails.Text = employee.Name.ToString();
                        employeeDetails.Text = employee.Telephone.ToString();


                        switch (employee.role.getRoleValue)
                        {
                            case Role.RoleType.Headwaiter:
                                headW = (HeadWaiter)employee.role;
                                employeeDetails.SubItems.Add(headW.SalaryAmount.ToString());
                                break;

                            case Role.RoleType.Runner:
                                runner = (Runner)employee.role;
                                employeeDetails.SubItems.Add(runner.getRate.ToString());
                                employeeDetails.SubItems.Add(runner.getShifts.ToString());
                                employeeDetails.SubItems.Add(runner.getTips.ToString());
                                break;

                            case Role.RoleType.Waiter:
                                waiter = (Waiter)employee.role;
                                employeeDetails.SubItems.Add(waiter.getRate.ToString());
                                employeeDetails.SubItems.Add(waiter.getShifts.ToString());
                                employeeDetails.SubItems.Add(waiter.getTips.ToString());
                                break;
                        }
                        employeeListView.Items.Add(employeeDetails);
                    }

                    employeeListView.Refresh();
                    employeeListView.GridLines = true;

            }
        }
        #endregion

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
            this.Load += EmployeeListingForm_Load;
            this.Activated += EmployeeListingForm_Activated;
        }
    }
}
