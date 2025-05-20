using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using labop4.Forms;
using labop4.Models;
using labop4.Repositories;


namespace labop4.Forms
{
    public partial class MainForm : Form
    {
        private Repository<User> _userRepository = new Repository<User>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(_userRepository);
            userForm.ShowDialog();

        }

        private Repository<Book> _bookRepository = new Repository<Book>();
        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(_bookRepository);
            bookForm.ShowDialog();

        }
        private Repository<Reservation> _reservationRepository = new Repository<Reservation>();

        private void btnReservation_Click(object sender, EventArgs e)
        {
            ReservationForm reservationForm = new ReservationForm(_reservationRepository, _userRepository, _bookRepository);
            reservationForm.ShowDialog();
        }
    }
}
