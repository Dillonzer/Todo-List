namespace TodoList
{
    partial class form_TodoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_AddToTodo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_TodoTask = new System.Windows.Forms.TextBox();
            this.datagrid_Tasks = new System.Windows.Forms.DataGridView();
            this.button_CompleteTask = new System.Windows.Forms.Button();
            this.button_ViewCompletedTasks = new System.Windows.Forms.Button();
            this.todoListDataSet = new TodoList.TodoListDataSet();
            this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tasksTableAdapter = new TodoList.TodoListDataSetTableAdapters.TasksTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Tasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddToTodo
            // 
            this.button_AddToTodo.Location = new System.Drawing.Point(460, 26);
            this.button_AddToTodo.Name = "button_AddToTodo";
            this.button_AddToTodo.Size = new System.Drawing.Size(75, 23);
            this.button_AddToTodo.TabIndex = 0;
            this.button_AddToTodo.Text = "Add";
            this.button_AddToTodo.UseVisualStyleBackColor = true;
            this.button_AddToTodo.Click += new System.EventHandler(this.button_AddToTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a Todo:";
            // 
            // textbox_TodoTask
            // 
            this.textbox_TodoTask.Location = new System.Drawing.Point(12, 29);
            this.textbox_TodoTask.Name = "textbox_TodoTask";
            this.textbox_TodoTask.Size = new System.Drawing.Size(442, 20);
            this.textbox_TodoTask.TabIndex = 2;
            // 
            // datagrid_Tasks
            // 
            this.datagrid_Tasks.AllowUserToAddRows = false;
            this.datagrid_Tasks.AllowUserToDeleteRows = false;
            this.datagrid_Tasks.AutoGenerateColumns = false;
            this.datagrid_Tasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Tasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.taskDataGridViewTextBoxColumn});
            this.datagrid_Tasks.DataSource = this.tasksBindingSource;
            this.datagrid_Tasks.Location = new System.Drawing.Point(12, 67);
            this.datagrid_Tasks.Name = "datagrid_Tasks";
            this.datagrid_Tasks.ReadOnly = true;
            this.datagrid_Tasks.Size = new System.Drawing.Size(523, 153);
            this.datagrid_Tasks.TabIndex = 3;
            // 
            // button_CompleteTask
            // 
            this.button_CompleteTask.Location = new System.Drawing.Point(447, 226);
            this.button_CompleteTask.Name = "button_CompleteTask";
            this.button_CompleteTask.Size = new System.Drawing.Size(88, 23);
            this.button_CompleteTask.TabIndex = 4;
            this.button_CompleteTask.Text = "Complete Task";
            this.button_CompleteTask.UseVisualStyleBackColor = true;
            this.button_CompleteTask.Click += new System.EventHandler(this.button_CompleteTask_Click);
            // 
            // button_ViewCompletedTasks
            // 
            this.button_ViewCompletedTasks.Location = new System.Drawing.Point(16, 227);
            this.button_ViewCompletedTasks.Name = "button_ViewCompletedTasks";
            this.button_ViewCompletedTasks.Size = new System.Drawing.Size(126, 23);
            this.button_ViewCompletedTasks.TabIndex = 5;
            this.button_ViewCompletedTasks.Text = "View Completed Tasks";
            this.button_ViewCompletedTasks.UseVisualStyleBackColor = true;
            this.button_ViewCompletedTasks.Click += new System.EventHandler(this.button_ViewCompletedTasks_Click);
            // 
            // todoListDataSet
            // 
            this.todoListDataSet.DataSetName = "TodoListDataSet";
            this.todoListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tasksBindingSource
            // 
            this.tasksBindingSource.DataMember = "Tasks";
            this.tasksBindingSource.DataSource = this.todoListDataSet;
            // 
            // tasksTableAdapter
            // 
            this.tasksTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // taskDataGridViewTextBoxColumn
            // 
            this.taskDataGridViewTextBoxColumn.DataPropertyName = "Task";
            this.taskDataGridViewTextBoxColumn.HeaderText = "Task";
            this.taskDataGridViewTextBoxColumn.Name = "taskDataGridViewTextBoxColumn";
            this.taskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // form_TodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 262);
            this.Controls.Add(this.button_ViewCompletedTasks);
            this.Controls.Add(this.button_CompleteTask);
            this.Controls.Add(this.datagrid_Tasks);
            this.Controls.Add(this.textbox_TodoTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddToTodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_TodoList";
            this.Text = "Todo List";
            this.Load += new System.EventHandler(this.form_TodoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Tasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddToTodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_TodoTask;
        private System.Windows.Forms.DataGridView datagrid_Tasks;
        private System.Windows.Forms.Button button_CompleteTask;
        private System.Windows.Forms.Button button_ViewCompletedTasks;
        private TodoListDataSet todoListDataSet;
        private System.Windows.Forms.BindingSource tasksBindingSource;
        private TodoListDataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDataGridViewTextBoxColumn;
    }
}

