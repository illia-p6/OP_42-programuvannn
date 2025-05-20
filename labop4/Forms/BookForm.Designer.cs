namespace labop4.Forms
{
    partial class BookForm
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
            Button btnAdd;
            dataGridViewBooks = new DataGridView();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtYear = new TextBox();
            txtPages = new TextBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblyear = new Label();
            lblPages = new Label();
            chkAvailable = new CheckBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(357, 332);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(357, 28);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 72;
            dataGridViewBooks.Size = new Size(420, 262);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.CellContentClick += dataGridViewBooks_CellContentClick;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(128, 67);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(175, 35);
            txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(128, 145);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(175, 35);
            txtAuthor.TabIndex = 2;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(128, 223);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(175, 35);
            txtYear.TabIndex = 3;
            // 
            // txtPages
            // 
            txtPages.Location = new Point(128, 304);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(175, 35);
            txtPages.TabIndex = 4;
            txtPages.TextChanged += txtPages_TextChanged;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(646, 332);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 40);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(357, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(646, 386);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 40);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Оновити";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(54, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(130, 30);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Назва книги";
            lblTitle.Click += label1_Click;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(54, 115);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(71, 30);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "Автор";
            // 
            // lblyear
            // 
            lblyear.AutoSize = true;
            lblyear.Location = new Point(54, 194);
            lblyear.Name = "lblyear";
            lblyear.Size = new Size(126, 30);
            lblyear.TabIndex = 11;
            lblyear.Text = "Рік видання";
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Location = new Point(54, 270);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(185, 30);
            lblPages.TabIndex = 12;
            lblPages.Text = "Кількість сторінок";
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Location = new Point(128, 366);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(130, 34);
            chkAvailable.TabIndex = 13;
            chkAvailable.Text = "Доступна";
            chkAvailable.UseVisualStyleBackColor = true;
            chkAvailable.CheckedChanged += chkAvailable_CheckedChanged;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkAvailable);
            Controls.Add(lblPages);
            Controls.Add(lblyear);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtPages);
            Controls.Add(txtYear);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(dataGridViewBooks);
            Name = "BookForm";
            Text = "BookForm";
            Load += BookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBooks;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtYear;
        private TextBox txtPages;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblyear;
        private Label lblPages;
        private CheckBox chkAvailable;
    }
}