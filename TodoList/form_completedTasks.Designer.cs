namespace TodoList
{
    partial class form_completedTasks
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
            this.datagrid_CompletedTasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_CompletedTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_CompletedTasks
            // 
            this.datagrid_CompletedTasks.AllowUserToAddRows = false;
            this.datagrid_CompletedTasks.AllowUserToDeleteRows = false;
            this.datagrid_CompletedTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_CompletedTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_CompletedTasks.Location = new System.Drawing.Point(12, 12);
            this.datagrid_CompletedTasks.Name = "datagrid_CompletedTasks";
            this.datagrid_CompletedTasks.ReadOnly = true;
            this.datagrid_CompletedTasks.Size = new System.Drawing.Size(776, 426);
            this.datagrid_CompletedTasks.TabIndex = 0;
            // 
            // form_completedTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagrid_CompletedTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_completedTasks";
            this.Text = "Completed Tasks";
            this.Load += new System.EventHandler(this.form_completedTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_CompletedTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_CompletedTasks;
    }
}