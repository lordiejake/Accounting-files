<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="IndexContacts.aspx.cs" Inherits="IndexContacts" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenuContacts.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Contacts..
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

<artisteer:Article ID="Article1" Caption="Contact Us" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    &nbsp;
    <p>
    <a href="javascript:void(0)" title="link"></a>, <a class="visited" href="javascript:void(0)" title="visited link"></a>,
     <a class="hover" href="javascript:void(0)" title="hovered link"></a> 
    </p>
    <p>
    	&nbsp;</p>
   <fieldset>
    <table>
    <tr>
              <td class="style1">
                  <asp:Label ID="Label1" runat="server" Text="Name" CssClass="style2"></asp:Label></td> <td>
                  <asp:TextBox ID="TextBox1" runat="server" Width="245px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                      ControlToValidate="TextBox1" ErrorMessage="**"></asp:RequiredFieldValidator>
             </td>
   </tr>
   <tr>

              <td class="style1">
                  <asp:Label ID="Label2" runat="server" Text="Company" CssClass="style2"></asp:Label></td> <td>
                  <asp:TextBox ID="TextBox2" runat="server" Width="245px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                      ControlToValidate="TextBox2" ErrorMessage="**"></asp:RequiredFieldValidator>
             </td>
    </tr>
    <tr>
              <td class="style1">
                  <asp:Label ID="Label3" runat="server" Text="Address" CssClass="style2"></asp:Label></td> <td>
                  <asp:TextBox ID="TextBox3" runat="server" Width="244px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                      ControlToValidate="TextBox3" ErrorMessage="**"></asp:RequiredFieldValidator>
             </td>
    </tr>
    <tr>
              <td class="style1">
                  <asp:Label ID="Label4" runat="server" Text="Mobile Number" CssClass="style2"></asp:Label></td> <td>
                  <asp:TextBox ID="TextBox4" runat="server" Width="243px"></asp:TextBox>
             </td>
    </tr>
    <tr>
              <td class="style1">
                  <asp:Label ID="Label5" runat="server" Text="Email Address" CssClass="style2"></asp:Label></td> <td>
                  <asp:TextBox ID="TextBox5" runat="server" Width="243px"></asp:TextBox>
                  <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                      ErrorMessage="Enter a valid email address" 
                      ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                      ControlToValidate="TextBox5"></asp:RegularExpressionValidator>
             </td>
    </tr>
    <tr>
              <td class="style1">
                  <asp:Label ID="Label6" runat="server" Text="Meesage, Comments or Suggestions" 
                      CssClass="style2"></asp:Label></td> <td>
                  <asp:TextBox ID="TextBox6" runat="server" Height="177px" TextMode="MultiLine" 
                      Width="241px"></asp:TextBox>
             </td>
    </tr>
    <tr>
    <td></td><td>  
        <asp:Button ID="Button1" runat="server" Text="Submit" Width="239px" 
            onclick="Button1_Click" /></td>
    
    </tr>
    
    
    </table>
    
    
    
    </fieldset>
    </ContentTemplate>
    </artisteer:Article>

</asp:Content>


<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ScriptIncludePlaceHolder">
  <script type="text/javascript" src="<%= ResolveUrl("~/jquery.js") %>"></script>
  <script type="text/javascript" src="<%= ResolveUrl("~/script.js") %>"></script>
    <style type="text/css">
        .style1
        {
            text-align: right;
            font-weight: bold;
        }
        .style2
        {
            font-size: large;
            color: white;
            font-family: "Times New Roman", Times, serif;
        }
    </style>
</asp:Content>



