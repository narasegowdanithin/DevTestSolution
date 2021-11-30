using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using Wescale.DevTestCommon;

namespace Wescale.DevTestWeb.UI {

    public partial class Database : Page {

        /// <summary>
        /// PreRender-Event
        /// </summary>
        /// <param name="e">Args</param>
        protected override void OnPreRender(EventArgs e) {
            base.OnPreRender(e);

            // Load the data
            int totalRecords;
            _userGrid.DataSource = CreateDataSource(out totalRecords);
            _userGrid.VirtualItemCount = totalRecords;
            _userGrid.DataBind();
        }

        /// <summary>
        /// Reset the content of the grid.
        /// </summary>
        protected void OnReset(object sender, CommandEventArgs e) {
            // Set CurrentPageIndex to 0.
            _userGrid.CurrentPageIndex = 0;
        }

        /// <summary>
        /// Change the shown page.
        /// </summary>
        protected void OnPageIndexChanged(Object sender, DataGridPageChangedEventArgs e) {
            // Set CurrentPageIndex to the page the user clicked.
            _userGrid.CurrentPageIndex = e.NewPageIndex;
        }

        /// <summary>
        /// Get data from source
        /// </summary>
        private ICollection CreateDataSource(out int totalRecords) {
            IUserService service = (IUserService)RemotingHelper.GetObject(typeof(IUserService));
            IList<User> users = service.List(_userGrid.CurrentPageIndex, _userGrid.PageSize, out totalRecords);

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("Login", typeof(string)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Email", typeof(string)));

            foreach (User user in users) {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);

                dr["ID"] = user.ID;
                dr["Login"] = user.Login;
                dr["Name"] = user.Name;
                dr["Email"] = user.Email;
            }

            DataView dv = new DataView(dt);
            return dv;
        }

    }
}