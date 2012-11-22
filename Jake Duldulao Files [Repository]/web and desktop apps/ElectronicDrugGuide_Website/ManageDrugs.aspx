<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageDrugs.aspx.cs" Inherits="ManageDrugs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Welcome: Administrator</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
    function LoadImage(path, img) {
        imgPrev = document.images[img];
        imgPrev.src = path;
        }
        
</script>

    <style type="text/css">
        #fleUpload
        {
            width: 359px;
        }
        .Gridview
        {
            margin-right: 1px;
        }
        </style>
        
        
</head>
<body>
    <form id="form1" runat="server">
    <div id="header">
		
			<div id="logo">
				<h1> &nbsp;</h1>
                <p> &nbsp;</p>
                <p> &nbsp;</p>
			</div>		
			
			

<style type="text/css">

div#menu {


}

</style>
<div id="nocs">
<div id="menu">
    <ul class="menu">


        <li><a href="Illness.aspx?" class="parent"><span>Home</span></a>
            
        </li>
        <li><a href="DrugClasses.aspx?" class="parent"><span>Drug Class</span></a></li>
        <li><a href="AllDrugs.aspx?"><span>Drugs</span></a></li>
        <li class="last"><span>
            <asp:LinkButton ID="LinkButton4" runat="server" CausesValidation="False" 
                onclick="LinkButton4_Click">LinkButton</asp:LinkButton></span></li>
    </ul>
</div>
</div>
</div>


	<div id="wrapper">
		<div id="page">
		<div id="page-bg">
			<div id="sidebar1" class="sidebar">
				<ul>
					
					<li>
					<h2>Categories Start--&gt;</h2>
					<br />
					<div id="side1">
					
							<ul>
							<hr id="hz"/>
							<br />
							<li><asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Add Medicines(Drugs)</asp:LinkButton></li><hr id="hz"/>
							<li><asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Add Diseases(Illness))</asp:LinkButton></li><hr id="hz"/>
							<li><asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click">Manage Members(Clients)</asp:LinkButton></li><hr id="hz"/>
							<br />
							
					        </ul>
					</div>
					</li>
					
					
					
				</ul>
			</div>
			
			
			
			
		<div id="content">
		 <div class="post">
				<div>
                    <asp:Label ID="Label1" runat="server" 
                        Text="Electronic Drug Guide for common illness among Children" Font-Bold="True" 
                        Font-Size="Large" Font-Underline="True" ForeColor="#006600"></asp:Label></div>
			</div>
		<hr />
		<div>
            <asp:LinkButton ID="lnkuser" runat="server" Font-Bold="True" 
                Font-Underline="True"></asp:LinkButton>
		</div>
		<hr />
		<br />
		
		<div class="post">
				<h2 class="title"><a href="#">Administrator</a></h2>
				<div>
                    <asp:Label ID="Label2" runat="server" Text="Duldulao Jake V. : WEB Programmer" 
                        Font-Bold="True" Font-Underline="True" ForeColor="#003300"></asp:Label></div>
				<div class="entry">
					<p>•	Determine the effectiveness of Electronic Drug Guide Book for common 
                        illnesses among children.</p>
					<p>•	Develop an Electronic Drug Guide Book Web Application.<asp:Label 
                            ID="Label5" runat="server"></asp:Label>
                                <asp:Label ID="Label8" runat="server"></asp:Label>
                        <asp:Label ID="Label9" runat="server"></asp:Label>
                                </p>
				</div>
			</div>
			<hr />
			    <div>
                    <asp:LinkButton ID="LinkButton6" runat="server" onclick="LinkButton6_Click">[Manage 
                    Drugs -- For this illness]</asp:LinkButton>
                        </div>
			<hr />
		    <div class="post">
				<a><h1 class="title">Administrator: Manage Drugs[Illness]:<a href="#"></h1>
			</div>
                            
			    <div>
			    <div class="entry">
					
					<div>
					    <fieldset>
					        
                    <asp:Label ID="Label6" runat="server" 
                        Text="Drugs for: " Font-Bold="True" 
                        Font-Size="Large" Font-Underline="True" ForeColor="#006600"></asp:Label><a href="#">
                    <asp:Label ID="Label7" runat="server" 
                        Text="Drugs for: " Font-Bold="True" 
                        Font-Size="Large" Font-Underline="True" ForeColor="#006600"></asp:Label>
				</a>
					        
					    </fieldset>
					</div>
					
				</div>
			</div>
			<div>
			    <table>
			        <tr>
			            <td><asp:Label ID="Label3" runat="server" Text="Search:"></asp:Label></td><td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="467px" BackColor="#FFD2A6"></asp:TextBox>
                        </td><td>
                            <asp:Button ID="Button1" runat="server" Text="Search" Width="127px" 
                                onclick="Button1_Click" />
                        </td>
			        </tr>
			    </table>
			</div>
			<div>
			    <fieldset id = "threadconfig"></fieldset>
			    
			        <div>
			            
			    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="645px" 
                    onrowcommand="GridView5_RowCommand" DataKeyNames="DrugID">
                    <RowStyle BackColor="#E3EAEB" />
                    <Columns>
                        <asp:BoundField DataField="DrugName" HeaderText="DrugName" >
                            <ItemStyle Font-Underline="True" ForeColor="#003300" />
                        </asp:BoundField>
                        <asp:BoundField DataField="GenericName" HeaderText="GenericName" />
                        <asp:BoundField DataField="BrandName" HeaderText="BrandName" />
                        <asp:CommandField ShowSelectButton="True">
                            <ItemStyle Font-Bold="True" Font-Underline="True" ForeColor="#003300" />
                        </asp:CommandField>
                    </Columns>
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" 
                        HorizontalAlign="Left" VerticalAlign="Top" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <AlternatingRowStyle BackColor="White" />
                </asp:GridView>
			    
			        </div>
			    
			    <fieldset id = "threadconfig"></fieldset>
				</a>
                <br />
                <br />
			</div>
		</div>
		
		
		
		
		
			<div style="clear: both;">&nbsp;</div>
		</div>
		</div>
		
		
		
		
	</div>
	
	<div id="footer">
        <div id="footer-bg">
	    
	            <p class="link">&nbsp;</p>
	            <p class="copyright">&copy;&nbsp;&nbsp;Reprint authorized by Lippincott Williams & Wilkins &nbsp;&bull;&nbsp; Copyright &copy; <a href="#">Lipincott Williams & Wilkins</a>.</p>
	    
        </div>
    </div>
    <div style="text-align: center; font-size: 0.75em;"></div>
    </form>
</body>
</html>
