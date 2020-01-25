using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk

{
    public partial class MainMenu : Form
    {
        private AddQuote addQuoteForm;
        private ViewAllQuotes viewAllQuotesForm;
        private SearchQuotes searchQuotesForm;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["AddQuote"] as AddQuote) != null)
            {
                // If form exists, bring to front
                addQuoteForm = Application.OpenForms.OfType<AddQuote>().LastOrDefault();
                addQuoteForm.WindowState = FormWindowState.Normal;
                addQuoteForm.Focus();
            }
            else
            {
                // If form does not exist, create it
                addQuoteForm = new AddQuote();
                addQuoteForm.Show();
            }
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["SearchQuotes"] as SearchQuotes) != null)
            {
                // If form exists, bring to front
                searchQuotesForm = Application.OpenForms.OfType<SearchQuotes>().LastOrDefault();
                searchQuotesForm.WindowState = FormWindowState.Normal;
                searchQuotesForm.Focus();
            }
            else
            {
                // If form does not exist, create it
                searchQuotesForm = new SearchQuotes();
                searchQuotesForm.Show();
            }
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["ViewAllQuotes"] as ViewAllQuotes) != null)
            {
                // If form exists, bring to front
                viewAllQuotesForm = Application.OpenForms.OfType<ViewAllQuotes>().LastOrDefault();
                viewAllQuotesForm.WindowState = FormWindowState.Normal;
                viewAllQuotesForm.Focus();
            }
            else
            {
                // If form does not exist, create it
                viewAllQuotesForm = new ViewAllQuotes();
                viewAllQuotesForm.Show();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
