<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" ValidateRequest="false" CodeBehind="Database.aspx.cs" Inherits="Wescale.DevTestWeb.UI.Database" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Database</h2>

    <h4>User list</h4>
    <p>Pageable list of users stored in SQL database.</p>
    <asp:DataGrid ID="_userGrid" runat="server"
        BorderColor="black"
        BorderWidth="1"
        CellPadding="5"
        AllowPaging="true"
        AllowCustomPaging="true"
        PageSize="5"
        AutoGenerateColumns="false"
        OnPageIndexChanged="OnPageIndexChanged">
        <HeaderStyle BackColor="LightGray" Font-Bold="true" />
        <PagerStyle Mode="NumericPages" HorizontalAlign="Right" Font-Bold="true" />
        <Columns>
            <asp:BoundColumn
                HeaderText="ID"
                DataField="ID" />
            <asp:BoundColumn
                HeaderText="Login"
                DataField="Login" />
            <asp:BoundColumn
                HeaderText="Name"
                DataField="Name" />
            <asp:BoundColumn
                HeaderText="E-Mail"
                DataField="Email" />
        </Columns>
    </asp:DataGrid>
    <br />
    <asp:Button runat="server" Text="Reset" ID="_reload" OnCommand="OnReset" />
</asp:Content>
