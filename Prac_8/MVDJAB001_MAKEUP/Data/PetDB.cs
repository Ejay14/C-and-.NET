using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PetSystem.Properties;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetSystem.Data
{
    class PetDB
    {

            #region Variable declaration
            private string strConn = Settings.Default.PetDBSystemConnectionString;
            protected SqlConnection cnMain;
            protected DataSet dsMain;
            protected SqlDataAdapter daMain;
            #endregion

            #region Constructor
            public PetDB()
            {
                try
                {
                    cnMain = new SqlConnection(strConn);
                    dsMain = new DataSet();
                }
                catch (SystemException e)
                {
                    System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                    return;
                }
            }

            #endregion

            #region Update the DateSet
            public void FillDataSet(string aSQLstring, string aTable)
            {
                //fills dataset fresh from the db for a specific table and with a specific Query
                try
                {
                    daMain = new SqlDataAdapter(aSQLstring, cnMain);
                    cnMain.Open();
                    //dsMain.Clear();
                    daMain.Fill(dsMain, aTable);
                    cnMain.Close();
                }
                catch (Exception errObj)
                {
                    MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                }
            }

            #endregion

            #region Update the data source 
            protected bool UpdateDataSource(string sqlLocal, string table)
            {
                bool success;
                try
                {
                    //open the connection
                    cnMain.Open();
                    //***update the database table via the data adapter
                    daMain.Update(dsMain, table);

                    cnMain.Close();
                    FillDataSet(sqlLocal, table);
                    success = true;
                }
                catch (Exception errObj)
                {
                    MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                    success = false;
                }
                finally
                {
                }
                return success;
            }
            #endregion
    }
}

