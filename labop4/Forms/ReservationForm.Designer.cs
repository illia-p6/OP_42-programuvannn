namespace labop4.Forms
{
    partial class ReservationForm
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
            comboBoxUsers = new ComboBox();
            comboBoxBooks = new ComboBox();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            dataGridViewReservations = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUsers
            // 
            comboBoxUsers.FormattingEnabled = true;
            comboBoxUsers.Location = new Point(27, 194);
            comboBoxUsers.Name = "comboBoxUsers";
            comboBoxUsers.Size = new Size(212, 38);
            comboBoxUsers.TabIndex = 0;
            comboBoxUsers.SelectedIndexChanged += comboBoxUsers_SelectedIndexChanged;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(27, 261);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(212, 38);
            comboBoxBooks.TabIndex = 1;
            comboBoxBooks.SelectedIndexChanged += comboBoxBooks_SelectedIndexChanged;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(27, 114);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(350, 35);
            dateTimePickerEnd.TabIndex = 2;
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(27, 26);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(350, 35);
            dateTimePickerStart.TabIndex = 3;
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // dataGridViewReservations
            // 
            dataGridViewReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservations.Location = new Point(391, 26);
            dataGridViewReservations.Name = "dataGridViewReservations";
            dataGridViewReservations.RowHeadersWidth = 72;
            dataGridViewReservations.Size = new Size(384, 250);
            dataGridViewReservations.TabIndex = 4;
            dataGridViewReservations.CellContentClick += dataGridViewReservations_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(391, 317);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(644, 317);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 40);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Редагувати";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(391, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(131, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Видалити";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(644, 395);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 40);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Оновити";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewReservations);
            Controls.Add(dateTimePickerStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(comboBoxBooks);
            Controls.Add(comboBoxUsers);
            Name = "ReservationForm";
            Text = "ReservationForm";
            Load += ReservationForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxUsers;
        private ComboBox comboBoxBooks;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private DataGridView dataGridViewReservations;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
    }
}