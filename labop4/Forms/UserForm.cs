﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labop4.Models;        // ← для класу User
using labop4.Repositories; // ← для класу Repository<T>

namespace labop4.Forms
{
    public partial class UserForm : Form
    {
        private Repository<User> _userRepository;

        public UserForm(Repository<User> userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }


        private void LoadUsers()
        {
            var users = _userRepository.GetAll();
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = users.Select(u => new
            {
                u.ID,
                u.FirstName,
                u.LastName,
                u.Email,
                u.Phone
            }).ToList();
        }
        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewUsers.SelectedRows[0];
                txtFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
            }
        }

        private int GetNextUserId()
        {
            var users = _userRepository.GetAll();
            return users.Count == 0 ? 1 : users.Max(u => u.ID) + 1;
        }

        private void ClearInputFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new User(
                GetNextUserId(),

               txtFirstName.Text,
              txtLastName.Text,
              txtEmail.Text,

              txtPhone.Text);

                _userRepository.Add(newUser);
                LoadUsers();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні користувача: {ex.Message}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridViewUsers.SelectedRows[0].Cells["ID"].Value;
                var user = _userRepository.GetById(selectedId);
                if (user != null)
                {
                    user.FirstName = txtFirstName.Text;
                    user.LastName = txtLastName.Text;
                    user.Email = txtEmail.Text;
                    user.Phone = txtPhone.Text;

                    LoadUsers();
                    ClearInputFields();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть користувача для редагування.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridViewUsers.SelectedRows[0].Cells["ID"].Value;
                var user = _userRepository.GetById(selectedId);
                if (user != null)
                {
                    _userRepository.Remove(user);
                    LoadUsers();
                    ClearInputFields();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть користувача для видалення.");
            }
        }

        private void brnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
