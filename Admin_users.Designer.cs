namespace Bank_project
{
    partial class Admin_users
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
            dataGridView1 = new DataGridView();
            button9 = new Button();
            button4 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(58, 175, 169);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 89);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(674, 336);
            dataGridView1.TabIndex = 37;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(170, 64, 70);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(737, 17);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(50, 40);
            button9.TabIndex = 74;
            button9.Text = "✖️";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 183, 207);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(678, 17);
            button4.Margin = new Padding(2, 0, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(55, 40);
            button4.TabIndex = 73;
            button4.Text = "◀️";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(353, 29);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 24);
            label5.TabIndex = 72;
            label5.Text = "All Users";
            label5.Click += label5_Click;
            // 
            // Admin_users
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 175, 169);
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Name = "Admin_users";
            Text = "Admin_users";
            Load += Admin_users_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button9;
        private Button button4;
        private Label label5;
    }
}