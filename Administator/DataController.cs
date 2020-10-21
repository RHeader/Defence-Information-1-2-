using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Administator
{
    class DataController
    {
        string SqlConnectionPath = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=W:\Project C#\Administator\Administator\UsersDataBase.mdf;Integrated Security=True";
        SqlConnection sqlConnection;
      
       async public void SaveData(string Login,string Password,string FirstName,string LastName)
        {
            try
            {
                sqlConnection = new SqlConnection(this.SqlConnectionPath);
               await sqlConnection.OpenAsync();
            }
            catch (Exception ex)
            {
                     MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("INSERT INTO [Table] (Login, Password, FirstName,LastName)VALUES (@Login, @Password, @FirstName,@LastName )", sqlConnection);
            command.Parameters.AddWithValue("Login",Login);
            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            
        }
        async void DeleteDataSQL()
        {
            
            sqlConnection = new SqlConnection(this.SqlConnectionPath);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("TRUNCATE TABLE [DataSetCs]", sqlConnection);
            await command.ExecuteNonQueryAsync();
        }

        public bool Login(string password,string login,out int id, out bool Administrator, out string FirstName, out string LastName, out bool BlockedAccount , out bool BlockedPassword) { 
          id = 0;
            Administrator = false;
            FirstName = "";
            LastName = "";
            BlockedAccount = false;
            BlockedPassword = false;
            SqlDataReader ReadInfo =null;
            try
            {
                sqlConnection = new SqlConnection(SqlConnectionPath);
                sqlConnection.Open();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("SELECT * FROM [Table] WHERE Login = '"+login+"' AND Password = '"+password+"'", sqlConnection);
            try
            {
                ReadInfo = command.ExecuteReader();
                ReadInfo.Read();

                if ((string)ReadInfo["Login"] != null) {
                    id = Convert.ToInt32(ReadInfo["Id"]);
                    Administrator =Convert.ToBoolean(ReadInfo["Administrator"]);
                    FirstName = Convert.ToString(ReadInfo["FirstName"]);
                    LastName = Convert.ToString(ReadInfo["LastName"]);
                    BlockedAccount = Convert.ToBoolean(ReadInfo["Blocked Account"]);
                    BlockedPassword = Convert.ToBoolean(ReadInfo["Blocked Password Range"]);
                    return true;
                        };
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (ReadInfo != null)
                    ReadInfo.Close();
            }
            return false;
        }

        async public void LoadInfoForAdmin ()
        {
            try
            {
                sqlConnection = new SqlConnection(this.SqlConnectionPath);
                await sqlConnection.OpenAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand command = new SqlCommand("INSERT INTO [Table] (Login, Password, FirstName,LastName)VALUES (@Login, @Password, @FirstName,@LastName )", sqlConnection);
        }



    }
}
