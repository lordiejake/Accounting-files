<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="IndexAdminControlPanel.aspx.cs" Inherits="IndexAdminControlPanel" %>

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

<artisteer:Article ID="Article1" Caption="Welcome to Admin" runat="server"><ContentTemplate>
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
     <table>
        <tr>
            <td><span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Admin-Control-Panel-IndexProductsCategoryPanel.aspx">Modify Product Category</a>
    	</span></td>
        <td><span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Admin-Control-Panel-Index-Orders-Details-Panel.aspx">View New Orders</a>
    	</span></td>
        <td><span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Admin-Control-Panel-IndexProductsDescriptionsPanel.aspx">Modify Product Descriptions</a>
    	</span></td>
        </tr>
        <tr>
            <td><span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Admin-Control-Panel-Index-Customers-Details-Panel.aspx">View Customers</a>
    	</span></td>
        <td><span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Admin-Control-Panel-Index-Promotions-Details-Panel.aspx">Modify Promotions</a>
    	</span></td>
        <td><span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Admin-Control-Panel-Index-Credits-Details-Panel.aspx">Payments</a>
    	</span></td>
        </tr>
     </table>
    </p>
           </ContentTemplate></artisteer:Article>
    

</asp:Content>

