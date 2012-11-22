<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="IndexLogin.aspx.cs" Inherits="IndexLogin" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenuLogin.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
   Users Login..
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

<artisteer:Article ID="Article1" Caption="Welcome(Please Login)" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/VS.png" alt="an image" style="float:left;border:0;margin: 1em 1em 0 0;" />
    <p>YOU NEED TO LOGIN before continuing your orders.Lorem ipsum dolor sit amet,
    <a href="javascript:void(0)" title="link">link</a>, <a class="visited" href="IndexRegister.aspx" title="visited link">please register here</a>,
     <a class="hover" href="javascript:void(0)" title="hovered link">hovered link</a> consectetuer
    adipiscing elit. Quisque sed felis. Aliquam sit amet felis. Mauris semper,
    velit semper laoreet dictum, quam diam dictum urna, nec placerat elit nisl
    in quam. Etiam augue pede, molestie eget, rhoncus at, convallis ut, eros.</p>
   
   <div>
       <asp:Login ID="UserLogin" runat="server" Height="135px" 
           onauthenticate="UserLogin_Authenticate" onloginerror="UserLogin_LoginError" 
           Width="303px">
       </asp:Login>
   </div>
    <div class="cleared"></div>
    <div class="art-content-layout overview-table">
    	<div class="art-content-layout-row">
    		<div class="art-layout-cell">
          <div class="overview-table-inner">
    	      <h4>Support</h4>
    						  <img src="images/01.png" width="55" height="55" alt="an image" class="image" />
    						  <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.
    						  Quisque sed felis. Aliquam sit amet felis. Mauris semper,
    						  velit semper laoreet dictum, quam diam dictum urna. </p>
           </div>
    		</div><!-- end cell -->
    		<div class="art-layout-cell">
        <div class="overview-table-inner">
    		  <h4>Development</h4>
    						  <img src="images/02.png" width="55" height="55" alt="an image" class="image" />
    						  <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.
    						  Quisque sed felis. Aliquam sit amet felis. Mauris semper,
    						  velit semper laoreet dictum, quam diam dictum urna. </p>
    				</div>
    		</div><!-- end cell -->
    		<div class="art-layout-cell">
        <div class="overview-table-inner">
    		  <h4>Strategy</h4>
    
    						  <img src="images/03.png" width="55" height="55" alt="an image" class="image" />
    						  <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit.
    						  Quisque sed felis. Aliquam sit amet felis. Mauris semper,
    						  velit semper laoreet dictum, quam diam dictum urna. </p>
                  </div>
    		</div><!-- end cell -->
    	</div><!-- end row -->
    </div><!-- end table -->
           </ContentTemplate></artisteer:Article>
</asp:Content>


