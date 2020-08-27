<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<script>
		function OnSelectedIndexChanged(s, e) {
			var id = s.GetSelectedItem().value;
			PageMethods.GetData(id, OnSuccess);
		}
		function OnSuccess(response) {
			cmb.ClearItems();
			for (var i in response) {
				cmb.AddItem(response[i].Name, response[i].ID);
			}
		}
	</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>		
		<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
		Select an item:
		<dx:ASPxComboBox ID="ASPxComboBox1" runat="server" ValueType="System.String" 
			TextField="CategoryName" ValueField="CategoryID"
			DataSourceID="SqlDataSource1">
			<ClientSideEvents SelectedIndexChanged="OnSelectedIndexChanged" />
		</dx:ASPxComboBox>
		<br/>
		Check the item list:
		<dx:ASPxComboBox ID="ASPxComboBox2" runat="server" ValueType="System.String" ClientInstanceName="cmb">
		</dx:ASPxComboBox>
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings: NorthwindConnectionString %>"
			SelectCommand="SELECT CategoryID, CategoryName FROM Categories">
		</asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
