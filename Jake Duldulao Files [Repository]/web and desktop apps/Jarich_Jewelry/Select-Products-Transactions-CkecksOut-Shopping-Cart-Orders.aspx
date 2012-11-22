<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Select-Products-Transactions-CkecksOut-Shopping-Cart-Orders.aspx.cs" Inherits="Select_Products_Transactions_CkecksOut_Shopping_Cart_Orders" %>


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
    
<artisteer:Article ID="Article1" Caption="List of Orders" runat="server"><ContentTemplate>
<p>Be the one...Jewelry for men has largely consisted of expensive watches or rings. rarely has a guy considered wearing a pendant. If the guy wears a pendant that is manly enough, it actually can make him look really good. 
    Jarich has designed some really amazing and manly jewelry which come with stainless steel or titanium.
    </p>
    <p>
                <span class="art-button-wrapper"><span class="art-button-l"></span>
                <span class="art-button-r"></span><a class="art-button" 
                    href="Default.aspx">
                [Continue Shopping - Back to Home Page]</a> </span>
            </p>
 </ContentTemplate></artisteer:Article>

 <artisteer:Article ID="Article3" Caption="Available Credits" runat="server"><ContentTemplate>
    <div>
        <table>
            <tr>
                <td><h5 class="art-logo-text">Select Credit Card:</h5></td>
                <td style=" vertical-align: bottom;">
                    <asp:DropDownList ID="DropDownCreditCards" CssClass="art-button" runat="server" 
                        Height="16px" Width="200px" 
                        onselectedindexchanged="DropDownCreditCards_SelectedIndexChanged">
                        <asp:ListItem>[Select Credit Card]</asp:ListItem>
                        <asp:ListItem>[Visa]</asp:ListItem>
                        <asp:ListItem>[Master Card]</asp:ListItem>
                        <asp:ListItem>[American Express]</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="btnGo" runat="server" CssClass="art-button" Text="Proceed" 
                        onclick="btnGo_Click" CausesValidation="False" />
                </td>
                
            </tr>

            <asp:Panel ID="Panel1" Visible="false" runat="server">
            <tr>
                <td><h5 class="art-logo-text">Enter Credit Card Number [Visa]</h5></td>
                <td style=" vertical-align: bottom;">
                    <asp:TextBox ID="txtvisaValidation" runat="server"></asp:TextBox> 
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="Gold" runat="server" ControlToValidate="txtvisaValidation"  ValidationExpression="^4[0-9]{12}(?:[0-9]{3})?$"  ErrorMessage="Please enter valid Card # for [Visa]" ></asp:RegularExpressionValidator>
                </td>
            </tr>
            </asp:Panel>

            <asp:Panel ID="Panel2" Visible="false" runat="server">
            <tr>
                <td><h5 class="art-logo-text">Enter Credit Card Number [Master Card]</h5></td>
                <td style=" vertical-align: bottom;">
                    <asp:TextBox ID="txtMasterCardNumber" runat="server"></asp:TextBox> 
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ForeColor="Gold" runat="server" ControlToValidate="txtMasterCardNumber"  ValidationExpression="^5[1-5][0-9]{14}$"  ErrorMessage="Please enter valid Card # for [Master Card]" ></asp:RegularExpressionValidator>
                </td>
            </tr>
            </asp:Panel>

            <asp:Panel ID="Panel3" Visible="false" runat="server">
            <tr>
                <td><h5 class="art-logo-text">Enter Credit Card Number [American Express]</h5></td>
                <td style=" vertical-align: bottom;">
                    <asp:TextBox ID="txtAmericanExpressNumber" runat="server"></asp:TextBox> 
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" ForeColor="Gold" runat="server" ControlToValidate="txtAmericanExpressNumber"  ValidationExpression="^3[47][0-9]{13}$"  ErrorMessage="Please enter valid Card # for [American Express]" ></asp:RegularExpressionValidator>
                </td>
            </tr>
            </asp:Panel>

        </table>
    </div>
 </ContentTemplate></artisteer:Article>


    <asp:Panel ID="Panel4" runat="server">
    
    <artisteer:Article ID="Article2" Caption="Cart item/s" runat="server"><ContentTemplate>
   
    </ContentTemplate></artisteer:Article>
    </asp:Panel>

    <asp:Panel ID="Panel5" runat="server">
    <artisteer:Article ID="Article4" Visible = "false" Caption="Thank you. We Will notify you for your Order." runat="server"><ContentTemplate>
   
    </ContentTemplate></artisteer:Article>
     </asp:Panel>

     <fieldset>
     <br />
     <div>
    <asp:GridView ID="GridImageRetrieve" runat="server" AutoGenerateColumns="False" 
             DataKeyNames="orderFacts_Num" BackColor="#DEBA84" BorderColor="#DEBA84" 
             BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" 
             onrowcommand="GridImageRetrieve_RowCommand" 
             onrowdatabound="GridImageRetrieve_RowDataBound" 
             onselectedindexchanged="GridImageRetrieve_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="orderFacts_Num" HeaderText="detailsid" 
                Visible="False" />
            <asp:BoundField DataField="Product_Num_stored" HeaderText="id" />
            <asp:BoundField DataField="Product_Name_stored" HeaderText="ProductName" />
            <asp:BoundField DataField="Product_Description_stored" 
                HeaderText="Description" />
            <asp:BoundField DataField="Product_Price_stored" HeaderText="Price" />
            <asp:BoundField DataField="Product_Status_stored" HeaderText="Status" />
            <asp:BoundField DataField="ProductItemsStored" HeaderText="Quantity" />
            <asp:BoundField DataField="ProductAmountStored" HeaderText="Total" />
            <asp:CommandField SelectText="[Delete]" ShowSelectButton="True" />
            <asp:ButtonField CommandName="SelectEdit" Text="[Edit]" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerSettings Position="TopAndBottom" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle HorizontalAlign="Left" VerticalAlign="Top" BackColor="#FFF7E7" 
            ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
         <br />
