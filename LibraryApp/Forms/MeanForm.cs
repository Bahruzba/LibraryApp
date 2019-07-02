using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApp.Models;
using LibraryApp.DAL;

namespace LibraryApp.Forms
{
    public partial class MeanForm : Form
    {
        private LibraryAppContext context;
        private Book selectedBook;
        private Customer selectedCustomer;
        private Manager selectedManager;

        public MeanForm()
        {
            context = new LibraryAppContext();
            InitializeComponent();
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            BtnOrders.BackColor = Color.FromArgb(250, 130, 0);
            BtnBooks.BackColor = Color.FromArgb(230, 100, 0);
            BtnCustomers.BackColor = Color.FromArgb(230, 100, 0);
            BtnManagers.BackColor = Color.FromArgb(230, 100, 0);

            PnlOrders.Visible = true;
            PnlBooks.Visible = false;
            PnlCustomers.Visible = false;
            PnlManagers.Visible = false;

        }


        #region Books
        private void BtnBooks_Click(object sender, EventArgs e)
        {
            BtnOrders.BackColor = Color.FromArgb(230, 100, 0);
            BtnBooks.BackColor = Color.FromArgb(250, 130, 0);
            BtnCustomers.BackColor = Color.FromArgb(230, 100, 0);
            BtnManagers.BackColor = Color.FromArgb(230, 100, 0);

            CbbFilterBooks.SelectedIndex = 0;
            CbbSortBooks.SelectedIndex = 1;
            CbbSearchBooks.SelectedIndex = 0;

            PnlOrders.Visible = false;
            PnlBooks.Visible = true;
            PnlCustomers.Visible = false;
            PnlManagers.Visible = false;
            AllBooks();


        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ChechTxtboxsBooks())
            {
                return;
            }


            Book book = new Book
            {
                Name = TxtNameBook.Text,
                Writter = TxtWritterBook.Text,
                MonthlyPrice = Convert.ToDecimal(TxtPriceBook.Text),
                Count = Convert.ToInt32(TxtCountBook.Text)
            };
            context.Books.Add(book);
            context.SaveChanges();
            DgvBooks.Rows.Clear();
            AllBooks();
            MessageBox.Show("Məlumat əlavə olundu.");
            ClearTexboxtBooks();
        }

