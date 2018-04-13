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
    public partial class form_completedTasks : Form
    {
        SQL db = new SQL();
        SqlConnection dbcon;

        public form_completedTasks()
        {
            InitializeComponent();
            dbcon = db.connectToDatabase("TodoList");
        }

        private void form_completedTasks_Load(object sender, EventArgs e)
        {
            DataTable results = new DataTable();
            results.Load(db.GetCompletedTodos(dbcon));

            datagrid_CompletedTasks.DataSource = results;
        }

    }
}
