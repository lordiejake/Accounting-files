<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="Categories" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebarCategories.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Collections..
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
    <p>Jewelry for men has largely consisted of expensive watches or rings. rarely has a guy considered wearing a pendant. If the guy wears a pendant that is manly enough, it actually can make him look really good. 
    Jarich has designed some really amazing and manly jewelry which come with stainless steel or titanium.
    </p>
    	<span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="javascript:void(0)">Read more...</a>
    	</span>
    </p>
     <div class="art-content-layout overview-table">
            <div class="art-content-layout-row">
                <div class="art-layout-cell">
                    <div class="overview-table-inner">
                        <h4>
                            MEN Collections</h4>
                        <a href="Client-Men-Collection-Products-Jewelry-Main.aspx">
                        <img src="images/MenCollection.jpg"  alt="an image" class="image" />
                        </a>
                        <p>
                            
                        </p>
                    </div>
                </div>
                <!-- end cell -->
                <div class="art-layout-cell">
                    <div class="overview-table-inner">
                        <h4>
                            WOMEN Collections</h4>
                        <a href="Client-Women-Collection-Products-Jewelry-Main.aspx">
                        <img src="images/WomenCollection.jpg"  alt="an image" class="image" />
                        </a>
                        <p>
                           
                        </p>
                    </div>
                </div>
                <!-- end cell -->
                <div class="art-layout-cell">
                    <div class="overview-table-inner">
                        <h4>
                            KIDS Collections</h4>
                        <a href="Client-children-Collection-Products-Jewelry-Main.aspx">
                        <img src="images/KidsCollection.jpg" alt="an image" class="image" />
                        </a>
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
    </p>
    
    

 </ContentTemplate></artisteer:Article>

           <artisteer:Article ID="Article2" Caption="We Accept the following Credit Cards below:" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/Credits.jpg" alt="an image" style="float:left;" />

 </ContentTemplate></artisteer:Article>

</asp:Content>