        public void AllBooks()
        {
            DgvBooks.Rows.Clear();
            if(TxtSearchBooks.Text!= "Axtarış edin..."&& CbbSearchBooks.SelectedIndex==0)
            {
                List<Book> books = context.Books.Where(b => b.Name.StartsWith(TxtSearchBooks.Text)).ToList();
                foreach(Book book in books)
                {
                    string status = "Kitabxanada";
                    List<Order> orders = context.Orders.Where(o => o.BookId == book.Id).ToList();
                    foreach (Order order in orders)
                    {
                        if (order.ReturnTime.ToString() == "")
                        {
                            status = "İcarədə";
                        }
                    }
                    DgvBooks.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, book.Count, status);
                }
            } else if (TxtSearchBooks.Text != "Axtarış edin..." && CbbSearchBooks.SelectedIndex == 1)
            {
                List<Book> books = context.Books.Where(b => b.Writter.StartsWith(TxtSearchBooks.Text)).ToList();
                foreach (Book book in books)
                {
                    string status = "Kitabxanada";
                    List<Order> orders = context.Orders.Where(o => o.BookId == book.Id).ToList();
                    foreach (Order order in orders)
                    {
                        if (order.ReturnTime.ToString() == "")
                        {
                            status = "İcarədə";
                        }
                    }
                    DgvBooks.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, book.Count, status);
                }
            }
            else if (CbbFilterBooks.SelectedIndex == 0)

                {
                List<Book> books = context.Books.ToList();
                if (CbbSortBooks.SelectedIndex == 0)
                {
                    books = context.Books.OrderBy(o => o.Name).ToList();
                }
                else if (CbbSortBooks.SelectedIndex == 2)
                {
                    books = context.Books.OrderBy(o => o.MonthlyPrice).ToList();
                }
                else if (CbbSortBooks.SelectedIndex == 3)
                {
                    books = context.Books.OrderBy(o => o.Count).ToList();
                }

                foreach (Book book in books)
                {
                    string status = "Kitabxanada";
                    List<Order> orders = context.Orders.Where(o => o.BookId == book.Id).ToList();
                    foreach (Order order in orders)
                    {
                        if (order.ReturnTime.ToString() == "")
                        {
                            status = "İcarədə";
                        }
                    }
                    DgvBooks.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, book.Count, status);
                }
            }
            else if (CbbFilterBooks.SelectedIndex == 1)
            {
                List<Book> books = context.Books.ToList();
                if (CbbSortBooks.SelectedIndex == 0)
                {
                    books = context.Books.OrderBy(o => o.Name).ToList();
                }
                else if (CbbSortBooks.SelectedIndex == 2)
                {
                    books = context.Books.OrderBy(o => o.MonthlyPrice).ToList();
                }
                else if (CbbSortBooks.SelectedIndex == 3)
                {
                    books = context.Books.OrderBy(o => o.Count).ToList();
                }

                foreach (Book book in books)
                {
                    string status = "Kitabxanada";
                    List<Order> orders = context.Orders.Where(o => o.BookId == book.Id).ToList();
                    foreach (Order order in orders)
                    {
                        if (order.ReturnTime.ToString() == "")
                        {
                            status = "İcarədə";
                        }
                    }
                    if (status == "Kitabxanada")
                    {
                        DgvBooks.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, book.Count, status);
                    }
                }
            }
            else if (CbbFilterBooks.SelectedIndex == 2)
            {
                List<Book> books = context.Books.ToList();
                if (CbbSortBooks.SelectedIndex == 0)
                {
                    books = context.Books.OrderBy(o => o.Name).ToList();
                }
                else if (CbbSortBooks.SelectedIndex == 2)
                {
                    books = context.Books.OrderBy(o => o.MonthlyPrice).ToList();
                }
                else if (CbbSortBooks.SelectedIndex == 3)
                {
                    books = context.Books.OrderBy(o => o.Count).ToList();
                }

                foreach (Book book in books)
                {
                    string status = "Kitabxanada";
                    List<Order> orders = context.Orders.Where(o => o.BookId == book.Id).ToList();
                    foreach (Order order in orders)
                    {
                        if (order.ReturnTime.ToString() == "")
                        {
                            status = "İcarədə";
                            DgvBooks.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, book.Count, status);
                        }
                    }
                }
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            AllBooks();
        }

        public Boolean ChechTxtboxsBooks()
        {
            if (TxtNameBook.Text == "Kitabın adı" || TxtWritterBook.Text == "Yazarı" || TxtPriceBook.Text == "Qiyməti" || TxtCountBook.Text == "Sayı" || !decimal.TryParse(TxtPriceBook.Text, out decimal a) || !int.TryParse(TxtCountBook.Text, out int b))
            {
                LblUnderlineNameBook.BackColor = Color.Orange;
                LblUnderlineWritterBook.BackColor = Color.Orange;
                LblUnderlinePriceBook.BackColor = Color.Orange;
                LblUnderlineCountBook.BackColor = Color.Orange;
                if (TxtNameBook.Text == "Kitabın adı" || TxtWritterBook.Text == "Yazarı" || TxtPriceBook.Text == "Qiyməti" || TxtCountBook.Text == "Sayı")
                {
                    if (TxtNameBook.Text == "Kitabın adı")
                    {
                        LblUnderlineNameBook.BackColor = Color.Maroon;
                    }
                    if (TxtWritterBook.Text == "Yazarı")
                    {
                        LblUnderlineWritterBook.BackColor = Color.Maroon;
                    }
                    if (TxtPriceBook.Text == "Qiyməti")
                    {
                        LblUnderlinePriceBook.BackColor = Color.Maroon;
                    }
                    if (TxtCountBook.Text == "Sayı")
                    {
                        LblUnderlineCountBook.BackColor = Color.Maroon;
                    }
                    MessageBox.Show("Xanaları tam doldurun");
                    return false;
                }
                if (!decimal.TryParse(TxtPriceBook.Text, out a) || !int.TryParse(TxtCountBook.Text, out b))
                {

                    if (!decimal.TryParse(TxtPriceBook.Text, out a))
                    {
                        LblUnderlinePriceBook.BackColor = Color.Maroon;
                        TxtPriceBook.Text = "Qiyməti";
                        TxtPriceBook.ForeColor = Color.Silver;
                    }
                    if (!int.TryParse(TxtCountBook.Text, out b))
                    {
                        LblUnderlineCountBook.BackColor = Color.Maroon;
                        TxtCountBook.Text = "Sayı";
                        TxtCountBook.ForeColor = Color.Silver;
                    }
                    MessageBox.Show("Qiymət və say ədədlə yazılmalıdır.");
                }
                return false;
            }
            else
            {
                return true;
            }

        }

        public void ClearTexboxtBooks()
        {
            TxtNameBook.Text = "Kitabın adı";
            TxtWritterBook.Text = "Yazarı";
            TxtPriceBook.Text = "Qiyməti";
            TxtCountBook.Text = "Sayı";

            TxtNameBook.ForeColor = Color.Silver;
            TxtWritterBook.ForeColor = Color.Silver;
            TxtPriceBook.ForeColor = Color.Silver;
            TxtCountBook.ForeColor = Color.Silver;

            LblUnderlineNameBook.BackColor = Color.Orange;
            LblUnderlineWritterBook.BackColor = Color.Orange;
            LblUnderlinePriceBook.BackColor = Color.Orange;
            LblUnderlineCountBook.BackColor = Color.Orange;
        }

        private void DgvBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int IdBook = Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value);
            selectedBook = context.Books.Find(IdBook);
            TxtNameBook.Text = selectedBook.Name;
            TxtWritterBook.Text = selectedBook.Writter;
            TxtPriceBook.Text = selectedBook.MonthlyPrice.ToString();
            TxtCountBook.Text = selectedBook.Count.ToString();

            TxtNameBook.ForeColor = Color.Black;
            TxtWritterBook.ForeColor = Color.Black;
            TxtPriceBook.ForeColor = Color.Black;
            TxtCountBook.ForeColor = Color.Black;

            BtnAddBook.Visible = false;
            BtnDeleteBook.Visible = true;
            BtnUpdateBook.Visible = true;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!ChechTxtboxsBooks())
            {
                return;
            }
            ChechTxtboxsBooks();
            selectedBook.Name = TxtNameBook.Text;
            selectedBook.Writter = TxtWritterBook.Text;
            selectedBook.MonthlyPrice = Convert.ToDecimal(TxtPriceBook.Text);
            selectedBook.Count = Convert.ToInt16(TxtCountBook.Text);
            context.SaveChanges();
            AllBooks();
            MessageBox.Show(selectedBook.Name + " kitabı yeniləndi.");
            ClearTexboxtBooks();


            BtnAddBook.Visible = true;
            BtnDeleteBook.Visible = false;
            BtnUpdateBook.Visible = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            context.Books.Remove(selectedBook);
            context.SaveChanges();
            AllBooks();
            MessageBox.Show(selectedBook.Name + " kitabı silindi.");
            ClearTexboxtBooks();
            BtnAddBook.Visible = true;
            BtnDeleteBook.Visible = false;
            BtnUpdateBook.Visible = false;
        }

        private void CbbSortBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllBooks();
        }

        #endregion

        #region Methots for Button's Placeholder

        //Books Textboxs Placeholder
        private void TxtNameBook_Enter(object sender, EventArgs e)
        {
            if (TxtNameBook.Text == "Kitabın adı")
            {
                TxtNameBook.Text = "";
                TxtNameBook.ForeColor = Color.Black;
            }
        }

        private void TxtNameBook_Leave(object sender, EventArgs e)
        {
            if (TxtNameBook.Text == "")
            {
                TxtNameBook.Text = "Kitabın adı";
                TxtNameBook.ForeColor = Color.Silver;
            }

        }

        private void TxtWritterBook_Enter(object sender, EventArgs e)
        {
            if (TxtWritterBook.Text == "Yazarı")
            {
                TxtWritterBook.Text = "";
                TxtWritterBook.ForeColor = Color.Black;
            }
        }

        private void TxtWritterBook_Leave(object sender, EventArgs e)
        {
            if (TxtWritterBook.Text == "")
            {
                TxtWritterBook.Text = "Yazarı";
                TxtWritterBook.ForeColor = Color.Silver;
            }
        }

        private void TxtPriceBook_Enter(object sender, EventArgs e)
        {
            if (TxtPriceBook.Text == "Qiyməti")
            {
                TxtPriceBook.Text = "";
                TxtPriceBook.ForeColor = Color.Black;
            }
        }

        private void TxtPriceBook_Leave(object sender, EventArgs e)
        {
            if (TxtPriceBook.Text == "")
            {
                TxtPriceBook.Text = "Qiyməti";
                TxtPriceBook.ForeColor = Color.Silver;
            }

        }

        private void TxtCountBook_Enter(object sender, EventArgs e)
        {
            if (TxtCountBook.Text == "Sayı")
            {
                TxtCountBook.Text = "";
                TxtCountBook.ForeColor = Color.Black;
            }
        }

        private void TxtCountBook_Leave(object sender, EventArgs e)
        {
            if (TxtCountBook.Text == "")
            {
                TxtCountBook.Text = "Sayı";
                TxtCountBook.ForeColor = Color.Silver;
            }
        }

        private void TxtSearchBooks_Enter(object sender, EventArgs e)
        {
            if (TxtSearchBooks.Text == "Axtarış edin...")
            {
                TxtSearchBooks.Text = "";
                TxtSearchBooks.ForeColor = Color.Black;
                PnlFilterBooks.Enabled = false;
            }
        }

        private void TxtSearchBooks_Leave(object sender, EventArgs e)
        {
            if (TxtSearchBooks.Text == "")
            {
                TxtSearchBooks.Text = "Axtarış edin...";
                TxtSearchBooks.ForeColor = Color.Silver;
                PnlFilterBooks.Enabled = true;
            }
        }

        //Customers Textboxs Placeholder
        private void TxtNameCustomer_Enter(object sender, EventArgs e)
        {
            if (TxtNameCustomer.Text == "Müştərinin adı")
            {
                TxtNameCustomer.Text = "";
                TxtNameCustomer.ForeColor = Color.Black;
            }
        }

        private void TxtNameCustomer_Leave(object sender, EventArgs e)
        {
            if (TxtNameCustomer.Text == "")
            {
                TxtNameCustomer.Text = "Müştərinin adı";
                TxtNameCustomer.ForeColor = Color.Silver;
            }
        }

        private void TxtSurnameCustomer_Enter(object sender, EventArgs e)
        {
            if (TxtSurnameCustomer.Text == "Soyadı")
            {
                TxtSurnameCustomer.Text = "";
                TxtSurnameCustomer.ForeColor = Color.Black;
            }

        }

        private void TxtSurnameCustomer_Leave(object sender, EventArgs e)
        {
            if (TxtSurnameCustomer.Text == "")
            {
                TxtSurnameCustomer.Text = "Soyadı";
                TxtSurnameCustomer.ForeColor = Color.Silver;
            }

        }

        private void TxtPhoneNumberCustomer_Enter(object sender, EventArgs e)
        {
            if (TxtPhoneNumberCustomer.Text == "Tel: 0501234567")
            {
                TxtPhoneNumberCustomer.Text = "";
                TxtPhoneNumberCustomer.ForeColor = Color.Black;
            }

        }

        private void TxtPhoneNumberCustomer_Leave(object sender, EventArgs e)
        {
            if (TxtPhoneNumberCustomer.Text == "")
            {
                TxtPhoneNumberCustomer.Text = "Tel: 0501234567";
                TxtPhoneNumberCustomer.ForeColor = Color.Silver;
            }

        }

        private void TxtSearchCustomers_Enter(object sender, EventArgs e)
        {
            if (TxtSearchCustomers.Text == "Axtarış edin...")
            {
                TxtSearchCustomers.Text = "";
                TxtSearchCustomers.ForeColor = Color.Black;
                PnlFilterCustomers.Enabled = false;
            }
        }

        private void TxtSearchCustomers_Leave_1(object sender, EventArgs e)
        {
            if (TxtSearchCustomers.Text == "")
            {
                TxtSearchCustomers.Text = "Axtarış edin...";
                TxtSearchCustomers.ForeColor = Color.Silver;
                PnlFilterCustomers.Enabled = true;
            }

        }


        //Managers Textboxs Placeholder

        private void TxtNameManager_Enter(object sender, EventArgs e)
        {
            if (TxtNameManager.Text == "İdarəçinin adı")
            {
                TxtNameManager.Text = "";
                TxtNameManager.ForeColor = Color.Black;
            }
        }

        private void TxtNameManager_Leave(object sender, EventArgs e)
        {
            if (TxtNameManager.Text == "")
            {
                TxtNameManager.Text = "İdarəçinin adı";
                TxtNameManager.ForeColor = Color.Silver;
            }
        }

        private void TxtSurnameManager_Enter(object sender, EventArgs e)
        {
            if (TxtSurnameManager.Text == "Soyadı")
            {
                TxtSurnameManager.Text = "";
                TxtSurnameManager.ForeColor = Color.Black;
            }
        }

        private void TxtSurnameManager_Leave(object sender, EventArgs e)
        {
            if (TxtSurnameManager.Text == "")
            {
                TxtSurnameManager.Text = "Soyadı";
                TxtSurnameManager.ForeColor = Color.Silver;
            }
        }
        private void TxtUsernameManager_Enter(object sender, EventArgs e)
        {
            if (TxtUsernameManager.Text == "İstifadəçi adı")
            {
                TxtUsernameManager.Text = "";
                TxtUsernameManager.ForeColor = Color.Black;
            }
        }

        private void TxtUsernameManager_Leave(object sender, EventArgs e)
        {
            if (TxtUsernameManager.Text == "")
            {
                TxtUsernameManager.Text = "İstifadəçi adı";
                TxtUsernameManager.ForeColor = Color.Silver;
            } 
        }
        private void TxtParolManager_Enter(object sender, EventArgs e)
        {
            if (TxtPasswordManager.Text == "Parol")
            {
                TxtPasswordManager.Text = "";
                TxtPasswordManager.ForeColor = Color.Black;
            }
        }

        private void TxtParolManager_Leave(object sender, EventArgs e)
        {
            if (TxtPasswordManager.Text == "")
            {
                TxtPasswordManager.Text = "Parol";
                TxtPasswordManager.ForeColor = Color.Silver;
            }
        }


        #endregion


        #region Customers

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            BtnOrders.BackColor = Color.FromArgb(230, 100, 0);
            BtnBooks.BackColor = Color.FromArgb(230, 100, 0);
            BtnCustomers.BackColor = Color.FromArgb(250, 130, 0);
            BtnManagers.BackColor = Color.FromArgb(230, 100, 0);

            CbbFilterCustomers.SelectedIndex = 0;
            CbbSortCustomers.SelectedIndex = 0;
            CbbSearchCustomers.SelectedIndex = 0;

            PnlOrders.Visible = false;
            PnlBooks.Visible = false;
            PnlCustomers.Visible = true;
            PnlManagers.Visible = false;
        }

        public Boolean ChechCustomerTextbox()
        {
            LblUnderNameCustomer.BackColor = Color.Orange;
            LblUnderSurnameCustomer.BackColor = Color.Orange;
            LblUnderPhoneNumberCustomer.BackColor = Color.Orange;
            LblUnderDateBirthCutomer.BackColor = Color.Orange;


            if (TxtNameCustomer.Text == "Müştərinin adı" || TxtSurnameCustomer.Text == "Soyadı" || TxtPhoneNumberCustomer.Text == "Tel: 0501234567")
            {

                if (TxtNameCustomer.Text == "Müştərinin adı")
                {
                    LblUnderNameCustomer.BackColor = Color.Maroon;
                }
                if (TxtSurnameCustomer.Text == "Soyadı")
                {
                    LblUnderSurnameCustomer.BackColor = Color.Maroon;
                }
                if (TxtPhoneNumberCustomer.Text == "Tel: 0501234567")
                {
                    LblUnderPhoneNumberCustomer.BackColor = Color.Maroon;
                }
                MessageBox.Show("Xanaları tam doldurun.");
                return false;
            }
            else if (TxtPhoneNumberCustomer.Text.Length != 10 || !uint.TryParse(TxtPhoneNumberCustomer.Text, out uint a))
            {
                MessageBox.Show("Telefon nömrəsini düzgün şəkildə qeyd edin. Meselen: 0501234567");
                LblUnderPhoneNumberCustomer.BackColor = Color.Maroon;
                TxtPhoneNumberCustomer.Text = "Tel: 0501234567";
                TxtPhoneNumberCustomer.ForeColor = Color.Silver;
                return false;
            }
            else if (DtpDateBirth.Value.ToString("dd-MM-yyyy") == "01-01-1950")
            {
                LblUnderDateBirthCutomer.BackColor = Color.Maroon;
                MessageBox.Show("Müştərinin doğum tarixini seçin.");
                return false;
            }

            return true;
        }

        public void ClearTextboxCustomer()
        {
            TxtNameCustomer.Text = "Müştərinin adı";
            TxtSurnameCustomer.Text = "Soyadı";
            TxtPhoneNumberCustomer.Text = "Tel: 0501234567";
            DtpDateBirth.Value = new DateTime(1950, 01, 01);

            TxtNameCustomer.ForeColor = Color.Silver;
            TxtSurnameCustomer.ForeColor = Color.Silver;
            TxtPhoneNumberCustomer.ForeColor = Color.Silver;

            LblUnderNameCustomer.BackColor = Color.Orange;
            LblUnderSurnameCustomer.BackColor = Color.Orange;
            LblUnderPhoneNumberCustomer.BackColor = Color.Orange;
            LblUnderDateBirthCutomer.BackColor = Color.Orange;
        }

        public void AllCustomers()
        {
            DgvCustomers.Rows.Clear();
            if(TxtSearchCustomers.Text!= "Axtarış edin..." && CbbSearchCustomers.SelectedIndex==0)
            {
                List<Customer> Customers = context.Customers.Where(o=>o.Name.StartsWith(TxtSearchCustomers.Text)).ToList();
                foreach (Customer customer in Customers)
                {
                    string status = "Passiv";
                    List<Order> orders = context.Orders.Where(o => o.CustomerId == customer.Id).ToList();
                    foreach (Order order in orders)
                    {
                        if (order.ReturnTime.ToString() == "")
                        {
                            status = "Aktiv";
                        }
                    }
                    DgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, customer.DateBirth.ToString("dd-MM-yyyy").Substring(0, 10), customer.CreateAt.ToString("dd-MM-yyyy").Substring(0, 10), status);
                }

            }
            else if (TxtSearchCustomers.Text != "Axtarış edin..." && CbbSearchCustomers.SelectedIndex == 1)
            {
                List<Customer> Customers = context.Customers.Where(o => o.Surname.StartsWith(TxtSearchCustomers.Text)).ToList();
                foreach (Customer customer in Customers)
                {
                    string status = "Passiv";
                    List<Order> orders = context.Orders.Where(o => o.CustomerId == customer.Id).ToList();
                    foreach (Order order in orders)
                    {
                        if (order.ReturnTime.ToString() == "")
                        {
                            status = "Aktiv";
                        }
                    }
                    DgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, customer.DateBirth.ToString("dd-MM-yyyy").Substring(0, 10), customer.CreateAt.ToString("dd-MM-yyyy").Substring(0, 10), status);
                }

            }
            else if (CbbFilterCustomers.SelectedIndex == 0)
            {
                List<Customer> Customers = context.Customers.OrderBy(o=>o.Name).ToList();
                foreach (Customer customer in Customers)
                {
                    string status = "Passiv";
                    List<Order> orders = context.Orders.Where(o => o.CustomerId == customer.Id).ToList();
                    foreach (Order order in orders)
                    {
                        if (order.ReturnTime.ToString() == "")
                        {
                            status = "Aktiv";
                        }
                    }
                    DgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, customer.DateBirth.ToString("dd-MM-yyyy").Substring(0, 10), customer.CreateAt.ToString("dd-MM-yyyy").Substring(0, 10), status);
                }
            }
            else if (CbbFilterCustomers.SelectedIndex == 1)
            {
                List<Customer> Customers = context.Customers.ToList();
                if (CbbSortCustomers.SelectedIndex == 1)
                {
                    Customers = context.Customers.OrderBy(c => c.Name).ToList();
                }
                foreach (Customer customer in Customers)
                {
                    List<Order> orders = context.Orders.Where(o => o.CustomerId == customer.Id).ToList();
                    foreach (Order order in orders)
                    {
                        if (order.ReturnTime.ToString() == "")
                        {
                            DgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, customer.DateBirth.ToString("dd-MM-yyyy").Substring(0, 10), customer.CreateAt.ToString("dd-MM-yyyy").Substring(0, 10), "Aktiv");
                        }
                    }
                }
            }
            else if (CbbFilterCustomers.SelectedIndex == 2)
            {
                List<Customer> Customers = context.Customers.ToList();
                if (CbbSortCustomers.SelectedIndex == 1)
                {
                    Customers = context.Customers.OrderBy(c => c.Name).ToList();
                }
                foreach (Customer customer in Customers)
                {
                    Boolean a = true;
                    List<Order> orders = context.Orders.Where(o => o.CustomerId == customer.Id).ToList();
                    foreach (Order order in orders)
                    {
                        if (order.ReturnTime.ToString() == "")
                        {
                            a = false;
                        }
                    }
                    if (a)
                    {
                        DgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, customer.DateBirth.ToString("dd-MM-yyyy").Substring(0, 10), customer.CreateAt.ToString("dd-MM-yyyy").Substring(0, 10), "Passiv");
                    }

                }
            }
        }

        private void CbbSortCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllCustomers();
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!ChechCustomerTextbox())
            {
                return;
            }
            Customer customer = new Customer
            {
                Name = TxtNameCustomer.Text,
                Surname = TxtSurnameCustomer.Text,
                PhoneNumber = TxtPhoneNumberCustomer.Text,
                DateBirth = DtpDateBirth.Value,
                CreateAt = DateTime.Now
            };
            context.Customers.Add(customer);
            context.SaveChanges();
            AllCustomers();
            MessageBox.Show("Müştəri əlavə olundu");
            ClearTextboxCustomer();
        }

        private void DgvCustomers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LblUnderNameCustomer.BackColor = Color.Orange;
            LblUnderSurnameCustomer.BackColor = Color.Orange;
            LblUnderPhoneNumberCustomer.BackColor = Color.Orange;
            LblUnderDateBirthCutomer.BackColor = Color.Orange;

            int IdCustomer = Convert.ToInt32(DgvCustomers.Rows[e.RowIndex].Cells[0].Value);
            selectedCustomer = context.Customers.Find(IdCustomer);

            TxtNameCustomer.Text = selectedCustomer.Name;
            TxtSurnameCustomer.Text = selectedCustomer.Surname;
            TxtPhoneNumberCustomer.Text = selectedCustomer.PhoneNumber;
            DtpDateBirth.Value = selectedCustomer.DateBirth;

            TxtNameCustomer.ForeColor = Color.Black;
            TxtSurnameCustomer.ForeColor = Color.Black;
            TxtPhoneNumberCustomer.ForeColor = Color.Black;

            BtnAddCustomer.Visible = false;
            BtnUpdateCustomer.Visible = true;
            BtnDeleteCustomer.Visible = true;
        }


        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (!ChechCustomerTextbox())
            {
                return;
            }
            selectedCustomer.Name = TxtNameCustomer.Text;
            selectedCustomer.Surname = TxtSurnameCustomer.Text;
            selectedCustomer.PhoneNumber = TxtPhoneNumberCustomer.Text;
            selectedCustomer.DateBirth = DtpDateBirth.Value;
            context.SaveChanges();

            AllCustomers();
            ClearTextboxCustomer();
            MessageBox.Show("Müştəri Məlumatları yeniləndi");

            BtnAddCustomer.Visible = true;
            BtnUpdateCustomer.Visible = false;
            BtnDeleteCustomer.Visible = false;


        }

        private void BtnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Müştəriyə aid bütün məlumatlar silinəcək. Silinsin?", "Müştəri məlumatlarının silinməsi", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                return;
            }

            context.Customers.Remove(selectedCustomer);
            context.SaveChanges();
            AllCustomers();
            ClearTextboxCustomer();
            BtnAddCustomer.Visible = true;
            BtnUpdateCustomer.Visible = false;
            BtnDeleteCustomer.Visible = false;
            MessageBox.Show("Müştəri Məlumatları silindi");

        }


        #endregion

        private void BtnManagers_Click(object sender, EventArgs e)
        {
            BtnOrders.BackColor = Color.FromArgb(230, 100, 0);
            BtnBooks.BackColor = Color.FromArgb(230, 100, 0);
            BtnCustomers.BackColor = Color.FromArgb(230, 100, 0);
            BtnManagers.BackColor = Color.FromArgb(250, 130, 0);

            PnlOrders.Visible = false;
            PnlBooks.Visible = false;
            PnlCustomers.Visible = false;
            PnlManagers.Visible = true;

            AllManagers();
        }

        public void AllManagers()
        {
            DgvManagers.Rows.Clear();
            List<Manager> managers = context.Managers.ToList();
            foreach (Manager manager in managers)
            {
                DgvManagers.Rows.Add(manager.Id, manager.Name, manager.Surname, manager.Username, manager.Password);
            }
        }

        public Boolean CheckManagerTextbox()
        {
            LblUnderNameManager.BackColor = Color.Orange;
            LblUnderSurnameManager.BackColor = Color.Orange;
            LblUnderUsernameManager.BackColor = Color.Orange;
            LblUnderPasswordManager.BackColor = Color.Orange;

            if (TxtNameManager.Text == "İdarəçinin adı" || TxtSurnameManager.Text == "Soyadı"|| TxtUsernameManager.Text == "İstifadəçi adı"|| TxtPasswordManager.Text == "Parol")
            {
                if (TxtNameManager.Text == "İdarəçinin adı")
                {
                    LblUnderNameManager.BackColor = Color.Maroon;
                }
                if (TxtSurnameManager.Text == "Soyadı")
                {
                    LblUnderSurnameManager.BackColor = Color.Maroon;
                }
                if (TxtUsernameManager.Text == "İstifadəçi adı")
                {
                    LblUnderUsernameManager.BackColor = Color.Maroon;
                }
                if (TxtPasswordManager.Text == "Parol")
                {
                    LblUnderPasswordManager.BackColor = Color.Maroon;
                }
                    MessageBox.Show("Xalanarı düzgün doldurun!");
                    return false;
            }   else if(TxtUsernameManager.Text.Contains(" "))
            {
                LblUnderUsernameManager.BackColor = Color.Maroon;
                MessageBox.Show("İstifadəçi adında boşluq buraxıla bilməz.");
                return false;
            } else if (!TxtUsernameManager.Text.Contains("@"))
            {
                LblUnderUsernameManager.BackColor = Color.Maroon;
                MessageBox.Show("İstifadəçi adındı düzgün yazın. Misal: code.academy@gmail.com");
                return false;
            } else if (!TxtUsernameManager.Text.Substring(TxtUsernameManager.Text.LastIndexOf('@')+1).Contains(".")||TxtUsernameManager.Text.EndsWith("."))
            {
                LblUnderUsernameManager.BackColor = Color.Maroon;
                MessageBox.Show("İstifadəçi adındı düzgün yazın. Misal: code.academy@gmail.com");
                return false;
            } else if (TxtPasswordManager.Text.Length<8)
            {
                LblUnderPasswordManager.BackColor = Color.Maroon;
                MessageBox.Show("Parol minimum 8 xarekterdən ibarət olmaləıdır.");
                return false;
            }else if (TxtPasswordManager.Text.Contains(" "))
            {
                LblUnderPasswordManager.BackColor = Color.Maroon;
                MessageBox.Show("Parolda boşluq buraxmayın");
                return false;
            }
            return true;            
        }

        public void ClearTextboxManager()
        {
            TxtNameManager.Text = "İdarəçinin adı";
            TxtSurnameManager.Text = "Soyadı";
            TxtUsernameManager.Text = "İstifadəçi adı";
            TxtPasswordManager.Text = "Parol";

            TxtNameManager.ForeColor = Color.Silver;
            TxtSurnameManager.ForeColor = Color.Silver;
            TxtUsernameManager.ForeColor = Color.Silver;
            TxtPasswordManager.ForeColor = Color.Silver;

        }

        private void BtnAddManager_Click(object sender, EventArgs e)
        {
            if (!CheckManagerTextbox())
            {
                return;
            }

            Manager manager = new Manager
            {
                Name = TxtNameManager.Text,
                Surname = TxtSurnameManager.Text,
                Username = TxtUsernameManager.Text,
                Password = TxtPasswordManager.Text
            };
            context.Managers.Add(manager);
            context.SaveChanges();

            AllManagers();

        }

        private void DgvManagers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnAddManager.Visible = false;
            BtnUpdateManager.Visible = true;
            BtnDeleteManager.Visible = true;
            int IdManager = Convert.ToInt32(DgvManagers.Rows[e.RowIndex].Cells[0].Value);
            selectedManager = context.Managers.Find(IdManager);
            TxtNameManager.Text = selectedManager.Name;
            TxtSurnameManager.Text = selectedManager.Surname;
            TxtUsernameManager.Text = selectedManager.Username;
            TxtPasswordManager.Text = selectedManager.Password;

            TxtNameManager.ForeColor = Color.Black;
            TxtSurnameManager.ForeColor = Color.Black;
            TxtUsernameManager.ForeColor = Color.Black;
            TxtPasswordManager.ForeColor = Color.Black;
        }

        private void BtnUpdateManager_Click(object sender, EventArgs e)
        {
            if (!CheckManagerTextbox())
            {
                return;
            }
            selectedManager.Name = TxtNameManager.Text;
            selectedManager.Surname = TxtSurnameManager.Text;
            selectedManager.Username = TxtUsernameManager.Text;
            selectedManager.Password = TxtPasswordManager.Text;
            context.SaveChanges();
            AllManagers();
            ClearTextboxManager();
            MessageBox.Show("İdarəçi məlumatı yeniləndi.");


        }

        private void BtnDeleteManager_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("İdarəçiyə aid bütün məlumatlar silinəcək. Silinsin?", "İdarəçiyə məlumatlarının silinməsi", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                return;
            }
            MessageBox.Show("İdarəçi məlumatları silindi.");
            context.Managers.Remove(selectedManager);
            context.SaveChanges();
            AllManagers();
            ClearTextboxManager();
        }

        private void TxtSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            AllCustomers();
        }

    }
}