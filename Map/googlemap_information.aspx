<%@ Page Language="C#" AutoEventWireup="true" CodeFile="googlemap_information.aspx.cs" Inherits="googlemap_information" %>
<%@ Register Src="~/GoogleMapForASPNet.ascx" TagName="GoogleMapForASPNet" TagPrefix="uc1" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

  
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

       <div>
           <asp:GridView ID="GridView1" Visible="false" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
               <Columns>
                   <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                   <asp:BoundField DataField="lat" HeaderText="lat" SortExpression="lat" />
                   <asp:BoundField DataField="lng" HeaderText="lng" SortExpression="lng" />
                   <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                   <asp:BoundField DataField="Titles" HeaderText="Titles" SortExpression="Titles" />
               </Columns>
           </asp:GridView>
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TutorialConnectionString %>" SelectCommand="SELECT * FROM [Google map info]"></asp:SqlDataSource>
        <uc1:GoogleMapForASPNet ID="GoogleMapForASPNet1" runat="server" />
    </div>
    </form>
</body>
</html>
