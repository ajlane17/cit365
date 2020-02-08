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
    public partial class SearchQuotes : Form
    {
        private FileContext savedQuotesFile;
        private FileRepository<DeskQuote> savedQuotesRepository;

        //Constructor
        public SearchQuotes(ref FileContext savedQuotesFile)
        {
            InitializeComponent();
            this.savedQuotesFile = savedQuotesFile;
            savedQuotesRepository = new FileRepository<DeskQuote>(savedQuotesFile);
            cmbMaterialSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterialSearch.DataSource = DesktopMaterial.GetValues(typeof(DesktopMaterial));
        }

        public void showResults()
        {
            // Call getSearchResults to populate DataGridView
            dataGridView1.DataSource = getSearchResults();

            // Hide embedded DeskQuote object reference
            dataGridView1.Columns["Quote"].Visible = false;
        }

        public void showResults(DesktopMaterial dm)
        {
            dataGridView1.DataSource = getSearchResults(dm);
        }

        public void showResults(string customerName)
        {
            dataGridView1.DataSource = getSearchResults(customerName);
        }

        //This is the "show all" version
        public List<DeskQuoteView> getSearchResults()
        {
            List<DeskQuote> deskQuotes = new List<DeskQuote>(savedQuotesRepository.GetAll());
            DeskQuoteView dqv;
            List<DeskQuoteView> searchResults = new List<DeskQuoteView>();
            foreach (DeskQuote dq in deskQuotes)
            {
                dqv = new DeskQuoteView(dq);
                searchResults.Add(dqv);
            }
            SortQuotes(ref searchResults);
            return searchResults;
        }

        // Called by event handler on dropdown to populate grid
        public List<DeskQuoteView> getSearchResults(DesktopMaterial desktopMaterial)
        {
            List<DeskQuote> deskQuotes = new List<DeskQuote>(savedQuotesRepository.GetAll());
            DeskQuoteView dqv;
            List<DeskQuoteView> searchResults = new List<DeskQuoteView>();
            foreach (DeskQuote dq in deskQuotes)
            {
                //We will only add matching material types to the view.
                if (dq.Desk.Material==desktopMaterial)
                {
                    dqv = new DeskQuoteView(dq);
                    searchResults.Add(dqv);
                }
            }
            SortQuotes(ref searchResults);
            return searchResults;
        }

        public List<DeskQuoteView> getSearchResults(string customerName)
        {
            List<DeskQuote> deskQuotes = new List<DeskQuote>(savedQuotesRepository.GetAll());
            DeskQuoteView dqv;
            List<DeskQuoteView> searchResults = new List<DeskQuoteView>();
            foreach (DeskQuote dq in deskQuotes)
            {
                //We will only add matching material types to the view.
                if (dq.CustomerName.ToUpper().Contains(customerName.ToUpper())) 
                {
                    dqv = new DeskQuoteView(dq);
                    searchResults.Add(dqv);
                }
            }
            SortQuotes(ref searchResults);
            return searchResults;
        }

        public void SortQuotes(ref List<DeskQuoteView> dqv)
        {
            if (radioSortNone.Checked)
            {
                return;
            }
            else if (radioSortCustomer.Checked)
            {
                dqv.Sort((f1, f2) => f1.CustomerName.CompareTo(f2.CustomerName));
            }
            else if (radioSortAmount.Checked)
            {
                dqv.Sort((f1, f2) => f1.QuotePrice.CompareTo(f2.QuotePrice));
            }
        }

        private void cmbMaterialSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call getSearchResults to populate DataGridView
            dataGridView1.DataSource = getSearchResults(DesktopMaterial.Laminate);
        }

        private void radioSearchUpdated_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.SelectAll();
            dataGridView1.ClearSelection();
            UpdateSearch();
        }

        private void UpdateSearch()
        {
            UpdateSearchButtons();
            //If a button other than search by ID is checked, then we need to re-run the search in order to perform the sorting.
            if (radioSearchAll.Checked)
            {
                showResults();
            }
            else if (radioSearchMaterial.Checked)
            {
                DesktopMaterial dm;
                if (Enum.TryParse(cmbMaterialSearch.Text,out dm)) {
                    showResults(dm);
                }
            }
            else if (radioSearchCustomer.Checked)
            {
                if (txtSearchCustomer.Text.Length > 0)
                {
                    showResults(txtSearchCustomer.Text);
                }
            }
        }

        private void UpdateSearchButtons()
        {
            if (radioSearchAll.Checked)
            {
                txtSearchCustomer.Visible = false;
                btnSearchCustomer.Visible = false;
                cmbMaterialSearch.Visible = false;
                btnSearchDeskMaterial.Visible = false;
            }
            else if (radioSearchCustomer.Checked)
            {
                txtSearchCustomer.Visible = true;
                btnSearchCustomer.Visible = true;
                cmbMaterialSearch.Visible = false;
                btnSearchDeskMaterial.Visible = false;
            }
            else if (radioSearchMaterial.Checked)
            {
                txtSearchCustomer.Visible = false;
                btnSearchCustomer.Visible = false;
                cmbMaterialSearch.Visible = true;
                btnSearchDeskMaterial.Visible = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeskQuoteView currentViewItem = (DeskQuoteView) this.dataGridView1.CurrentRow.DataBoundItem;
            DisplayQuote displayQuoteForm = new DisplayQuote(currentViewItem.Quote);

            displayQuoteForm.Show();
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
    