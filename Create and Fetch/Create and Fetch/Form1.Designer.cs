namespace Create_and_Fetch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnadd = new Button();
            id = new TextBox();
            name = new TextBox();
            age = new TextBox();
            email = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 45);
            label1.Name = "label1";
            label1.Size = new Size(269, 40);
            label1.TabIndex = 0;
            label1.Text = "CRUD OPERATIONS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 316);
            label2.Name = "label2";
            label2.Size = new Size(192, 40);
            label2.TabIndex = 1;
            label2.Text = "Student Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 245);
            label3.Name = "label3";
            label3.Size = new Size(174, 40);
            label3.TabIndex = 2;
            label3.Text = "Student Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 184);
            label4.Name = "label4";
            label4.Size = new Size(200, 40);
            label4.TabIndex = 3;
            label4.Text = "Student Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 117);
            label5.Name = "label5";
            label5.Size = new Size(148, 40);
            label5.TabIndex = 4;
            label5.Text = "Student Id";
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(389, 377);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(123, 49);
            btnadd.TabIndex = 5;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // id
            // 
            id.Location = new Point(349, 117);
            id.Multiline = true;
            id.Name = "id";
            id.Size = new Size(292, 40);
            id.TabIndex = 6;
            // 
            // name
            // 
            name.Location = new Point(349, 184);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(292, 40);
            name.TabIndex = 7;
            // 
            // age
            // 
            age.Location = new Point(349, 245);
            age.Multiline = true;
            age.Name = "age";
            age.Size = new Size(292, 40);
            age.TabIndex = 8;
            // 
            // email
            // 
            email.Location = new Point(349, 316);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(292, 40);
            email.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(656, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(519, 301);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(931, 450);
            Controls.Add(dataGridView1);
            Controls.Add(email);
            Controls.Add(age);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(btnadd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnadd;
        private TextBox id;
        private TextBox name;
        private TextBox age;
        private TextBox email;
        private DataGridView dataGridView1;
    }
}
