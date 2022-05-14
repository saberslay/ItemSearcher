using System;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace ItemSearcher {
    public partial class ItemSearcher : Form {
        public ItemSearcher() {
            InitializeComponent();
        }
        private async void GetHtmlAsync() {
            #region Region Urls
                string UK_URL = $"www.ebay.co.uk/sch/i.html?_nkw={SearchBar_TB.Text}&_in_kw=1&_ex_kw=&_sacat=0&_udlo=&_udhi=&_ftrt=901&_ftrv=1&_sabdlo=&_sabdhi=&_samilow=&_samihi=&_sadis=15&_stpos=N211BS&_sargn=-1%26saslc%3D1&_salic=3&_sop=12&_dmd=1&_ipg=60&_fosrp=1";
                string US_URL = $"www.ebay.com/sch/i.html?_nkw={SearchBar_TB.Text}&_in_kw=1&_ex_kw=&_sacat=0&_udlo=&_udhi=&_ftrt=901&_ftrv=1&_sabdlo=&_sabdhi=&_samilow=&_samihi=&_sadis=15&_stpos=N211BS&_sargn=-1%26saslc%3D1&_salic=3&_sop=12&_dmd=1&_ipg=60&_fosrp=1";
            #endregion
            var NEWUrl = $"";  

            if (uKToolStripMenuItem.Checked && uSToolStripMenuItem.Checked) {
                MessageBox.Show("Please only Check one box", "Invaded Region", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            } else if (!uKToolStripMenuItem.Checked && !uSToolStripMenuItem.Checked) {
                MessageBox.Show("Please Check a box", "Invaded Region", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return;
            } else if (uKToolStripMenuItem.Checked) {
                var UKNEWUrl = $"https://{UK_URL}";
                NEWUrl = UKNEWUrl;
            } else if (uSToolStripMenuItem.Checked) {
                var USNEWUrl = $"https://{US_URL}";
                NEWUrl = USNEWUrl;
            }

            LBBOX.Items.Clear();

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(NEWUrl);
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);

            var ProductHtml = htmlDocument.DocumentNode.Descendants("ul")
                .Where(node => node.GetAttributeValue("id", "")
                .Equals("ListViewInner")).ToList();

            var ProductListItems = ProductHtml[0].Descendants("li")
                .Where(node => node.GetAttributeValue("id", "")
                .Contains("item")).ToList();
            ItemCount_LB.Text = $"{ProductListItems.Count}";

            foreach (var ProductListItem in ProductListItems) {
                LBBOX.Items.Add(ProductListItem.GetAttributeValue("Listingid",""));

                LBBOX.Items[LBBOX.Items.Count - 1].SubItems.Add(ProductListItem.Descendants("li").Where(node => node.GetAttributeValue("class", "")
               .Contains("lvprice")).FirstOrDefault().InnerText);

                LBBOX.Items[LBBOX.Items.Count - 1].SubItems.Add(ProductListItem.Descendants("li").Where(node => node.GetAttributeValue("class", "")
               .Contains("lvformat")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t'));

            }
        }

        private void Search_BTN_Click(object sender, EventArgs e) {
            if (SearchBar_TB.Text != "") {
                GetHtmlAsync();
            } else {
                MessageBox.Show("Please input an item name to Search", "Invaded Search", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }

        private void SearchBar_TB_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (Char)ConsoleKey.Enter) {
                Search_BTN_Click(null, null); 
            }
        }
    }
}
