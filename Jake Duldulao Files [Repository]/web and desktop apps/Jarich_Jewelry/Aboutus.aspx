<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Aboutus.aspx.cs" Inherits="Aboutus" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebarAboutus.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    About our business..
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

<artisteer:Article ID="Article1" Caption="Welcome" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/images.jpg" alt="an image" style="float:left;border:0;margin: 1em 1em 0 0;" />
    <p>
    <a href="javascript:void(0)" title="link"></a>, <a class="visited" href="javascript:void(0)" title="visited link"></a>,
     <a class="hover" href="javascript:void(0)" title="hovered link"></a>
     <p></p>
  <p>       Electronic commerce is commonly known as e-commerce is the selling of products or services over electronic systems such as the Internet and other computer networks. Electronic commerce draws on such technologies as electronic funds transfer, supply chain management, Internet marketing, online transaction processing, electronic data interchange(EDI), inventory management systems, and automated data collection systems. Modern electronic commerce typically uses the World Wide Web at least at one point in the transaction's life-cycle, although it may encompass a wider range of technologies such as e-mail, mobile devices and telephones as well. </p>
  <p>       The overall purpose of this project is to offer to avid and valued customers a convenient online shopping for jewelries or virtual mall of the latter that the customers can access wherever they are provided that an internet connection is available. </p>
 <p>This needs to be done because e-commerce ought to lead to intensified price competition, as it increases consumers' ability to gather information about products and prices.</p>
<p>The end result of this project is an ELECTRONIC JEWELRY SHOP where online shoppers can view jewelries in the online catalog, can make orders and make queries about a particular jewelry. 
This project needs to be done now to be able to open up new doors and opportunities to a business specially the Electronic Jewelry Shop.</p> 
<p> It gives the customers what they want right now, with no delay and queues at the checkouts. Little by little, shopping at an ecommerce store is becoming the order of the day leaving behind traditional ways of making a purchase.</p>


        <p>
        </p>
        <p>
            <span class="art-button-wrapper"><span class="art-button-l"></span>
            <span class="art-button-r"></span><a class="art-button" 
                href="javascript:void(0)">Read more...</a> </span>
        </p>
        <div class="cleared">
        </div>
        <div class="art-content-layout overview-table">
            <div class="art-content-layout-row">
                <div class="art-layout-cell">
                    <div class="overview-table-inner">
                        <h4>
                            SHOP</h4>
                        <img src="images/01.png" width="55" height="55" alt="an image" class="image" />
                        <p>
                           
                        </p>
                    </div>
                </div>
                <!-- end cell -->
                <div class="art-layout-cell">
                    <div class="overview-table-inner">
                        <h4>
                            SELECT</h4>
                        <img src="images/02.png" width="55" height="55" alt="an image" class="image" />
                        <p>
                            
                        </p>
                    </div>
                </div>
                <!-- end cell -->
                <div class="art-layout-cell">
                    <div class="overview-table-inner">
                        <h4>
                            SHIP</h4>
                        <img src="images/03.png" width="55" height="55" alt="an image" class="image" />
                        <p>
                           
                        </p>
                    </div>
                </div>
                <!-- end cell -->
            </div>
            <!-- end row -->
        </div>
        <!-- end table -->


        <p>
        </p>


        <p>
        </p>


        <p>
        </p>


        <p>
        </p>


        <p>
        </p>


        <p>
        </p>


</p>
           </ContentTemplate></artisteer:Article>
    <artisteer:Article ID="Article2" Caption="" runat="server"><ContentTemplate><p>Lorem <sup>superscript</sup> dolor <sub>subscript</sub> amet, consectetuer adipiscing elit, <a href="#" title="test link">test link</a>.
    	
    
            <p>
                &#8220;The items sold in the category list is not for sale. This web application is for accademic purposes only!.&#8221;
                <br />
              
            </p>
        </blockquote>
    
        <br />
    
    
    	<p>
    		<span class="art-button-wrapper">
    			<span class="art-button-l"> </span>
    			<span class="art-button-r"> </span>
    			<a class="art-button" href="javascript:void(0)">Join&nbsp;Now!</a>
    		</span>
    	</p>
           </ContentTemplate></artisteer:Article>
    

</asp:Content>