</div>
<div>
    <table>
        <tr>
            <td><h2 class="art-logo-text">Total:</h2></td><td><h2 class="art-logo-text">
                <asp:Label ID="lbltotal" runat="server" Text=""></asp:Label></h2></td>
        </tr>
    </table>
</div>
<div>
    <asp:Panel ID="PanelEdit" Visible = "false" runat="server">
        <table>
             <tr>
                <td><h2 class="art-logo-text">Product Name:</h2></td>
                <td><h2 class="art-logo-text"><asp:Label ID="LblProductNameEdit" runat="server" Text=""></asp:Label>
                </h2></td>
            </tr>
            <tr>
                <td><h2 class="art-logo-text">Quantity:</h2></td>
                <td><h2 class="art-logo-text"><asp:TextBox ID="txtQuantityEdit" runat="server" 
                        Width="155px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                            runat="server" ControlToValidate="txtQuantityEdit" ErrorMessage="*"></asp:RequiredFieldValidator>
                </h2></td>
            </tr>
            <tr>
                <td><h2 class="art-logo-text"></h2></td>
                <td><h2 class="art-logo-text">
                    <asp:Button ID="Btnedit" CssClass="art-button" runat="server" Text="Save" onclick="Btnedit_Click" />
                </h2></td>
            </tr>
            <tr>
                <td><h2 class="art-logo-text"></h2></td>
                <td><h2 class="art-logo-text">
                    <asp:TextBox ID="TxtPrice" runat="server" 
                        Width="155px" Visible="False"></asp:TextBox>
                </h2></td>
            </tr>
            <tr>
                <td><h2 class="art-logo-text"></h2></td>
                <td><h2 class="art-logo-text">
                    <asp:TextBox ID="txttotal" runat="server" 
                        Width="155px" Visible="False"></asp:TextBox>
                </h2></td>
            </tr>
            <tr>
                <td><h2 class="art-logo-text"></h2></td>
                <td><h2 class="art-logo-text">
                    <asp:TextBox ID="txtorderCartId" runat="server" 
                        Width="155px" Visible="False"></asp:TextBox>
                </h2></td>
            </tr>
            <tr>
                <td><h2 class="art-logo-text"></h2></td>
                <td><h2 class="art-logo-text">
                    <asp:TextBox ID="Txtcustomer" runat="server" 
                        Width="155px" Visible="False" ></asp:TextBox>
                </h2></td>
            </tr>
            <tr>
                <td><h2 class="art-logo-text"></h2></td>
                <td><h2 class="art-logo-text">
                    <asp:TextBox ID="txtcustomerbalanceGeneral" runat="server" 
                        Width="155px" Visible="False" ></asp:TextBox>
                </h2></td>
            </tr>
            <tr>
                <td><h2 class="art-logo-text"></h2></td>
                <td><h2 class="art-logo-text">
                    <asp:TextBox ID="txtcustomerbalanceGeneralFinal" runat="server" 
                        Width="155px" Visible="False" ></asp:TextBox>
                </h2></td>
            </tr>
            <tr>
                <td><h2 class="art-logo-text"></h2></td>
                <td><h2 class="art-logo-text">
                    <asp:TextBox ID="txtOrderNum" runat="server" 
                        Width="155px" Visible="False" ></asp:TextBox>
                </h2></td>
            </tr>
        </table>
    </asp:Panel>
</div>
<br />
    <div>
        <asp:Button ID="BtnRefresh" runat="server" Text="Refresh[Calculate]" 
            onclick="BtnRefresh_Click" CausesValidation="False" />
    </div>
</fieldset>

<br />
<br />
<div>

    <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/images/buy-now.jpeg" onclick="ImageButton1_Click" 
        CausesValidation="False" />

    <br />

    <br />

</div>


           <artisteer:Article ID="Articlewe" Caption="We Accept the following Credit Cards below:" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/Credits.jpg" alt="an image" style="float:left;" />

 </ContentTemplate></artisteer:Article>
</asp:Content>

