namespace labop4.Forms
{
    partial class UserForm
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
            dataGridViewUsers = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            brnRefresh = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txt1name = new Label();
            txt2Name = new Label();
            txt1Email = new Label();
            txt1Phone = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(327, 45);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 72;
            dataGridViewUsers.Size = new Size(420, 262);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellContentClick += dataGridViewUsers_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(327, 331);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(616, 331);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 40);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(327, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // brnRefresh
            // 
            brnRefresh.Location = new Point(616, 398);
            brnRefresh.Name = "brnRefresh";
            brnRefresh.Size = new Size(131, 40);
            brnRefresh.TabIndex = 4;
            brnRefresh.Text = "Оновити";
            brnRefresh.UseVisualStyleBackColor = true;
            brnRefresh.Click += brnRefresh_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(116, 76);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 35);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(116, 137);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(175, 35);
            txtLastName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 208);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 35);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(116, 279);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(175, 35);
            txtPhone.TabIndex = 8;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txt1name
            // 
            txt1name.AutoSize = true;
            txt1name.Location = new Point(5, 48);
            txt1name.Name = "txt1name";
            txt1name.Size = new Size(50, 30);
            txt1name.TabIndex = 9;
            txt1name.Text = "Ім'я";
            txt1name.Click += label1_Click;
            // 
            // txt2Name
            // 
            txt2Name.AutoSize = true;
            txt2Name.Location = new Point(5, 110);
            txt2Name.Name = "txt2Name";
            txt2Name.Size = new Size(105, 30);
            txt2Name.TabIndex = 10;
            txt2Name.Text = "Прізвище";
            // 
            // txt1Email
            // 
            txt1Email.AutoSize = true;
            txt1Email.Location = new Point(3, 175);
            txt1Email.Name = "txt1Email";
            txt1Email.Size = new Size(107, 30);
            txt1Email.TabIndex = 11;
            txt1Email.Text = "Ел. пошта";
            // 
            // txt1Phone
            // 
            txt1Phone.AutoSize = true;
            txt1Phone.Location = new Point(3, 246);
            txt1Phone.Name = "txt1Phone";
            txt1Phone.Size = new Size(174, 30);
            txt1Phone.TabIndex = 12;
            txt1Phone.Text = "Номер телефону";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt1Phone);
            Controls.Add(txt1Email);
            Controls.Add(txt2Name);
            Controls.Add(txt1name);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(brnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewUsers);
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button brnRefresh;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label txt1name;
        private Label txt2Name;
        private Label txt1Email;
        private Label txt1Phone;
    }
}