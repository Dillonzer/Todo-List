using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class form_TodoList : Form
    {
        SQL db = new SQL();
        SqlConnection dbcon = new SqlConnection();
        SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();

        public form_TodoList()
        {
            InitializeComponent();
            connectToDatabase();
        }

        private void button_AddToTodo_Click(object sender, EventArgs e)
        {
            string task = textbox_TodoTask.Text;

            if (task != "")
                db.InsertTodoIntoDatabase(dbcon, task, Status.InProgress);
            else
                MessageBox.Show("Task cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            form_TodoList_Load(sender, e);

        }

        private void connectToDatabase()
        {
            connectionString.DataSource = "DILLON-HOME-PC";
            connectionString.InitialCatalog = "TodoList";
            connectionString.IntegratedSecurity = true;

            dbcon = db.ConnectToDatabase(connectionString.ConnectionString);
            try
            {
                dbcon.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex.InnerException);
            }
        }

        private void button_CompleteTask_Click(object sender, EventArgs e)
        {
           
            DataGridView dgv = datagrid_Tasks;
            
            foreach (DataGridViewCell cell in dgv.SelectedCells)
            {
                DataGridViewRow row = cell.OwningRow;
                db.CompleteTodo(dbcon, row.Cells["iDDataGridViewTextBoxColumn"].Value.ToString(), Status.Completed);
            }


            form_TodoList_Load(sender, e);
        }
        
        private void button_ViewCompletedTasks_Click(object sender, EventArgs e)
        {

        }

        private void form_TodoList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'todoListDataSet.Tasks' table. You can move, or remove it, as needed.
            this.tasksTableAdapter.Fill(this.todoListDataSet.Tasks);

        }
    }
}
