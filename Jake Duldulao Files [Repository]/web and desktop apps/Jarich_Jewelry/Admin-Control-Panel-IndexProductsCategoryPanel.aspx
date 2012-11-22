<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Admin-Control-Panel-IndexProductsCategoryPanel.aspx.cs" Inherits="Admin_Control_Panel_IndexProductsCategoryPanel" %>

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

<artisteer:Article ID="Article1" Caption="Product Category Panel" runat="server"><ContentTemplate>
        <span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
       
    
    		<a class="art-button" href="IndexAdminControlPanel.aspx">[Back-to-start-page]</a>
    	</span>
    </p>
           </ContentTemplate></artisteer:Article>


    
    <artisteer:Article ID="Article2" Caption="Add new Category" runat="server"><ContentTemplate>
    <br />

        <asp:Panel ID="CategoryExistsPanel" runat="server" Visible="False">
        <blockquote>
            <p>The Category name you entered already Exists</p>
        </blockquote>
        </asp:Panel>

        <asp:Panel ID="CategoryAdded" runat="server" Visible="False">
        <blockquote>
            <p>Successfully added!</p>
        </blockquote>
        </asp:Panel>

        <table>
            <tr>
                <td>
                    Category Name: 
                </td>
                <td>
                    <asp:TextBox ID="TxtCategoryName" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1" runat="server" ControlToValidate = "TxtCategoryName" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Button ID="btnCreate" CssClass="art-button" runat="server" Text="Create" 
                        onclick="btnCreate_Click" /></td>
            </tr>
        </table>
        
     </ContentTemplate></artisteer:Article>

</asp:Content>


