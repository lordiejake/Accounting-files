<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Client-Genders-Collection-Products-Jewelry-Main-Music-Icon-Jewelry.aspx.cs" Inherits="Client_children_Collection_Products_Jewelry_Main_Music_Icon_Jewelry" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
     Music Icon Jewelries
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
    
<artisteer:Article ID="Article1" Caption="Music Icon Jewelries" runat="server"><ContentTemplate>

    <p>    Rock out with these music themed fish hook earrings. Over-the-top glitter for an extra edge
   </p>

    <asp:Panel ID="PanelMen" Visible="false" runat="server">
        <p>
        <span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Client-Men-Collection-Products-Jewelry-Main.aspx">[Back-to-previous-page]</a>
    	</span>
    </p>
    </asp:Panel>
    <asp:Panel ID="PanelWomen" Visible="false" runat="server">
        <p>
        <span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Client-Women-Collection-Products-Jewelry-Main.aspx">[Back-to-previous-page]</a>
    	</span>
    </p>
    </asp:Panel>
    <asp:Panel ID="PanelKids" Visible="false" runat="server">
        <p>
        <span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Client-children-Collection-Products-Jewelry-Main.aspx">[Back-to-previous-page]</a>
    	</span>
    </p>
    </asp:Panel>

 </ContentTemplate></artisteer:Article>

    <artisteer:Article ID="Article2" Caption="Select a category" runat="server"><ContentTemplate>
    
    </ContentTemplate></artisteer:Article>

    <fieldset>
        <div>
            <asp:GridView ID="GridViewCategory" runat="server" AutoGenerateColumns="False" 
                DataKeyNames="Category_Num" ShowHeader="False" GridLines="None" 
                onrowcommand="GridViewCategory_RowCommand">
                <Columns>
                    <asp:ButtonField DataTextField="CategoryName" Text="Category" 
                        CommandName="Select">
                    <ItemStyle Font-Bold="True" ForeColor="#CC9900" />
                    </asp:ButtonField>
                </Columns>
            </asp:GridView>
        </div>
    </fieldset>
    

           <artisteer:Article ID="Article3" Caption="We Accept the following Credit Cards below:" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/Credits.jpg" alt="an image" style="float:left;" />

 </ContentTemplate></artisteer:Article>
</asp:Content>

