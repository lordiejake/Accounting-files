<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Admin-Control-Panel-IndexProductsDescriptionsPanel.aspx.cs" Inherits="Admin_Control_Panel_IndexProductsDescriptionsPanel" %>

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

<artisteer:Article ID="Article1" Caption="Product Description Panel" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/VS.png" alt="an image" style="float:left;border:0;margin: 1em 1em 0 0;" />
    <p>A birthday bracelet beading party for girls age 5 and up is guaranteed to be a big hit.Most girls are thrilled with the opportunity to make jewelry, and parents appreciate that you're providing both the party favors (the bracelets the girls make to take home) and the party activity (making the bracelets).</p>
    <p>Jewelry for men has largely consisted of expensive watches or rings. rarely has a guy considered wearing a pendant. If the guy wears a pendant that is manly enough, it actually can make him look really good. 
    Jarich has designed some really amazing and manly jewelry which come with stainless steel or titanium.
    </p>
    <p>Your marriage promise began with a piece of jewelry, the engagement ring, and continued on through the wedding bands that each partner wears.
     Jewelry, thus, makes a great gift to mark other special occasions--from birthdays to anniversaries to the birth of a child.
      Don't buy anything simply because it is the most popular selection. The popularity of a piece of jewelry shouldn't factor into what you buy for your wife. 
      All those other shoppers don't know your wife; you do.Take a look at what she already wears. Observe the jewelry that she buys for herself and the pieces that she wears the most often. 
      This will give you a sense of her style and what she feels comfortable in. Notice whether she chooses white metals--silver, white gold and platinum--or yellow gold.
       Also notice whether she wears larger pieces, such as 2 to 3 inch diameter hoop earrings, or smaller pieces, such as small gemstone studs.
       If you don't feel comfortable about what her jewelry tastes are just by observing her and her collection, ask either her mother, a sister or a close friend of hers. 
       Just be sure to swear the person that you ask into secrecy.</p>
        <span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="IndexAdminControlPanel.aspx">[Back-to-start-page]</a>
    	</span>
    </p>
           </ContentTemplate></artisteer:Article>
    
    <artisteer:Article ID="Article2" Caption="Create New Product" runat="server"><ContentTemplate>
        <br />

        <asp:Panel ID="CategoryExistsPanel" runat="server" Visible="False">
        <blockquote>
            <p>Incorrect Price Format</p>
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
                    Select Category: 
                </td>
                <td>
                    <asp:DropDownList ID="DrpCategory" Width="215px" runat="server"> </asp:DropDownList> <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator6" runat="server" ControlToValidate = "DrpCategory" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>      
            </tr>
            <tr>
                <td>
                    Select Gender Type: 
                </td>
                <td>
                    <asp:DropDownList ID="DrpGender" Width="215px" runat="server">
                    </asp:DropDownList>  <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator7" runat="server" ControlToValidate = "DrpGender" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>      
            </tr>
            <tr>
                <td>
                    Select a Collection(for): 
                </td>
                <td>
                    <asp:DropDownList ID="DrpCollections" Width="215px" runat="server">
                    </asp:DropDownList>  <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator8" runat="server" ControlToValidate = "DrpCollections" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>      
            </tr>


            <tr>
                <td>
                    Product Name: 
                </td>
                <td>
                    <asp:TextBox ID="txtproduct" runat="server" Width="215px"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1" runat="server" ControlToValidate = "txtproduct" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>      
            </tr>
            <tr>
                <td>
                    Product Description: 
                </td>
                <td>
                    <asp:TextBox ID="txtdescription" Width="215px" TextMode="MultiLine" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator2" runat="server" ControlToValidate = "txtdescription" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>      
            </tr>
            <tr>
                <td>
                    Price: 
                </td>
                <td>
                    <asp:TextBox ID="txtprice" Width="215px" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator3" runat="server" ControlToValidate = "txtprice" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>      
            </tr>
            <tr>
                <td>
                    Status: 
                </td>
                <td> 
                    <asp:TextBox ID="txtstatus" TextMode="MultiLine" Width="215px" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                        ID="RequiredFieldValidator4" runat="server" ControlToValidate = "txtstatus" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>      
            </tr>
            <tr>
                <td>
                    Browse Image: 
                </td>
                <td>
                    <asp:FileUpload ID="ImageUpload" runat="server" /> <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate = "ImageUpload" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>      
            </tr>
            <tr>
                <td>

                    <asp:Label ID="lblcat" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="lblgender" runat="server" Visible="False"></asp:Label>
                    <asp:Label ID="lblcollection" runat="server" Visible="False"></asp:Label>

                </td><td>
                    <asp:Button ID="btnCreate" CssClass="art-button" runat="server" Text="Create" 
                        onclick="btnCreate_Click" /></td>
            </tr>
        </table>
        <br />
        
    </ContentTemplate></artisteer:Article>

</asp:Content>
