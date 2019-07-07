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
using ClosedXML.Excel;
using System.IO;

namespace LibraryApp.Forms
{
    public partial class MeanForm : Form
    {
        private LibraryAppContext context;
        private Book selectedBook;
        private Customer selectedCustomer;
        private Manager selectedManager;
        private Customer selectedCustomerinOrder;
        private Book selectedBookinOrder;
        int selectedCustomerIdinReturn;
        List<int> ReturnBook = new List<int>();
        int selectedBookIdforReturn;



        public MeanForm()
        {
            context = new LibraryAppContext();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }


        private void BtnOrders_Click(object sender, EventArgs e)
        {
            BtnOrders.BackColor = Color.FromArgb(250, 130, 0);
            BtnBooks.BackColor = Color.FromArgb(230, 100, 0);
            BtnCustomers.BackColor = Color.FromArgb(230, 100, 0);
            BtnManagers.BackColor = Color.FromArgb(230, 100, 0);
            BtnReport.BackColor = Color.FromArgb(230, 100, 0);


            TabOrders.Visible = true;
            PnlOrders.Visible = true;
            PnlBooks.Visible = false;
            PnlCustomers.Visible = false;
            PnlManagers.Visible = false;
            PnlReport.Visible = false;

            ClearNewOrderForm();

        }

        private void MeanForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MeanForm_Load(object sender, EventArgs e)
        {
            CbbSearchBookandCustomer.SelectedIndex = 0;
            BtnOrders.BackColor = Color.FromArgb(250, 130, 0);
            AllCustomerInOrders();
            AllBookInOrders();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddMonths(2);
        }



