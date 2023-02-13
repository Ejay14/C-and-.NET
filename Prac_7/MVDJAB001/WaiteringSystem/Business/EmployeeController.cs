using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiteringSystem.Data;

namespace WaiteringSystem.Business
{
    
    public class EmployeeController:EmployeeDB
    {
        #region Data Members
        EmployeeDB employeeDB;
        Collection<Employee> employees;
        #endregion

        #region Properties
        public Collection<Employee> AllEmployees
        {
            get
            {
                return employees;
            }
        }
        #endregion

        #region Constructor
        public EmployeeController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            employeeDB = new EmployeeDB();
            employees = employeeDB.AllEmployees;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Employee anEmp, DB.DBOperation dBOperation)
        {
            //perform a given database operation to the dataset in meory; 
            employeeDB.DataSetChange(anEmp, dBOperation);
            employees.Add(anEmp);

            int index = 0;
            DataSetChange(anEmp,dBOperation);


            switch (dBOperation)
            {
                case DB.DBOperation.Add:
                    employees.Add(anEmp);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(anEmp);
                    break;



            }

                 

        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Employee employee)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return employeeDB.UpdateDataSource(employee);
        }

        public int FindIndex(Employee anEmp) 
        {
            int counter = 0;
            bool found = false;
            found = (anEmp.ID == employees[counter].ID);

            while (anEmp.Equals(found)) 
            {
                counter++;
                found = (anEmp.ID == employees[counter].ID);
            }
            if (found)
            {
                return counter;
            }

            else 
            {
                return -1;
            }
        }


        #endregion
        
        #region Searching through a collection
        public Collection<Employee> FindByRole(Collection<Employee> emps, Role.RoleType roleVal)
        {
            Collection<Employee> matches = new Collection<Employee>();
            foreach (Employee emp in emps)
            {
                if(emp.role.getRoleValue == roleVal)
                {
                    matches.Add(emp); 
                }
            }
            return matches;
        }

        //This method receives a employee ID as a parameter; finds the employee object in the collection of employees and then returns this object
        public Employee Find(string ID)
        {
            int index = 0;
            bool found = (employees[index].ID == ID);  //check if it is the first student
            int count = employees.Count;
            while (!(found) && (index < employees.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (employees[index].ID == ID);   // this will be TRUE if found
            }
            return employees[index];  // this is the one!  
        }
        #endregion
    }
}
