using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WaiteringSystem.Properties;

namespace WaiteringSystem.Data
{
    public class DB
    {
        string strConn = Settings.Default.EmployeeDatabaseConnectionString;
        SqlConnection cnMain;
        DataSet dsMain;
        SqlDataAdapter daMain;
        String Command;
        DataTable Table;
        bool success;



         public DB()
        {
            try
            {
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch { Console.WriteLine("Connection could not established"); }
        }

        public void FillDataSet(SqlCommand aSQLstring, DataTable aTable) 
        {
            try
            {
                daMain = new SqlDataAdapter(Command, cnMain);
                cnMain = new SqlConnection(strConn);
                dsMain.Clear();
                daMain.Fill(dsMain);
                cnMain.Close();
                

            }
            catch(Exception errObj) 
            {
                MessageBox.Show(errObj.Message +" "+errObj.StackTrace);
            }
        
        }

        public void UpdateDataSource(String sqlLocal, DataTable aTable) 
        {
            try
            {
                success = true;
                cnMain = new SqlConnection(strConn);
                daMain.Update(dsMain, Command);
                cnMain.Close();
                daMain.Fill(dsMain);
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + " " + errObj.StackTrace);
                success = false;
            }
            finally 
            {
            }
            return success;
        
        
        }
    
    }
        

    



    }

    
}