        #region Books
        private void BtnBooks_Click(object sender, EventArgs e)
        {
            BtnOrders.BackColor = Color.FromArgb(230, 100, 0);
            BtnBooks.BackColor = Color.FromArgb(250, 130, 0);
            BtnCustomers.BackColor = Color.FromArgb(230, 100, 0);
            BtnManagers.BackColor = Color.FromArgb(230, 100, 0);
            BtnReport.BackColor = Color.FromArgb(230, 100, 0);


            CbbFilterBooks.SelectedIndex = 0;
            CbbSortBooks.SelectedIndex = 1;
            CbbSearchBooks.SelectedIndex = 0;

            PnlOrders.Visible = false;
            PnlBooks.Visible = true;
            PnlCustomers.Visible = false;
            PnlManagers.Visible = false;
            AllBooks();
            ClearTexboxtBooks();
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
            if (TxtSearchBooks.Text != "Axtarış edin..." && CbbSearchBooks.SelectedIndex == 0)
            {
                List<Book> books = context.Books.Where(b => b.Name.StartsWith(TxtSearchBooks.Text)).ToList();
                foreach (Book book in books)
                {
                    int rentCount = 0;
                    List<OrderItem> orderItems = context.OrderItems.Where(o => o.BookId == book.Id).ToList();
                    foreach (OrderItem orderItem in orderItems)
                    {
                        if (orderItem.ReturnTime.ToString() == "")
                        {
                            rentCount++;
                        }
                    }
                    DgvBooks.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, book.Count, book.Count - rentCount + " kitab", rentCount + " kitab");
                }
            }
            else if (TxtSearchBooks.Text != "Axtarış edin..." && CbbSearchBooks.SelectedIndex == 1)
            {
                List<Book> books = context.Books.Where(b => b.Writter.StartsWith(TxtSearchBooks.Text)).ToList();
                foreach (Book book in books)
                {
                    int rentCount = 0;
                    List<OrderItem> orderItems = context.OrderItems.Where(o => o.BookId == book.Id).ToList();
                    foreach (OrderItem orderItem in orderItems)
                    {
                        if (orderItem.ReturnTime.ToString() == "")
                        {
                            rentCount++;
                        }
                    }
                    DgvBooks.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, book.Count, book.Count - rentCount + " kitab", rentCount + " kitab");
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
                    int rentCount = 0;
                    List<OrderItem> orderItems = context.OrderItems.Where(o => o.BookId == book.Id).ToList();
                    foreach (OrderItem orderItem in orderItems)
                    {
                        if (orderItem.ReturnTime.ToString() == "")
                        {
                            rentCount++;
                        }
                    }
                    DgvBooks.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, book.Count, book.Count - rentCount + " kitab", rentCount + " kitab");
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
                    int rentCount = 0;
                    List<OrderItem> orderItems = context.OrderItems.Where(o => o.BookId == book.Id && o.ReturnTime.ToString() == "").ToList();
                    if (book.Count - orderItems.Count != 0)
                    {
                        DgvBooks.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, book.Count, book.Count - orderItems.Count + " kitab", orderItems.Count + " kitab");
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
                    int rentCount = 0;
                    List<OrderItem> orderItems = context.OrderItems.Where(o => o.BookId == book.Id && o.ReturnTime.ToString() == "").ToList();
                    if (orderItems.Count > 0)
                    {
                        DgvBooks.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, book.Count, book.Count - orderItems.Count + " kitab", orderItems.Count + " kitab");
                    }
                }
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            AllBooks();
        }

        private void CbbSearchBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllBooks();
            CbbFilterBooks.SelectedIndex = 0;
            CbbSortBooks.SelectedIndex = 0;

        }

        private void DgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (DgvBooks.Rows[e.RowIndex].DefaultCellStyle.ForeColor == Color.Empty)
            {
                DgvBooks.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(250, 130, 0);
                DgvBooks.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            foreach (DataGridViewRow row in DgvBooks.Rows)
            {
                if (row.Index != e.RowIndex)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Empty;
                }
            }

            LblUnderlineNameBook.BackColor = Color.Orange;
            LblUnderlineWritterBook.BackColor = Color.Orange;
            LblUnderlinePriceBook.BackColor = Color.Orange;
            LblUnderlineCountBook.BackColor = Color.Orange;

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
            CbbSearchBooks.SelectedIndex = 0;
            TxtSearchBooks.Text = "Axtarış edin...";
            TxtSearchBooks.ForeColor = Color.Silver;

        }

        #endregion


        #region Methots for Button's Placeholder

        private void TxtSeacrhBookandCustomer_Enter(object sender, EventArgs e)
        {
            if (TxtSeacrhBookandCustomer.Text == "Müştəri axtar..." || TxtSeacrhBookandCustomer.Text == "Kitab axtar...")
            {
                TxtSeacrhBookandCustomer.Text = "";
                TxtSeacrhBookandCustomer.ForeColor = Color.Black;
            }
        }
        private void TxtSeacrhBookandCustomer_Leave(object sender, EventArgs e)
        {
            if (TxtSeacrhBookandCustomer.Text == "")
            {
                TxtSeacrhBookandCustomer.ForeColor = Color.Silver;
                if (CbbSearchBookandCustomer.SelectedIndex == 0)
                {
                    TxtSeacrhBookandCustomer.Text = "Müştəri axtar...";
                }
                else if (CbbSearchBookandCustomer.SelectedIndex == 1)
                {
                    TxtSeacrhBookandCustomer.Text = "Kitab axtar...";
                }
            }
        }

        private void TxtCountOrderBook_Enter(object sender, EventArgs e)
        {
            if (TxtCountOrderBook.Text == "Sayı")
            {
                TxtCountOrderBook.Text = "";
                TxtCountOrderBook.ForeColor = Color.Black;
            }
        }

        private void TxtCountOrderBook_Leave(object sender, EventArgs e)
        {
            if (TxtCountOrderBook.Text == "")
            {
                TxtCountOrderBook.Text = "Sayı";
                TxtCountOrderBook.ForeColor = Color.Silver;
            }
        }

        private void TxtSeacrhCustomerinRetornBook_Enter(object sender, EventArgs e)
        {
            if (TxtSearchBookAndCustomerinRetornBook.Text == "Müştəri axtar...")
            {
                TxtSearchBookAndCustomerinRetornBook.Text = "";
                TxtSearchBookAndCustomerinRetornBook.ForeColor = Color.Black;
            }
        }

        private void TxtSeacrhCustomerinRetornBook_Leave(object sender, EventArgs e)
        {
            if (TxtSearchBookAndCustomerinRetornBook.Text == "")
            {
                TxtSearchBookAndCustomerinRetornBook.Text = "Müştəri axtar...";
                TxtSearchBookAndCustomerinRetornBook.ForeColor = Color.Silver;
            }
        }


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
            CbbFilterBooks.SelectedIndex = 0;
            CbbSortBooks.SelectedIndex = 0;

            if (TxtSearchBooks.Text == "Axtarış edin...")
            {
                TxtSearchBooks.Text = "";
                TxtSearchBooks.ForeColor = Color.Black;
            }
        }

        private void TxtSearchBooks_Leave(object sender, EventArgs e)
        {
            if (TxtSearchBooks.Text == "")
            {
                TxtSearchBooks.Text = "Axtarış edin...";
                TxtSearchBooks.ForeColor = Color.Silver;
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
            CbbFilterCustomers.SelectedIndex = 0;
            CbbSortCustomers.SelectedIndex = 0;
            if (TxtSearchCustomers.Text == "Axtarış edin...")
            {
                TxtSearchCustomers.Text = "";
                TxtSearchCustomers.ForeColor = Color.Black;
                PnlFilterCustomers.Enabled = true;
            }
        }

        private void TxtSearchCustomers_Leave_1(object sender, EventArgs e)
        {
            if (TxtSearchCustomers.Text == "")
            {
                TxtSearchCustomers.Text = "Axtarış edin...";
                TxtSearchCustomers.ForeColor = Color.Silver;
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
            BtnReport.BackColor = Color.FromArgb(230, 100, 0);


            CbbFilterCustomers.SelectedIndex = 0;
            CbbSortCustomers.SelectedIndex = 0;
            CbbSearchCustomers.SelectedIndex = 0;

            PnlOrders.Visible = false;
            PnlBooks.Visible = false;
            PnlCustomers.Visible = true;
            PnlManagers.Visible = false;
            AllCustomers();
            ClearTextboxCustomer();
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
            else if (TxtPhoneNumberCustomer.Text.Length != 10 || !uint.TryParse(TxtPhoneNumberCustomer.Text, out uint a)|| TxtPhoneNumberCustomer.Text.StartsWith("00"))
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
            List<Customer> customers = context.Customers.Where(c => c.PhoneNumber == TxtPhoneNumberCustomer.Text).ToList();
            if (customers.Count > 0)
            {
                LblUnderDateBirthCutomer.BackColor = Color.Maroon;
                MessageBox.Show("Bu telefon nömrəsi artıq qeydiyyatdan keçib");
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
            if (TxtSearchCustomers.Text != "Axtarış edin..." && CbbSearchCustomers.SelectedIndex == 0)
            {
                List<Customer> Customers = context.Customers.Where(o => o.Name.StartsWith(TxtSearchCustomers.Text)).ToList();
                foreach (Customer customer in Customers)
                {
                    int BookCount = 0;
                    List<Order> Orders = context.Orders.Include("OrderItems").Where(o => o.CustomerId == customer.Id).ToList();
                    foreach (Order order in Orders)
                    {
                        foreach (OrderItem orderItem in order.OrderItems)
                        {
                            if (orderItem.ReturnTime.ToString() == "")
                            {
                                BookCount++;
                            }
                        }
                    }
                    DgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, customer.DateBirth.ToString("dd-MM-yyyy").Substring(0, 10), customer.CreateAt.ToString("dd-MM-yyyy").Substring(0, 10), BookCount + " kitab");
                }

            }
            else if (TxtSearchCustomers.Text != "Axtarış edin..." && CbbSearchCustomers.SelectedIndex == 1)
            {
                List<Customer> Customers = context.Customers.Where(o => o.Surname.StartsWith(TxtSearchCustomers.Text)).ToList();
                foreach (Customer customer in Customers)
                {
                    int BookCount = 0;
                    List<Order> Orders = context.Orders.Include("OrderItems").Where(o => o.CustomerId == customer.Id).ToList();
                    foreach (Order order in Orders)
                    {
                        foreach (OrderItem orderItem in order.OrderItems)
                        {
                            if (orderItem.ReturnTime.ToString() == "")
                            {
                                BookCount++;
                            }
                        }
                    }
                    DgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, customer.DateBirth.ToString("dd-MM-yyyy").Substring(0, 10), customer.CreateAt.ToString("dd-MM-yyyy").Substring(0, 10), BookCount + " kitab");
                }

            }
            else if (CbbFilterCustomers.SelectedIndex == 0)
            {
                List<Customer> Customers = context.Customers.ToList();
                if (CbbSortCustomers.SelectedIndex == 1)
                {
                    Customers = context.Customers.OrderBy(c => c.Name).ToList();
                }
                foreach (Customer customer in Customers)
                {
                    int BookCount = 0;
                    List<Order> Orders = context.Orders.Include("OrderItems").Where(o => o.CustomerId == customer.Id).ToList();
                    foreach (Order order in Orders)
                    {
                        foreach (OrderItem orderItem in order.OrderItems)
                        {
                            if (orderItem.ReturnTime.ToString() == "")
                            {
                                BookCount++;
                            }
                        }
                    }
                    DgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, customer.DateBirth.ToString("dd-MM-yyyy").Substring(0, 10), customer.CreateAt.ToString("dd-MM-yyyy").Substring(0, 10), BookCount + " kitab");
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
                    int BookCount = 0;
                    List<Order> Orders = context.Orders.Include("OrderItems").Where(o => o.CustomerId == customer.Id).ToList();
                    foreach (Order order in Orders)
                    {
                        foreach (OrderItem orderItem in order.OrderItems)
                        {
                            if (orderItem.ReturnTime.ToString() == "")
                            {
                                BookCount++;
                            }
                        }
                    }
                    if (BookCount > 0)
                    {
                        DgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, customer.DateBirth.ToString("dd-MM-yyyy").Substring(0, 10), customer.CreateAt.ToString("dd-MM-yyyy").Substring(0, 10), BookCount + " kitab");
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
                    int BookCount = 0;
                    List<Order> Orders = context.Orders.Include("OrderItems").Where(o => o.CustomerId == customer.Id).ToList();
                    foreach (Order order in Orders)
                    {
                        foreach (OrderItem orderItem in order.OrderItems)
                        {
                            if (orderItem.ReturnTime.ToString() == "")
                            {
                                BookCount++;
                            }
                        }
                    }
                    if (BookCount == 0)
                    {
                        DgvCustomers.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, customer.DateBirth.ToString("dd-MM-yyyy").Substring(0, 10), customer.CreateAt.ToString("dd-MM-yyyy").Substring(0, 10), BookCount + " kitab");
                    }
                }
            }
        }

        private void CbbSortCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllCustomers();
            TxtSearchCustomers.Text = "Axtarış edin...";
            TxtSearchCustomers.ForeColor = Color.Silver;
            CbbSearchCustomers.SelectedIndex = 0;
        }

        private void DgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (DgvCustomers.Rows[e.RowIndex].DefaultCellStyle.ForeColor == Color.Empty)
            {
                DgvCustomers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(250, 130, 0);
                DgvCustomers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            foreach (DataGridViewRow row in DgvCustomers.Rows)
            {
                if (row.Index != e.RowIndex)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Empty;
                }
            }

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

        private void TxtSearchCustomers_TextChanged(object sender, EventArgs e)
        {
            AllCustomers();
        }

        private void CbbSearchCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbbFilterCustomers.SelectedIndex = 0;
            CbbSortCustomers.SelectedIndex = 0;
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


        #region Managers
        private void BtnManagers_Click(object sender, EventArgs e)
        {
            BtnOrders.BackColor = Color.FromArgb(230, 100, 0);
            BtnBooks.BackColor = Color.FromArgb(230, 100, 0);
            BtnCustomers.BackColor = Color.FromArgb(230, 100, 0);
            BtnManagers.BackColor = Color.FromArgb(250, 130, 0);
            BtnReport.BackColor = Color.FromArgb(230, 100, 0);


            PnlOrders.Visible = false;
            PnlBooks.Visible = false;
            PnlCustomers.Visible = false;
            PnlManagers.Visible = true;
            PnlReport.Visible = false;

            AllManagers();
            ClearTextboxManager();
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
            List<Manager> Manager = context.Managers.Where(c => c.Username == TxtUsernameManager.Text).ToList();
            if (TxtNameManager.Text == "İdarəçinin adı" || TxtSurnameManager.Text == "Soyadı" || TxtUsernameManager.Text == "İstifadəçi adı" || TxtPasswordManager.Text == "Parol")
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
            }
            else if (TxtUsernameManager.Text.Contains(" "))
            {
                LblUnderUsernameManager.BackColor = Color.Maroon;
                MessageBox.Show("İstifadəçi adında boşluq buraxıla bilməz.");
                return false;
            }
            else if (!TxtUsernameManager.Text.Contains("@"))
            {
                LblUnderUsernameManager.BackColor = Color.Maroon;
                MessageBox.Show("İstifadəçi adındı düzgün yazın. Misal: code.academy@gmail.com");
                return false;
            }
            else if (!TxtUsernameManager.Text.Substring(TxtUsernameManager.Text.LastIndexOf('@') + 1).Contains(".") || TxtUsernameManager.Text.EndsWith("."))
            {
                LblUnderUsernameManager.BackColor = Color.Maroon;
                MessageBox.Show("İstifadəçi adındı düzgün yazın. Misal: code.academy@gmail.com");
                return false;
            }
            else if (Manager.Count != 0)
            {
                LblUnderUsernameManager.BackColor = Color.Maroon;
                MessageBox.Show("Bu istifadəşi adı artıq qeydiyyatdan keçib");
                return false;
            }
            else if (TxtPasswordManager.Text.Length < 8)
            {
                LblUnderPasswordManager.BackColor = Color.Maroon;
                MessageBox.Show("Parol minimum 8 xarekterdən ibarət olmaləıdır.");
                return false;
            }
            else if (TxtPasswordManager.Text.Contains(" "))
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

            LblUnderNameManager.BackColor = Color.Orange;
            LblUnderSurnameManager.BackColor = Color.Orange;
            LblUnderUsernameManager.BackColor = Color.Orange;
            LblUnderPasswordManager.BackColor = Color.Orange;
        }

        private void DgvManagers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (DgvManagers.Rows[e.RowIndex].DefaultCellStyle.ForeColor == Color.Empty)
            {
                DgvManagers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(250, 130, 0);
                DgvManagers.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            foreach (DataGridViewRow row in DgvManagers.Rows)
            {
                if (row.Index != e.RowIndex)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Empty;
                }
            }

            LblUnderNameManager.BackColor = Color.Orange;
            LblUnderSurnameManager.BackColor = Color.Orange;
            LblUnderUsernameManager.BackColor = Color.Orange;
            LblUnderPasswordManager.BackColor = Color.Orange;

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
            MessageBox.Show("İdarəçi əlavə olundu.");

            ClearTextboxManager();
            AllManagers();

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

            BtnAddManager.Visible = true;
            BtnUpdateManager.Visible = false;
            BtnDeleteManager.Visible = false;

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

            BtnAddManager.Visible = true;
            BtnUpdateManager.Visible = false;
            BtnDeleteManager.Visible = false;
        }

        #endregion


        #region New Order
        public void AllCustomerInOrders()
        {
            DgvCustomersInOrder.Rows.Clear();
            List<Customer> customers = context.Customers.ToList();
            if (TxtSeacrhBookandCustomer.Text != "Müştəri axtar...")
            {
                customers = context.Customers.Where(c => c.Name.StartsWith(TxtSeacrhBookandCustomer.Text)).ToList();
            }
            foreach (Customer customer in customers)
            {
                int count = 0;
                List<Order> orders = context.Orders.Include("OrderItems").Where(o => o.CustomerId == customer.Id).ToList();
                foreach (Order order in orders)
                {
                    foreach (OrderItem orderItem in order.OrderItems)
                    {
                        if (orderItem.ReturnTime.ToString() == "")
                        {
                            count++;
                        }
                    }
                }
                DgvCustomersInOrder.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, count + " kitab");
            }
        }

        public void AllBookInOrders()
        {
            DgvBooksInOrder.Rows.Clear();
            List<Book> books = context.Books.ToList();
            if (TxtSeacrhBookandCustomer.Text != "Kitab axtar...")
            {
                books = context.Books.Where(b => b.Name.StartsWith(TxtSeacrhBookandCustomer.Text)).ToList();
            }
            foreach (Book book in books)
            {
                List<OrderItem> orderItems = context.OrderItems.Where(o => o.BookId == book.Id && o.ReturnTime.ToString() == "").ToList();
                decimal ammountBook = 0;
                int countOrderBooks = 0;
                int countBook = book.Count - orderItems.Count;
                foreach (DataGridViewRow row in DgvSelectedBooks.Rows)
                {
                    countOrderBooks += Convert.ToInt32(row.Cells[2].Value.ToString().Substring(0, row.Cells[2].Value.ToString().Length - 6));
                    ammountBook += Convert.ToDecimal(row.Cells[3].Value.ToString().Substring(0, row.Cells[3].Value.ToString().Length - 3));
                    LblTotalAmmount.Text = ammountBook + "  AZN";
                    LblCountBook.Text = countOrderBooks + " kitab";
                    if (PnlTotalOrder.Location.Y < 200)
                    {
                        PnlTotalOrder.Location = new Point(4, DgvSelectedBooks.Rows.Count * 40 + 40);
                    }
                    if (book.Id == Convert.ToInt32(row.Cells[0].Value))
                    {
                        countBook -= Convert.ToInt32(TxtCountOrderBook.Text);
                    }
                }
                if (countBook > 0)
                {
                    DgvBooksInOrder.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice, countBook);
                }
            }
        }

        public void OrderSystem()
        {
            if (CbbSearchBookandCustomer.SelectedIndex == 0)
            {
                TxtSeacrhBookandCustomer.Text = "Müştəri axtar...";
                DgvCustomersInOrder.Visible = true;
                DgvBooksInOrder.Visible = false;
                AllCustomerInOrders();
            }
            else if (CbbSearchBookandCustomer.SelectedIndex == 1)
            {
                TxtSeacrhBookandCustomer.Text = "Kitab axtar...";
                DgvCustomersInOrder.Visible = false;
                DgvBooksInOrder.Visible = true;
                AllBookInOrders();
            }
            TxtSeacrhBookandCustomer.ForeColor = Color.Silver;
        }

        private void TxtSeacrhBookandCustomer_TextChanged(object sender, EventArgs e)
        {
            AllCustomerInOrders();
            AllBookInOrders();
        }

        private void CbbSearchBookandCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderSystem();
        }

        private void DgvCustomersInOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            BtnNextİnOrder.Visible = true;
            PnlSelectedCustomer.Visible = true;
            selectedCustomerinOrder = context.Customers.Find(DgvCustomersInOrder.Rows[e.RowIndex].Cells[0].Value);
            LblSelectedCustomer.Text = selectedCustomerinOrder.Name + " " + selectedCustomerinOrder.Surname;
            if (e.RowIndex == -1)
            {
                return;
            }
            if (DgvCustomersInOrder.Rows[e.RowIndex].DefaultCellStyle.ForeColor == Color.Empty)
            {
                DgvCustomersInOrder.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(250, 130, 0);
                DgvCustomersInOrder.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            foreach (DataGridViewRow row in DgvCustomersInOrder.Rows)
            {
                if (row.Index != e.RowIndex)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Empty;
                }
            }
        }

        private void DgvBooksInOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LblUnderCountOrderBook.BackColor = Color.Orange;
            LblUnderReturnBook.BackColor = Color.Orange;
            if (TxtCountOrderBook.Text == "Sayı" && dateTimePicker1.Value.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
            {
                LblUnderCountOrderBook.BackColor = Color.Maroon;
                LblUnderReturnBook.BackColor = Color.Maroon;
                MessageBox.Show("Xanaları doldurun.");
                return;
            }
            if (TxtCountOrderBook.Text == "Sayı")
            {
                LblUnderCountOrderBook.BackColor = Color.Maroon;
                MessageBox.Show("Kitabın sayını yazın.");
                return;

            }
            if (dateTimePicker1.Value.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
            {
                LblUnderReturnBook.BackColor = Color.Maroon;
                MessageBox.Show("Kitabın qaytarılma tarixini seçin.");
                LblUnderCountOrderBook.BackColor = Color.Orange; ;
                return;
            }
            selectedBookinOrder = context.Books.Find(DgvBooksInOrder.Rows[e.RowIndex].Cells[0].Value);
            if (uint.TryParse(TxtCountOrderBook.Text, out uint a))
            {
                if (Convert.ToInt16(TxtCountOrderBook.Text) > Convert.ToInt32(DgvBooksInOrder.Rows[e.RowIndex].Cells[4].Value))
                {
                    LblUnderCountOrderBook.BackColor = Color.Maroon;
                    MessageBox.Show("Bu kitabdan cəmi " + DgvBooksInOrder.Rows[e.RowIndex].Cells[4].Value.ToString() + " ədəd qalıb.");
                    return;
                }
                if (TxtCountOrderBook.Text == "0")
                {
                    LblUnderCountOrderBook.BackColor = Color.Maroon;
                    MessageBox.Show("Düzgün dəyər daxil edin.");
                    return;
                }
            }
            else
            {
                LblUnderCountOrderBook.BackColor = Color.Maroon;
                MessageBox.Show("Bu xanaya sadəcə rəqəm yaza bilərsiz.");
                return;
            }
            DgvSelectedBooks.Rows.Add(selectedBookinOrder.Id, selectedBookinOrder.Name, TxtCountOrderBook.Text + " kitab", Math.Round(selectedBookinOrder.MonthlyPrice * Convert.ToInt32(TxtCountOrderBook.Text) * (Convert.ToInt32((dateTimePicker1.Value - DateTime.Now).ToString("dd")) + 1) / 30, 2) + "  AZN", dateTimePicker1.Value.ToString("yyyy,MM,dd"));
            PnlSelectedBooks.Visible = true;
            AllBookInOrders();
            TxtCountOrderBook.Text = "Sayı";

            LblUnderReturnBook.BackColor = Color.Orange;
            TxtCountOrderBook.ForeColor = Color.Silver;
            BtnExitOrder.Visible = true;
            dateTimePicker1.Value = DateTime.Now;
            if (LblSelectedCustomer.Text != "")
            {
                BtnAddOrder.Visible = true;
            }
        }

        public void ClearNewOrderForm()
        {
            CbbSearchBookandCustomer.SelectedIndex = 0;
            DgvSelectedBooks.Rows.Clear();
            PnlSelectedCustomer.Visible = false;
            PnlSelectedBooks.Visible = false;
            PnlReturnTime.Visible = false;
            BtnAddOrderBook.Visible = false;
            BtnAddOrder.Visible = false;
            BtnExitOrder.Visible = false;
            LblUnderReturnBook.BackColor = Color.Orange;
            PnlTotalOrder.Location = new Point(5, 80);

            OrderSystem();

        }

        private void BtnExitOrder_Click(object sender, EventArgs e)
        {
            ClearNewOrderForm();
        }

        private void BtnNextİnOrder_Click(object sender, EventArgs e)
        {
            CbbSearchBookandCustomer.SelectedIndex = 1;
            BtnExitOrder.Visible = true;
            if (PnlReturnTime.Visible == true)
            {
                DgvSelectedBooks.Rows.Add(selectedBookinOrder.Id, selectedBookinOrder.Name, TxtCountOrderBook.Text + " kitab", Math.Round(selectedBookinOrder.MonthlyPrice * Convert.ToInt32(TxtCountOrderBook.Text) * (Convert.ToInt32((dateTimePicker1.Value - DateTime.Now).ToString("dd")) + 1) / 30, 2) + "  AZN", dateTimePicker1.Value.ToString("yyyy,MM,dd"));
                PnlSelectedBooks.Visible = true;
                AllBookInOrders();
                TxtCountOrderBook.Text = "Sayı";

                LblUnderReturnBook.BackColor = Color.Orange;
                TxtCountOrderBook.ForeColor = Color.Silver;
                BtnExitOrder.Visible = true;
                dateTimePicker1.Value = DateTime.Now;
                if (LblSelectedCustomer.Text != "")
                {
                    BtnAddOrder.Visible = true;
                }
            }
            BtnNextİnOrder.Visible = false;

        }

        private void DgvBooksInOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (DgvBooksInOrder.Rows[e.RowIndex].DefaultCellStyle.ForeColor == Color.Empty)
            {
                DgvBooksInOrder.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(250, 130, 0);
                DgvBooksInOrder.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            foreach (DataGridViewRow row in DgvBooksInOrder.Rows)
            {
                if (row.Index != e.RowIndex)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Empty;
                }
            }
            BtnAddOrderBook.Visible = true;
            PnlReturnTime.Visible = true;
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            BtnAddOrder.Visible = false;
            BtnExitOrder.Visible = false;
            Order order = new Order
            {
                Created = DateTime.Now,
                CustomerId = selectedCustomerinOrder.Id
            };
            context.Orders.Add(order);
            context.SaveChanges();
            foreach (DataGridViewRow row in DgvSelectedBooks.Rows)
            {

                string date = row.Cells[4].Value.ToString();
                for (int j = 0; j < Convert.ToInt32(row.Cells[2].Value.ToString().Substring(0, 1)); j++)
                {
                    OrderItem orderItem = new OrderItem
                    {
                        OrderId = order.Id,
                        BookId = Convert.ToInt32(row.Cells[0].Value),
                        EndRentTime = new DateTime(Convert.ToInt32(date.Substring(0, 4)), Convert.ToInt32(date.Substring(5, 2)), Convert.ToInt32(date.Substring(8, 2)))
                    };
                    context.OrderItems.Add(orderItem);
                    context.SaveChanges();
                }
            }
            MessageBox.Show("Sifariş tamamlandı.");
            PnlReturnTime.Visible = false;
            BtnAddOrderBook.Visible = false;
            ClearNewOrderForm();
            AllCustomerInReturn();

        }

        #endregion

        #region Return

        public void AllCustomerInReturn()
        {
            DgvCustomerinRetornBook.Rows.Clear();
            List<Customer> customers = context.Customers.ToList();
            if (TxtSearchBookAndCustomerinRetornBook.Text != "Müştəri axtar...")
            {
                customers = context.Customers.Where(c => c.Name.StartsWith(TxtSearchBookAndCustomerinRetornBook.Text)).ToList();
            }
            foreach (Customer customer in customers)
            {
                int count = 0;
                List<Order> orders = context.Orders.Include("OrderItems").Where(o => o.CustomerId == customer.Id).ToList();
                foreach (Order order in orders)
                {
                    foreach (OrderItem orderItem in order.OrderItems)
                    {
                        if (orderItem.ReturnTime.ToString() == "")
                        {
                            count++;
                        }
                    }
                }
                if (count > 0)
                {
                    DgvCustomerinRetornBook.Rows.Add(customer.Id, customer.Name, customer.Surname, customer.PhoneNumber, count + " kitab");
                }
            }
        }

        public void AllBookInRetorn()
        {
            DgvBookInRetorn.Rows.Clear();
            List<Book> books = context.Books.ToList();
            List<Order> orders = context.Orders.Include("OrderItems").Where(o => o.CustomerId == selectedCustomerIdinReturn).ToList();
            foreach (Order order in orders)
            {
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    if (orderItem.ReturnTime.ToString() == "")
                    {
                        Book book = context.Books.Find(orderItem.BookId);
                        decimal price = Math.Round(Convert.ToDecimal(DateTime.Now.Subtract(orderItem.EndRentTime).TotalDays) * Math.Round(book.MonthlyPrice*5/1000 / 30, 5), 2);
                        if (orderItem.EndRentTime > DateTime.Now)
                        {
                            price = 0;
                        }
                        DgvBookInRetorn.Rows.Add(book.Id, book.Name, book.Writter, order.Created.ToString("dd-MM-yyyy"), orderItem.EndRentTime.ToString("dd-MM-yyyy"), Math.Round(Convert.ToDecimal(DateTime.Now.Subtract(order.Created).TotalDays) * Math.Round(book.MonthlyPrice / 30, 2), 2), price, Math.Round(Convert.ToDecimal(DateTime.Now.Subtract(order.Created).TotalDays) * Math.Round(book.MonthlyPrice / 30, 2), 2) + price);
                    }
                }
            }
        }

        private void TabOrders_MouseClick(object sender, MouseEventArgs e)
        {
            AllCustomerInReturn();
            ClearNewOrderForm();
            ClearTxtReturnForm();

        }

        private void TxtSearchCustomerinRetornBook_TextChanged(object sender, EventArgs e)
        {
            if (DgvBookInRetorn.Visible == true)
            {
                AllBookInRetorn();
            }
            else
            {
                AllCustomerInReturn();
            }
        }

        private void DgvBookInRetorn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (ReturnBook.Contains(e.RowIndex))
            {
                ReturnBook.Remove(e.RowIndex);
                DgvBookInRetorn.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                DgvBookInRetorn.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                if (ReturnBook.Count == 0)
                {
                    BtnReturnBook.Visible = false;
                }
            }
            else
            {
                ReturnBook.Add(e.RowIndex);
                DgvBookInRetorn.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(250, 130, 0);
                DgvBookInRetorn.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                BtnReturnBook.Visible = true;
            }
            LblbookcountinReturn.Visible = true;
            LblAmmountInRetorn.Visible = true;
            LblbookcountinReturn.Text = ReturnBook.Count.ToString() +" kitab"; ;
            decimal ammount = 0;
            foreach (int id in ReturnBook)
            {
                ammount+=Convert.ToDecimal(DgvBookInRetorn.Rows[id].Cells[7].Value);
            }
            LblAmmountInRetorn.Text = ammount.ToString("#.##") + "  AZN";
        }

        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            foreach (int id in ReturnBook)
            {

                Book book = context.Books.Find(Convert.ToInt32(DgvBookInRetorn.Rows[id].Cells[0].Value));
                List<Order> orders = context.Orders.Include("OrderItems").Where(o => o.CustomerId == selectedCustomerIdinReturn).ToList();
                foreach (Order order in orders)
                {
                    List<OrderItem> orderItems = context.OrderItems.Where(o => o.BookId == book.Id && o.ReturnTime.ToString() == "").ToList();
                    foreach (OrderItem orderitem in orderItems)
                    {
                        orderitem.ReturnTime = DateTime.Now;
                        orderitem.Price = Convert.ToDecimal(DgvBookInRetorn.Rows[id].Cells[7].Value);
                        context.SaveChanges();
                        break;
                    }
                    break;
                }


            }
            MessageBox.Show("Kitab qaytarıldı.");
            AllBookInRetorn();
            ReturnBook.Clear();
            BtnReturnBook.Visible = false;
            LblbookcountinReturn.Visible = false;
            LblAmmountInRetorn.Visible = false;
        }

        public void ClearTxtReturnForm()
        {
            BtnExitInReturn.Visible = false;
            BtnReturnBook.Visible = false;
            LblCustumerNameInRetrn.Text = "";
            TxtSearchBookAndCustomerinRetornBook.Text = "Müştəri axtar...";
            DgvBookInRetorn.Visible = false;
            DgvCustomerinRetornBook.Visible = true;
            PnlSearchBookAndCustomerreturn.Visible = true;
            LblAmmountInRetorn.Visible = false;
            LblbookcountinReturn.Visible = false;

        }
        private void BtnExitInReturn_Click(object sender, EventArgs e)
        {
            ClearTxtReturnForm();
            AllCustomerInReturn();
        }

        #endregion

        #region ViewAllBooksInRent
        public void ViewBooksInRent()
        {
            DgvViewBooksinrent.Rows.Clear();
            List<Book> books = context.Books.ToList();
            foreach (Book book in books)
            {
                List<Order> orders = context.Orders.Include("OrderItems").ToList();
                foreach (Order order in orders)
                {
                    foreach (OrderItem orderItem in order.OrderItems)
                    {
                        if (orderItem.ReturnTime.ToString() == "")
                        {
                            break;
                        }
                        if (book.Id == orderItem.BookId)
                        {
                            if (CbbForTimeReturnBook.SelectedIndex == 0)
                            {

                                DgvViewBooksinrent.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice + "  AZN         ", order.Created.ToString("dd-MM-yyyy"), orderItem.EndRentTime.ToString("dd-MM-yyyy"), Math.Round(Convert.ToDecimal(orderItem.EndRentTime.Subtract(order.Created).TotalDays) * Math.Round(book.MonthlyPrice / 30, 2), 2) + "  AZN", Math.Round(Convert.ToDecimal(DateTime.Now.Subtract(order.Created).TotalDays) * Math.Round(book.MonthlyPrice / 30, 2), 2) + "  AZN");
                            }
                            else if (CbbForTimeReturnBook.SelectedIndex == 1 && Math.Round(orderItem.EndRentTime.Subtract(DateTime.Now).TotalDays) ==1)
                            {
                                DgvViewBooksinrent.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice + "  AZN         ", order.Created.ToString("dd-MM-yyyy"), orderItem.EndRentTime.ToString("dd-MM-yyyy"), Math.Round(Convert.ToDecimal(orderItem.EndRentTime.Subtract(order.Created).TotalDays) * Math.Round(book.MonthlyPrice / 30, 2), 2) + "  AZN", Math.Round(Convert.ToDecimal(DateTime.Now.Subtract(order.Created).TotalDays) * Math.Round(book.MonthlyPrice / 30, 2), 2) + "  AZN");
                            }
                            else if (CbbForTimeReturnBook.SelectedIndex == 2 && Math.Round(orderItem.EndRentTime.Subtract(DateTime.Now).TotalDays) == 0)
                            {
                                DgvViewBooksinrent.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice + "  AZN         ", order.Created.ToString("dd-MM-yyyy"), orderItem.EndRentTime.ToString("dd-MM-yyyy"), Math.Round(Convert.ToDecimal(orderItem.EndRentTime.Subtract(order.Created).TotalDays) * Math.Round(book.MonthlyPrice / 30, 2), 2) + "  AZN", Math.Round(Convert.ToDecimal(DateTime.Now.Subtract(order.Created).TotalDays) * Math.Round(book.MonthlyPrice / 30, 2), 2) + "  AZN");
                            }
                            else if (CbbForTimeReturnBook.SelectedIndex == 3 && Math.Round(orderItem.EndRentTime.Subtract(DateTime.Now).TotalDays) < 0)
                            {
                                DgvViewBooksinrent.Rows.Add(book.Id, book.Name, book.Writter, book.MonthlyPrice + "  AZN         ", order.Created.ToString("dd-MM-yyyy"), orderItem.EndRentTime.ToString("dd-MM-yyyy"), Math.Round(Convert.ToDecimal(orderItem.EndRentTime.Subtract(order.Created).TotalDays) * Math.Round(book.MonthlyPrice / 30, 2), 2) + "  AZN", Math.Round(Convert.ToDecimal(DateTime.Now.Subtract(order.Created).TotalDays) * Math.Round(book.MonthlyPrice / 30, 2), 2) + "  AZN");
                            }
                        }
                    }
                }
            }
        }

        private void TabOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbbForTimeReturnBook.SelectedIndex = 0;
            ViewBooksInRent();
        }

        private void CbbForTimeReturnBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewBooksInRent();
        }

        private void DgvCustomerinRetornBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            selectedCustomerIdinReturn = Convert.ToInt32(DgvCustomerinRetornBook.Rows[e.RowIndex].Cells[0].Value);
            LblCustumerNameInRetrn.Text = DgvCustomerinRetornBook.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + DgvCustomerinRetornBook.Rows[e.RowIndex].Cells[1].Value.ToString();

            DgvCustomerinRetornBook.Visible = false;
            DgvBookInRetorn.Visible = true;
            TxtSearchBookAndCustomerinRetornBook.Text = "Kitab axtar...";
            AllBookInRetorn();
            BtnExitInReturn.Visible = true;
            PnlSearchBookAndCustomerreturn.Visible = false;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (BtnAddOrderBook.BackColor == Color.LightGray)
            {
                LblUnderReturnBook.BackColor=Color.Maroon;
                LblUnderCountOrderBook.BackColor = Color.Maroon;
                MessageBox.Show("Xanaları doldurun.");
                return;
            }
            int a = 0;
            foreach (DataGridViewRow row in DgvBooksInOrder.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.FromArgb(250, 130, 0))
                {
                    a = row.Index;
                }
            }
            selectedBookinOrder = context.Books.Find(DgvBooksInOrder.Rows[a].Cells[0].Value);

            if (TxtCountOrderBook.Text == "Sayı" && dateTimePicker1.Value.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
            {
                LblUnderCountOrderBook.BackColor = Color.Maroon;
                LblUnderReturnBook.BackColor = Color.Maroon;
                MessageBox.Show(TxtCountOrderBook.Text);
                return;
            }
            if (PnlReturnTime.Visible == false)
            {
                PnlReturnTime.Visible = true;
                return;
            }

            if (PnlReturnTime.Visible == true)
            {
                LblUnderCountOrderBook.BackColor = Color.Orange;
                LblUnderReturnBook.BackColor = Color.Orange;
                if (TxtCountOrderBook.Text == "Sayı" && dateTimePicker1.Value.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
                {
                    LblUnderCountOrderBook.BackColor = Color.Maroon;
                    LblUnderReturnBook.BackColor = Color.Maroon;
                    MessageBox.Show("Xanaları doldurun.");
                    return;
                }
                if (TxtCountOrderBook.Text == "Sayı")
                {
                    LblUnderCountOrderBook.BackColor = Color.Maroon;
                    MessageBox.Show("Kitabın sayını yazın.");
                    return;

                }
                if (dateTimePicker1.Value.ToString("dd-MM-yyyy") == DateTime.Now.ToString("dd-MM-yyyy"))
                {
                    LblUnderReturnBook.BackColor = Color.Maroon;
                    MessageBox.Show("Kitabın qaytarılma tarixini seçin.");
                    LblUnderCountOrderBook.BackColor = Color.Orange; ;
                    return;
                }
                if (uint.TryParse(TxtCountOrderBook.Text, out uint c))
                {
                    if (Convert.ToInt16(TxtCountOrderBook.Text) > Convert.ToInt32(DgvBooksInOrder.Rows[a].Cells[4].Value))
                    {
                        LblUnderCountOrderBook.BackColor = Color.Maroon;
                        MessageBox.Show("Bu kitabdan cəmi " + DgvBooksInOrder.Rows[a].Cells[4].Value.ToString() + " ədəd qalıb.");
                        return;
                    }
                    if (TxtCountOrderBook.Text == "0")
                    {
                        LblUnderCountOrderBook.BackColor = Color.Maroon;
                        MessageBox.Show("Düzgün dəyər daxil edin.");
                        return;
                    }
                }
                else
                {
                    LblUnderCountOrderBook.BackColor = Color.Maroon;
                    MessageBox.Show("Bu xanaya sadəcə rəqəm yaza bilərsiz.");
                    return;
                }
            }
            DgvSelectedBooks.Rows.Add(selectedBookinOrder.Id, selectedBookinOrder.Name, TxtCountOrderBook.Text + " kitab", Math.Round(selectedBookinOrder.MonthlyPrice * Convert.ToInt32(TxtCountOrderBook.Text) * (Convert.ToInt32((dateTimePicker1.Value - DateTime.Now).ToString("dd")) + 1) / 30, 2) + "  AZN", dateTimePicker1.Value.ToString("yyyy,MM,dd"));
            PnlSelectedBooks.Visible = true;
            AllBookInOrders();
            TxtCountOrderBook.Text = "Sayı";

            LblUnderReturnBook.BackColor = Color.Orange;
            TxtCountOrderBook.ForeColor = Color.Silver;
            BtnExitOrder.Visible = true;
            dateTimePicker1.Value = DateTime.Now;
            if (LblSelectedCustomer.Text != "")
            {
                BtnAddOrder.Visible = true;
            }
            BtnAddOrderBook.BackColor = Color.LightGray;        }

        private void TxtCountOrderBook_TextChanged(object sender, EventArgs e)
        {
            if(TxtCountOrderBook.Text!=""&& TxtCountOrderBook.Text != "Sayı"&& dateTimePicker1.Value.ToString("dd-MM-yyyy") != DateTime.Now.ToString("dd-MM-yyyy"))
            {
                BtnAddOrderBook.BackColor = Color.FromArgb(255,130,0);
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (TxtCountOrderBook.Text != "" && TxtCountOrderBook.Text != "Sayı" && dateTimePicker1.Value.ToString("dd-MM-yyyy") != DateTime.Now.ToString("dd-MM-yyyy"))
            {
                BtnAddOrderBook.BackColor = Color.FromArgb(255, 130, 0);
            }

        }

        #endregion

        #region Report
        public void ReportToDgv()
        {
            List<Customer> customers = context.Customers.ToList();
            foreach (Customer customer in customers)
            {
                List<Order> orders = context.Orders.Include("OrderItems").Where(o => o.Created >= DtpStart.Value && o.Created <= DtpEnd.Value && o.CustomerId == customer.Id).ToList();
                foreach (Order order in orders)
                {
                    foreach (OrderItem orderItem in order.OrderItems)
                    {
                        List<Book> books = context.Books.Where(b => b.Id == orderItem.BookId).ToList();
                        foreach (Book book in books)
                        {
                            string returntimebook = "-";
                            if (orderItem.ReturnTime.ToString()!= "")
                            {
                                returntimebook = orderItem.ReturnTime.Value.Day.ToString()+"-"+ orderItem.ReturnTime.Value.Month.ToString()+"-"+ orderItem.ReturnTime.Value.Year.ToString();
                            }

                            DgvReport.Rows.Add(customer.Name, customer.Surname, customer.PhoneNumber, customer.CreateAt.ToString("dd-MM-yyyy"), customer.DateBirth.ToString("dd-MM-yyyy"), book.Name, order.Created.ToString("dd-MM-yyyy"), orderItem.EndRentTime.ToString("dd-MM-yyyy"), returntimebook, orderItem.Price);
                        }
                    }
                }
            }

        }

        public void Report()
       {
            int a = 1;
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Sheet");
            List<Customer> customers = context.Customers.ToList();

            worksheet.Cell("A" + a).Value = "Adı";
            worksheet.Cell("B" + a).Value = "Soyadı";
            worksheet.Cell("C" + a).Value = "Telefon nömrəsi";
            worksheet.Cell("D" + a).Value = "Qeydiyyat tarixi";
            worksheet.Cell("E" + a).Value = "Doğum tarixi";
            worksheet.Cell("F" + a).Value = "Götürdüyü kitab";
            worksheet.Cell("G" + a).Value = "Götürdüyü tarix";
            worksheet.Cell("H" + a).Value = "Qaytarmalı olduğu tarix";
            worksheet.Cell("I" + a).Value = "Real qaytardığı tarix";
            worksheet.Cell("J" + a).Value = "Ödəniş";

            foreach (Customer customer in customers)
            {
                List<Order> orders = context.Orders.Include("OrderItems").Where(o => o.Created >= DtpStart.Value && o.Created <= DtpEnd.Value&&o.CustomerId==customer.Id).ToList();
                foreach(Order order in orders)
                {
                    foreach(OrderItem orderItem in order.OrderItems)
                    {
                        List<Book> books = context.Books.Where(b=>b.Id==orderItem.BookId).ToList();
                        foreach(Book book in books)
                        {

                            a++;
                            worksheet.Cell("A" + a).Value = customer.Name;
                            worksheet.Cell("B" + a).Value = customer.Surname;
                            worksheet.Cell("C" + a).Value = customer.PhoneNumber;
                            worksheet.Cell("D" + a).Value = customer.CreateAt;
                            worksheet.Cell("E" + a).Value = customer.DateBirth;
                            worksheet.Cell("F" + a).Value = book.Name;
                            worksheet.Cell("G" + a).Value = order.Created;
                            worksheet.Cell("H" + a).Value = orderItem.EndRentTime;
                            worksheet.Cell("I" + a).Value = orderItem.ReturnTime;
                            worksheet.Cell("J" + a).Value = orderItem.Price;
                        }
                    }
                }
            } 
            SfdReport.FileName = "Hesabat";
            DialogResult r= SfdReport.ShowDialog();
            if (r == DialogResult.OK)
            {
                string path = SfdReport.FileName;
                int x = 0;
                while (File.Exists(path))
                {
                    path = SfdReport.FileName;
                    x++;
                    path += x;

                }
                workbook.SaveAs(path+".xlsx");


            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            BtnOrders.BackColor = Color.FromArgb(230, 100, 0);
            BtnBooks.BackColor = Color.FromArgb(230, 100, 0);
            BtnCustomers.BackColor = Color.FromArgb(230, 100, 0);
            BtnManagers.BackColor = Color.FromArgb(230, 100, 0);
            BtnReport.BackColor = Color.FromArgb(250, 130, 0);

            TabOrders.Visible = false;
            PnlOrders.Visible = false;
            PnlBooks.Visible = false;
            PnlCustomers.Visible = false;
            PnlManagers.Visible = false;
            PnlReport.Visible = true;
            ReportToDgv();
        }

        private void DtpEnd_ValueChanged(object sender, EventArgs e)
        {
            BtnShowReport.Text = "Axtar";
            DgvReport.Rows.Clear();
            if (DtpEnd.Value > DateTime.Now)
            {
                DtpEnd.Value = DateTime.Now;
            }
            if (DtpEnd.Value < DtpStart.Value)
            {
                DtpStart.Value = DtpEnd.Value;
            }
        }

        private void BtnShowReport_Click(object sender, EventArgs e)
        {
            if (BtnShowReport.Text == "Axtar")
            {
                ReportToDgv();
                if (DgvReport.Rows.Count > 0)
                {
                    BtnShowReport.Text = "Report";
                }
            }else if (BtnShowReport.Text == "Report")
            {
                Report();
                MessageBox.Show("Yaddaşa yazıldı.");
                DgvReport.Rows.Clear();
                BtnShowReport.Text = "Axtar";
            }
        }
        #endregion

    }
}