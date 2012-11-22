<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Client-Genders-Collection-Products-Jewelry-Main-Graduation-Jewelry.aspx.cs" Inherits="Client_children_Collection_Products_Jewelry_Main_Graduation_Jewelry" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Graduation Jewelries
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
    
<artisteer:Article ID="Article1" Caption="Graduation Jewelries" runat="server"><ContentTemplate>
    <p>Graduation is a time of celebration and new beginnings.  Help your special graduate celebrate her graduation day with a unique jewelry graduation gift that will be a keepsake for her lifetime.
      Graduation jewelry provides your graduate with something lovely to wear on her special day as well as a lasting keepsake for years to come.</p>
      <p>
      We have two jewelry lines to be sure you find a graduation gift idea that will fit her personality perfectly. 
       Our Jules line features custom designed whimsical graduation jewelry, while our Little Girls’ Pearls line is custom designed keepsake pearl jewelry for girls of all ages.
      </p>
      <p>
      Each of our graduation jewelry pieces is custom designed to order.  Are you in a hurry?  No problem at all.  Our jewelry normally ships out within 1-2 business days.  However, we can usually ship out the same day you order depending on the time of day you order.  
      We also offer a variety of expedited shipping services to be sure your graduate receives her special graduation gift in time for her big day.
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
    </ContentTemplate></artisteer:Article>

           <artisteer:Article ID="Article3" Caption="We Accept the following Credit Cards below:" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/Credits.jpg" alt="an image" style="float:left;" />

 </ContentTemplate></artisteer:Article>
</asp:Content>

