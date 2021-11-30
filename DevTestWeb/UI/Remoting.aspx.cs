using System.Web.UI.WebControls;
using Wescale.DevTestCommon;

namespace Wescale.DevTestWeb.UI {

    public partial class Remoting : System.Web.UI.Page {

        protected void _sendPing_Command(object sender, CommandEventArgs e) {
            IPingService service = (IPingService)RemotingHelper.GetObject(typeof(IPingService));
            _pingReturn.Text = service.Ping();
        }

        protected void _add_Command(object sender, CommandEventArgs e) {
            int a, b;
            if (int.TryParse(_op1.Text, out a) && int.TryParse(_op2.Text, out b)) {
                IMathService service = (IMathService)RemotingHelper.GetObject(typeof(IMathService));
                _addResult.Text = service.Add(a, b).ToString();
            }
        }

    }
}