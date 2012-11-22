<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Select-Products-Transactions-CkecksOut.aspx.cs" Inherits="Select_Products_Transactions_CkecksOut" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Checkout.
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
    
<artisteer:Article ID="Article1" Caption="Checkout now!" runat="server"><ContentTemplate>
<p>Be the one...Jewelry for men has largely consisted of expensive watches or rings. rarely has a guy considered wearing a pendant. If the guy wears a pendant that is manly enough, it actually can make him look really good. 
    Jarich has designed some really amazing and manly jewelry which come with stainless steel or titanium.
    </p>
 </ContentTemplate></artisteer:Article>


    <artisteer:Article ID="Article2" Caption="Specificatons" runat="server"><ContentTemplate>
   
    </ContentTemplate></artisteer:Article>

     <br />
        <table>
            <tr>
                <td style="vertical-align:top">
                    <div>
    <asp:GridView ID="GridImageRetrieve" runat="server" AutoGenerateColumns="False" 
                            DataKeyNames="Product_Num">
        <Columns>
            <asp:TemplateField HeaderText="Image">
              <ItemTemplate>
                  <asp:Image ID="Image1" ImageUrl='<%# "Handler.ashx?ImID="+ Eval("Product_Num") %>' Height="300px" Width= "280px" runat="server" />
              </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <PagerSettings Position="TopAndBottom" />
        <RowStyle HorizontalAlign="Left" VerticalAlign="Top" />
    </asp:GridView>
</div>
                </td>
                <td style="vertical-align:top">
                    <table>
                        <tr>
                            <td><h2 class="art-logo-text">Product Name:</h2></td><td><h2 class="art-logo-text">
                                <asp:Label ID="Label1" runat="server" Text="[Product Name]"></asp:Label></h2></td>
                        </tr>
                        <tr>
                            <td><h2 class="art-logo-text">Product Description:</h2></td><td><h2 class="art-logo-text"><asp:Label ID="Label2" runat="server" Text="[Product Description]"></asp:Label></h2></td>
                        </tr>
                        <tr>
                            <td><h2 class="art-logo-text">Price:</h2></td><td><h2 class="art-logo-text"><asp:Label ID="Label3" runat="server" Text="[Price]"></asp:Label></h2></td>
                        </tr>
                        <tr>
                            <td><h2 class="art-logo-text">Status:</h2></td><td><h2 class="art-logo-text"><asp:Label ID="Label4" runat="server" Text="[Status]"></asp:Label></h2></td>
                        </tr>
                        <tr>
                            <td><h2 class="art-logo-text"><asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
                                <asp:Label ID="Label6" runat="server" Visible="False"></asp:Label>
                                <asp:Label ID="Label7" runat="server" Visible="False"></asp:Label></h2></td><td><h2 class="art-logo-text">
                            <asp:ImageButton ID="ImageButton1" runat="server" 
                                ImageUrl="~/images/Collections/buyMe.gif" onclick="ImageButton1_Click" />
                            </h2></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>

           <artisteer:Article ID="Article3" Caption="We Accept the following Credit Cards below:" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/Credits.jpg" alt="an image" style="float:left;" />

 </ContentTemplate></artisteer:Article>
</asp:Content>

