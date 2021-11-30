using System;
using System.Web.UI.WebControls;

namespace Wescale.DevTestWeb.UI {
    public partial class DefaultForm : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            _currencyList.SelectedValue = "EUR";
        }

        protected void _sendInput_Command(object sender, CommandEventArgs e) {
            _selectedName.Text = _nameText.Text;
            _selectedQty.Text = _qtyText.Text;
            _selectedPrice.Text = _priceTxt.Text;
            _selectedCurrency.Text = _currencyList.SelectedValue;
        }
    }
}