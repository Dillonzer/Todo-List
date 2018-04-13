using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class SQL
    {

        public SqlConnection ConnectToDatabase(string connectionString)
        {
            SqlConnection connection = new SqlConnection();
            connection = new SqlConnection(connectionString);

            return connection;
        }

        public void InsertTodoIntoDatabase(SqlConnection dbcon, string task, Status status)
        {
            string sqlInsert = "INSERT INTO Tasks (Owner, Task, Status, InsertedDate) VALUES (@owner, @task, @status, @insertDate)";

            try
            {
                SqlCommand cmd = new SqlCommand(sqlInsert, dbcon);
                cmd.Parameters.AddWithValue("@owner", Environment.UserName.ToString());
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
    }

}
