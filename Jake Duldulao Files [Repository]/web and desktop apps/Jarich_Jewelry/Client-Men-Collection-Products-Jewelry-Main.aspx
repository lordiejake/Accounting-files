<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Client-Men-Collection-Products-Jewelry-Main.aspx.cs" Inherits="Client_Men_Collection_Products_Jewelry_Main" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Get Started.
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

<artisteer:Article ID="Article1" Caption="Men Collections" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/MenCollection.jpg" alt="an image" style="float:left;border:0;margin: 1em 1em 0 0;" />
    <p>Jewelry for men has largely consisted of expensive watches or rings. rarely has a guy considered wearing a pendant. If the guy wears a pendant that is manly enough, it actually can make him look really good. 
    Jarich has designed some really amazing and manly jewelry which come with stainless steel or titanium.
    </p>
    <p>
    Jarich’s range of men’s jewelry includes pendants, necklaces and crosses. They are all priced quite affordably and look really good. though they may not be expensive, they are certainly sleek and stylish. Guys can wear cross pendants when they are out clubbing or even when out on a date.
    
    </p>
    <p>
    Unfortunately, many guys shy away from wearing jewelry as that is still not accepted in Western Culture. I would say, if this guy can look good wearing that pendant, why not you? You would just need to be a little adventurous and get these pieces of pendants in order to look good and handsome.
    </p>
    
        <span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Default.aspx">[Back-to-start-page]</a>
    	</span>
    </p>
           </ContentTemplate></artisteer:Article>
    
    <artisteer:Article ID="Article2" Caption="Men Collections Categories" runat="server"><ContentTemplate>
        <div>
            <ul>
                <li>
		          <a href="Client-Genders-Collection-Products-Jewelry-Main-Birthday-Jewelry.aspx"><span class="l"></span><span class="r"></span><span class="t">Birthday Jewelry</span></a>
			    </li> 
                <li>
		          <a href="Client-Genders-Collection-Products-Jewelry-Main-Graduation-Jewelry.aspx"><span class="l"></span><span class="r"></span><span class="t">Graduation Jewelry</span></a>
			    </li> 
                <li>
		          <a href="Client-Genders-Collection-Products-Jewelry-Main-Wedding-Jewelry.aspx"><span class="l"></span><span class="r"></span><span class="t">Wedding Jewelry</span></a>
			    </li> 
                <li>
		          <a href="Client-Genders-Collection-Products-Jewelry-Main-Music-Icon-Jewelry.aspx"><span class="l"></span><span class="r"></span><span class="t">Music Icon Jewelry</span></a>
			    </li> 
                <li>
		          <a href="Client-Genders-Collection-Products-Jewelry-Main-extreme-fasion-jewelry.aspx"><span class="l"></span><span class="r"></span><span class="t">Extreme Fashion Jewelry</span></a>
			    </li> 
            </ul>
        </div>
    </ContentTemplate></artisteer:Article>
    
           <artisteer:Article ID="Article3" Caption="We Accept the following Credit Cards below:" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/Credits.jpg" alt="an image" style="float:left;" />

 </ContentTemplate></artisteer:Article>

</asp:Content>
