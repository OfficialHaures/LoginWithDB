namespace LoginWithDB
{
    partial class AppForm
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
            update_button = new Button();
            delete_button = new Button();
            dataGridView1 = new DataGridView();
            nummer = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // update_button
            // 
            update_button.Location = new Point(615, 94);
            update_button.Name = "update_button";
            update_button.Size = new Size(94, 29);
            update_button.TabIndex = 0;
            update_button.Text = "Update";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(732, 94);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(94, 29);
            delete_button.TabIndex = 1;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nummer, type });
            dataGridView1.Location = new Point(371, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(455, 289);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nummer
            // 
            nummer.HeaderText = "nummer";
            nummer.MinimumWidth = 6;
            nummer.Name = "nummer";
            nummer.Width = 125;
            // 
            // type
            // 
            type.HeaderText = "type";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.Width = 125;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 507);
            Controls.Add(dataGridView1);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Name = "AppForm";
            Text = "AppForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button update_button;
        private Button delete_button;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nummer;
        private DataGridViewTextBoxColumn type;
    }
}