<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="IndexAbout.aspx.cs" Inherits="IndexAbout" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenuAbout.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    About our Business..
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

<artisteer:Article ID="Article1" Caption="Welcome to Jarich's Online Store" runat="server"><ContentTemplate>
   
    <img src="images/images.jpg" alt="an image" style="float:left;border:0;margin: 1em 1em 0 0;" />
    <p>Jarich's Jewelers in Kabacan, North Cotabato was founded by Marichu Canonigo in 2010 the name Jarich is a coined name between Marichu and Jake. 
       Jake is her former boyfriend and her future partner in life. Wahahahahaha!!</p>
       <p>
       The atmosphere our customers experience at our jewelry store is very important to us. Our clientele rely on our expertise and our selections including top designer jewelry such as Charles E. designs. From clocks to wristwatches to designer and custom made jewelry topped with quality repair and maintenance services administered by expert employees we do our best to offer personal customer service, our knowledge and experience with trust our customers can count on.
       
       </p>
       <p> 
       Our employees have jewelry industry expertise and have been with us for a long time. The fine jewelry business requires they meet the standards and criteria that comes from apprenticeship training and accumulated years of experience from a quality jeweler. We cherish our nine employees who have amassed nearly 300 years combined experience for their expertise and the gracious way they treat our customers, and our customers, some of them third generation, appreciate the fact that they see the same familiar faces every time they come in the store.
       </p>
       <p>
       An employee since 2010, Marichu Canonigo exemplifies quality customer service through sales and special orders. Our fine goldsmiths including master jeweler Rob Comfort, in this generation jeweler Jeff Martin and Deo Gajadhar repair most jewelry on our premises. Michael Martin is our watchmaker, and our customers really appreciate his expertise when they need new watches or watch repair. Martha Stephenson has been our jewelry designer since the day that Jarich’s store was built and has more than 32 years experience in the jewelry industry. Our clientele is in good hands with our appraiser John Campbell. Our manager Jake Duldulao with his team, assistant manager Jarich Duldulao and Marlou Jhon Canonigo round out the office staff. We have a great staff and their goal is to provide the best service in all areas of their expertise.
       </p>
       <p>
       At Jarich's Jewelers, service means much more than just the sale. We have gained a competitive edge because we can respond more rapidly to clientele needs by providing consistent customer service and ensure that all of our commitments are met in a timely manner, however sometimes it takes longer to work on a piece of jewelry. In those cases, customer satisfaction reigns over hastiness.
       </p>
       <p>
       Customizing each piece of fine jewelry requires passion, care and expertise. Designing custom jewelry is one of our most sought after services with many customers requesting the creation of a one-of-a-kind piece of fine jewelry. We strive on creating that special piece of jewelry that no one else has, and we are pleased to accept all previous design ideas or images you may have in preparing your custom order.
       </p>
       <p>
       Jarich's Jewelers is one of the oldest businesses remaining in Kabacan, and we pride ourselves in our longevity. Jarich’s built their name before they built their business and their loyal customers have trusted them for years with their products and services. Whether you are our customer or not, if you own a piece of jewelry that needs cleaning, stop by Jarich’s Jewelers in Kabacan, North Cotabato and we'll do it free of charge.
       </p>
    <p>
    	<span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="javascript:void(0)">Read more...</a>
    	</span>
    </p>
    
       
           </ContentTemplate></artisteer:Article>

</asp:Content>


