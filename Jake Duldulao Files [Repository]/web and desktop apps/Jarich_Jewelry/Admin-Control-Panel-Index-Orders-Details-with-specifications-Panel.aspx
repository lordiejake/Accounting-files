<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Admin-Control-Panel-Index-Orders-Details-with-specifications-Panel.aspx.cs" Inherits="Admin_Control_Panel_Index_Orders_Details_with_specifications_Panel" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenuAdmin.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Admin Control Panel
</asp:Content>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContentPlaceHolder" Runat="Server">
    <art:DefaultHeader ID="DefaultHeader" runat="server" />
</asp:Content>
<asp:Content ID="MenuContent" ContentPlaceHolderID="MenuContentPlaceHolder" Runat="Server">
    <art:DefaultMenu ID="DefaultMenuContent" runat="server" />
</asp:Content>
<asp:Content ID="SideBar1" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" Runat="Server">
    <art:DefaultSidebar1 ID="DefaultSidebar1Content" runat="server" />
</asp:Content>

<asp:Content ID="SheetContent" ContentPlaceHolderID="SheetContentPlaceHolder" Runat="Server">

<artisteer:Article ID="Article1" Caption="Customer Details Panel" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/VS.png" alt="an image" style="float:left;border:0;margin: 1em 1em 0 0;" />
    <p>Lorem ipsum dolor sit amet,
    <a href="javascript:void(0)" title="link">link</a>, <a class="visited" href="javascript:void(0)" title="visited link">visited link</a>,
     <a class="hover" href="javascript:void(0)" title="hovered link">hovered link</a> consectetuer
    adipiscing elit. Quisque sed felis. Aliquam sit amet felis. Mauris semper,
    velit semper laoreet dictum, quam diam dictum urna, nec placerat elit nisl
    in quam. Etiam augue pede, molestie eget, rhoncus at, convallis ut, eros.</p>
    <p>Lorem ipsum dolor sit amet,
    <a href="javascript:void(0)" title="link">link</a>, <a class="visited" href="javascript:void(0)" title="visited link">visited link</a>,
     <a class="hover" href="javascript:void(0)" title="hovered link">hovered link</a> consectetuer
    adipiscing elit. Quisque sed felis. Aliquam sit amet felis. Mauris semper,
    velit semper laoreet dictum, quam diam dictum urna, nec placerat elit nisl
    in quam. Etiam augue pede, molestie eget, rhoncus at, convallis ut, eros.</p>
    <p>Lorem ipsum dolor sit amet,
    <a href="javascript:void(0)" title="link">link</a>, <a class="visited" href="javascript:void(0)" title="visited link">visited link</a>,
     <a class="hover" href="javascript:void(0)" title="hovered link">hovered link</a> consectetuer
    adipiscing elit. Quisque sed felis. Aliquam sit amet felis. Mauris semper,
    velit semper laoreet dictum, quam diam dictum urna, nec placerat elit nisl
    in quam. Etiam augue pede, molestie eget, rhoncus at, convallis ut, eros.</p>
    <p>
        <span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="IndexAdminControlPanel.aspx">[Back-to-start-page]</a>
    	</span>
    </p>
           </ContentTemplate></artisteer:Article>
    <artisteer:Article ID="Article2" Caption="All Orders [Customers]" runat="server"><ContentTemplate>
          
     </ContentTemplate></artisteer:Article>

         <h4>Here are the list of Products Ordered</h4>

    <div style="width: 870px; height: 161px; overflow: auto">
        <asp:GridView ID="GridViewCustomers" runat="server" AutoGenerateColumns="False" 
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" CellSpacing="2">
            <Columns>
                <asp:BoundField DataField="Product_Name" HeaderText="[ProductName]" />
                <asp:BoundField DataField="Product_Current_Price" HeaderText="[Price]" />
                <asp:BoundField DataField="Product_Order_Quantity" HeaderText="[Quantity]" />
                <asp:BoundField DataField="Percent_Deduction" HeaderText="[Deduction]" />
                <asp:BoundField DataField="Total_Amount" HeaderText="[Total_Amount]" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </div>

</asp:Content>

