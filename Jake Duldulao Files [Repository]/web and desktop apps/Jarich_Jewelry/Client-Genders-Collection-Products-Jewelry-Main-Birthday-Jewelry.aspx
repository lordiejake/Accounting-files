<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Client-Genders-Collection-Products-Jewelry-Main-Birthday-Jewelry.aspx.cs" Inherits="Client_children_Collection_Products_Jewelry_Main_Birthday_Jewelry" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Birthday Jewelries
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
    
<artisteer:Article ID="Article1" Caption="Birthday Jewelry" runat="server"><ContentTemplate>
    <p>Open each delicate angel wing locket to discover the “wishing feathers” nestled inside. Keep the feathers to hold special dreams by your heart, or offer them as wishful gifts for another. Heart-shaped Rhodium lockets filled with real feathers. Lobster claw closure – 16″ with 2″ extender. Comes with vibrant raspberry box.

Send feather wishes to a special friend for a milestone 50th birthday or in between birthday.  Let your friend know that you are wishing her special things on her birthday and all year round.  The Feather Wish Necklace will be a favorite so be sure to stock up for all your girlfriends.

For this and more 50th birthday gifts and beyond, be sure to visit www.moljewelry.com.  Offering gifts for special occasions, holidays and celebrations.</p>

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
    <br />
        
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

    </ContentTemplate></artisteer:Article>

           <artisteer:Article ID="Article3" Caption="We Accept the following Credit Cards below:" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/Credits.jpg" alt="an image" style="float:left;" />

 </ContentTemplate></artisteer:Article>
</asp:Content>
