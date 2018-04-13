using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class SQL
    {
        SqlConnection dbcon = new SqlConnection();
        SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
        
        public SqlConnection connectToDatabase(string databaseName)
        {
            connectionString.DataSource = "DILLON-HOME-PC";
            connectionString.InitialCatalog = databaseName;
            connectionString.IntegratedSecurity = true;

            SqlConnection connection = new SqlConnection();
            dbcon = new SqlConnection(connectionString.ToString());
            
            try
            {
                dbcon.Open();
                return dbcon;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex.InnerException);
            }
        }

        public void InsertTodoIntoDatabase(SqlConnection dbcon, string task, Status status)
        {
            string sqlInsert = "INSERT INTO Tasks (Owner, Task, Status, InsertedDate) VALUES (@owner, @task, @status, @insertDate)";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlInsert, dbcon);
                cmd.Parameters.AddWithValue("@owner", WindowsIdentity.GetCurrent().Name.ToString());
                cmd.Parameters.AddWithValue("@task", task);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@insertDate", DateTime.Now);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex.InnerException);
            }
        }

        public void CompleteTodo(SqlConnection dbcon, string id, Status status)
        {
            string sqlUpdate = "UPDATE Tasks SET Status = @status, CompletedDate = @completedDate WHERE ID = @id";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlUpdate, dbcon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@completedDate", DateTime.Now);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex.InnerException);
            }
        }

        public SqlDataReader GetCompletedTodos(SqlConnection dbcon)
        {
            string sqlSelect = "SELECT Task, CompletedDate FROM Tasks WHERE Status = @status AND Owner = @owner";
            SqlDataReader completedTasks;

            try
            {
                SqlCommand cmd = new SqlCommand(sqlSelect, dbcon);
                cmd.Parameters.AddWithValue("@owner", WindowsIdentity.GetCurrent().Name.ToString());
                cmd.Parameters.AddWithValue("@status", Status.Completed);
                completedTasks = cmd.ExecuteReader();


                cmd.Parameters.Clear();
                cmd.Dispose();

                return completedTasks;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex.InnerException);
            }
        }
    }

}
