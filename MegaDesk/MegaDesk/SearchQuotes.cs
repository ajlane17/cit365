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
        private FileRepository<DeskQuote> savedQutoesRepository;

        public SearchQuotes(ref FileContext savedQuotesFile)
        {
            InitializeComponent();

            this.savedQuotesFile = savedQuotesFile;

            savedQutoesRepository = new FileRepository<DeskQuote>(savedQuotesFile);
        }

        // Called by event handler on dropdown to populate grid
        public List<DeskQuote> getSearchResults(DesktopMaterial desktopMaterial)
        {
            List<DeskQuote> quotes = new List<DeskQuote>(savedQutoesRepository.GetAll());

            // List<DeskQuote> searchResults = new List<DeskQuote>();

            List<DeskQuote> searchResults = quotes;

            // TODO: Logic to extrapolate subset of results based on enum passed
            // populate searchResults from search logic

            return searchResults;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call getSearchResults to populate DataGridView
            dataGridView1.DataSource = getSearchResults(DesktopMaterial.Laminate);

        }
    }
}
