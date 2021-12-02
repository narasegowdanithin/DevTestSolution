<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" ValidateRequest="false" CodeBehind="Remoting.aspx.cs" Inherits="Wescale.DevTestWeb.UI.Remoting" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h2>.NET-Remoting</h2>

	<h4>Ping-Service</h4>
	<p>Simple ping-service for the general test of the remoting calls.</p>
	<table>
		<tr>
			<td>
				<asp:Button runat="server" Text="Send ping" ID="_sendPing" causesvalidation="false" OnCommand="_sendPing_Command" />
			</td>
		</tr>
		<tr>
			<td>
				<asp:Label runat="server" ID="_pingReturn" />
			</td>
		</tr>
	</table>
	<br />
	<br />
	<h4>Math-service</h4>
	<p>A service call for the addition of two integers.</p>
	<table>
		<tr>
			<td>First integer </td>
			<td>
				<asp:TextBox runat="server" ID="_op1" />
				<asp:RegularExpressionValidator ID="_val1" ControlToValidate="_op1" runat="server" ErrorMessage="Bitte nur ganze Zahlen" ValidationExpression="\d+" />
				<asp:RequiredFieldValidator runat="server" ID="_RF1" ErrorMessage="Please enter the number." ControlToValidate="_op1" />
			</td>
		</tr>
		<tr>
			<td>Second integer </td>
			<td>
				<asp:TextBox runat="server" ID="_op2" />
				<asp:RegularExpressionValidator ID="_val2" ControlToValidate="_op2" runat="server" ErrorMessage="Bitte nur ganze Zahlen" ValidationExpression="\d+" />
				<asp:RequiredFieldValidator runat="server" ID="_RF2" ErrorMessage="Please enter the number." ControlToValidate="_op2" />
			</td>
		</tr>
		<tr>
			<td colspan="2">
				<asp:Button runat="server" Text="Addieren" ID="_add" OnCommand="_add_Command" /></td>
		</tr>
		<tr>
			<td colspan="2">
				<br />
			</td>
		</tr>
		<tr>
			<td>Result: </td>
			<td>
				<asp:Label runat="server" ID="_addResult" />
			</td>
		</tr>
	</table>
</asp:Content>
