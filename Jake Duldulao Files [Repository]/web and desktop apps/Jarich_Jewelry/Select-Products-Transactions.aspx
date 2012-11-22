<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Select-Products-Transactions.aspx.cs" Inherits="Select_Products_Transactions" %>

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
    <p>Jewelry for men has largely consisted of expensive watches or rings. rarely has a guy considered wearing a pendant. If the guy wears a pendant that is manly enough, it actually can make him look really good. 
    Jarich has designed some really amazing and manly jewelry which come with stainless steel or titanium.
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
 <fieldset>
    <div>
                            <asp:ImageButton ID="ImageButton1" runat="server" 
                                ImageUrl="~/images/view-cart.gif" 
            onclick="ImageButton1_Click" />
                            </div>
 </fieldset>
<fieldset><div>
    <asp:GridView ID="GridImageRetrieve" runat="server" AutoGenerateColumns="False" 
        AllowPaging="True" DataKeyNames="Product_Num" 
        onpageindexchanging="GridImageRetrieve_PageIndexChanging" 
        onrowcommand="GridImageRetrieve_RowCommand">
        <Columns>
            <asp:BoundField DataField="Product_Num" HeaderText="id" Visible="False" />
            <asp:CommandField SelectText="Select this Product [view]" 
                ShowSelectButton="True">
            <ItemStyle ForeColor="#CC9900" />
            </asp:CommandField>
            <asp:BoundField DataField="Product_Name" HeaderText="ProductName" />
            <asp:BoundField DataField="Product_UpdatedDescription" HeaderText="Description" />
            <asp:BoundField DataField="Product_UpdatedPrice" HeaderText="Price" />
            <asp:BoundField DataField="Product_Status" HeaderText="Status" />
            <asp:TemplateField HeaderText="Image">
              <ItemTemplate>
                  <asp:Image ID="Image1" ImageUrl='<%# "Handler.ashx?ImID="+ Eval("Product_Num") %>' Height="150px" Width= "150px" runat="server" />
              </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <PagerSettings Position="TopAndBottom" />
        <RowStyle HorizontalAlign="Left" VerticalAlign="Top" />
    </asp:GridView>
</div>
    
</fieldset>

           <artisteer:Article ID="Article3" Caption="We Accept the following Credit Cards below:" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/Credits.jpg" alt="an image" style="float:left;" />

 </ContentTemplate></artisteer:Article>

</asp:Content>

