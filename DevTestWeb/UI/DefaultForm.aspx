<%@ Page Title="DefaultForm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" ValidateRequest="false" CodeBehind="DefaultForm.aspx.cs" Inherits="Wescale.DevTestWeb.UI.DefaultForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h2><%: Title %></h2>
	<p>DefaultForm</p>

	<table>
		<tr>
			<td>
				<table>
					<tr>
						<td class="labelCol">
							<asp:Label runat="server" ID="_nameLbl" CssClass="myLabel">Name</asp:Label></td>
						<td>
							<asp:TextBox runat="server" ID="_nameText"></asp:TextBox>
							<asp:RequiredFieldValidator runat="server" ID="_nameRequired" ErrorMessage="Please enter a name." ControlToValidate="_nameText" />
						</td>
					</tr>
					<tr>
						<td>
							<asp:Label runat="server" ID="_qtyLbl" CssClass="myLabel">Quantity</asp:Label></td>
						<td>
							<asp:TextBox runat="server" ID="_qtyText"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							<asp:Label runat="server" ID="_lblPrice" CssClass="myLabel">Price</asp:Label></td>
						<td>
							<asp:TextBox runat="server" ID="_priceTxt"></asp:TextBox></td>
					</tr>
					<tr>
						<td>
							<asp:Label runat="server" ID="_currencyLbl" CssClass="myLabel">Currency</asp:Label></td>
						<td>
							<asp:ListBox runat="server" ID="_currencyList" Rows="1">
								<asp:ListItem Text="USD" Value="USD" />
								<asp:ListItem Text="CHF" Value="EUR" />
								<asp:ListItem Text="EUR" Value="EUR" />
								<asp:ListItem Text="YEN" Value="YEN" />
							</asp:ListBox></td>
					</tr>
					<tr>
						<td colspan="2" style="text-align:right"><asp:Button runat="server" Text="Send input" ID="_sendInput" OnCommand="_sendInput_Command" OnClientClick="return MyAwesomeMethod();" /></td>
					</tr>
				</table>
			</td>
		</tr>
		<tr><td></br><h3>Information after sending the form</h3></td></tr>
		<tr>
			<td>
				<asp:Label runat="server" ID="_selectedNameLbl" Text="Name" />
			</td>
			<td><asp:Label runat="server" ID="_selectedName" /></td>
		</tr>
		<tr>
			<td>
				<asp:Label runat="server" ID="_selectedQtyLbl" Text="Quantity" />
			</td>
			<td><asp:Label runat="server" ID="_selectedQty" /></td>
		</tr>
		<tr>
			<td>
				<asp:Label runat="server" ID="_selectedPriceLbl" Text="Price" />
			</td>
			<td><asp:Label runat="server" ID="_selectedPrice" /></td>
		</tr>
		<tr>
			<td>
				<asp:Label runat="server" ID="_selectedCurrencyLbl" Text="Currency (Value)" />
			</td>
			<td><asp:Label runat="server" ID="_selectedCurrency" /></td>
		</tr>
	</table>

	<script type="text/javascript">
		function MyAwesomeMethod(){return !confirm('Are you sure this is to be sent?');}
</script>
</asp:Content>
