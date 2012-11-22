<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="Client-children-Collection-Products-Jewelry-Main.aspx.cs" Inherits="Client_children_Collection_Products_Jewelry_Main" %>

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

<artisteer:Article ID="Article1" Caption="Kids Collections" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/KidsCollection.jpg" alt="an image" style="float:left;border:0;margin: 1em 1em 0 0;" />
    <p>A birthday bracelet beading party for girls age 5 and up is guaranteed to be a big hit.Most girls are thrilled with the opportunity to make jewelry, and parents appreciate that you're providing both the party favors (the bracelets the girls make to take home) and the party activity (making the bracelets).</p>
    <p>Kids and creativity go hand in hand. Craft kits make it easy for kids to spend their time being creative. You'll find a variety of craft kits for kids to explore at Weekend Kits.

My daughter learned to knit using the Yarn Craft Activity Kit from Alex. It's a great beginner's kit with everything a child needs to get started knitting right away. This kit includes knitting needles, a crochet hook, yarn needle, and instructions - all contained in a convenient wicker style carrying case.

I've included a snapshot of Kelly's first knitting project using this kit - an adorable yellow scarf with orange tassels. She really enjoyed creating this scarf (which she affectionately dedicated to her favorite Webkinz Google) and was very proud of learning this new skill at 9 years of age! It was a rewarding experience for everyone.</p>
    <p>
        <span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Default.aspx">[Back-to-start-page]</a>
    	</span>
    </p>
           </ContentTemplate></artisteer:Article>
    
    <artisteer:Article ID="Article2" Caption="Kids Collections Categories" runat="server"><ContentTemplate>
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


    </ContentTemplate></artisteer:Article>

           <artisteer:Article ID="Article3" Caption="We Accept the following Credit Cards below:" runat="server"><ContentTemplate>
    <img src="images/preview.jpg" alt="an image" style="float:left;" />
    <img src="images/Credits.jpg" alt="an image" style="float:left;" />

 </ContentTemplate></artisteer:Article>
</asp:Content>

