<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Wescale.DevTestWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h4>For questions or assistance please contact us.</h4>
    <address>
        WPS Management GmbH<br />
        Voßstraße 33<br />
        10117 Berlin<br />
        <abbr title="Phone">P:</abbr>
        +49 (30) 577015 55-0
    </address>

    <address>
        <strong>Michael Brinkmann:</strong> <a href="mailto:m.brinkmann@wps-management.de">m.brinkmann@wps-management.de</a><br />
        <strong>Steffen Leipertz:</strong>   <a href="mailto:s.leipertz@wps-management.de">s.leipertz@wps-management.de</a>
    </address>
</asp:Content>
