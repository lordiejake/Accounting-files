<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Admin-Control-Panel-Index-Credits-Details-Panel.aspx.cs" Inherits="Admin_Control_Panel_Index_Credits_Details_Panel" %>

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

<artisteer:Article ID="Article1" Caption="Credits Descriptions Details Panel" runat="server"><ContentTemplate>
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
    

</asp:Content>

