<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddMedicine.aspx.cs" Inherits="AddMedicine" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Add Medicine</title>
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
        <li class="last"><span><asp:LinkButton ID="LinkButton3" runat="server" 
                onclick="LinkButton3_Click1" CausesValidation="False">LinkButton</asp:LinkButton></span></li>
    </ul>
</div>
</div>
</div>


	<div id="wrapper">
		<div id="page">
		<div id="page-bg">
			<div id="sidebar3" class="sidebar">
				<ul>
					
					<li>
					<h2>Categories Start--&gt;</h2>
					<br />
					<div id="side1">
					
							<ul>
							<hr id="hz"/>
							<br />
							    <li><asp:LinkButton ID="LinkButton1" runat="server" CausesValidation = "false" onclick="LinkButton1_Click">--[Back]--</asp:LinkButton></li><hr id="hz"/>
							  <li><asp:LinkButton ID="LinkButton2" CausesValidation ="false"   runat="server" 
                                      onclick="LinkButton2_Click">Add Diseases(Illness))</asp:LinkButton></li><hr id="hz"/>
							  <br />
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
					<p>•	Determine the effectiveness of Electronic Drug Guide Book for common illnesses among children.</p>
					<p>•	Develop an Electronic Drug Guide Book Web Application.</p>
				</div>
			</div>
			<hr />
		    <div class="post">
				<h1 class="title">Administrator: Add Medicines(Drugs)<a href="#"></h1>
			</div>
             <div>
                
                 <asp:Label ID="Label6" runat="server" ForeColor="White" Text="Label"></asp:Label>
                
             </div>               
			    <div>
			    <div class="entry">
					
					<div>
					    <fieldset>
					        <table>
					            <tr>
					                <td>
                                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#006600" Text="DrugName:"></asp:Label>
                                    </td>
                                    <td>
                                        
                                        <asp:TextBox ID="TextBox1" runat="server" Width="357px"></asp:TextBox>
                                        
                                    </td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  controltovalidate="TextBox1"  ErrorMessage="DrugName is Required!"></asp:RequiredFieldValidator></td>
					            </tr>
					            <tr>
					                <td>
                                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#006600" Text="GenericName:"></asp:Label>
                                    </td>
                                    <td>
                                        
                                        <a href="#">
                                        <asp:TextBox ID="TextBox2" runat="server" Width="357px"></asp:TextBox>
				</a>
                                        
                                    </td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  controltovalidate="TextBox2"   ErrorMessage="GenericName is Required!"></asp:RequiredFieldValidator></td>
					            </tr>
					            <tr>
					                <td>
                                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="#006600" Text="BrandName:"></asp:Label>
                                    </td>
                                    <td>
                                        
                                        <a href="#">
                                        <asp:TextBox ID="TextBox3" runat="server" Width="357px"></asp:TextBox>
				</a>
                                        
                                    </td>
                                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" controltovalidate="TextBox3"  ErrorMessage="BrandName is Required!"></asp:RequiredFieldValidator></td>
					            </tr>
					            <tr>
					                <td></td><td>
                                        <asp:Button ID="Button1" runat="server" Text="Save" Width="174px" 
                                            onclick="Button1_Click1" /></td>
					            </tr>
					            
					        </table>
					    </fieldset>
					</div>
					
				</div>
			</div>
			
			<div>
			    <fieldset id = "threadconfig"></fieldset>
				</a>
                <br />
                <br />
                <fieldset>
                    <div>
                        
                        <a href="#">
                        <div>
			        <fieldset>
                        <table>
                            <tr>
                                <td><asp:Label ID="Label7" runat="server" Text="Search:"></asp:Label></td>
                                <td><asp:TextBox ID="TextBox4" runat="server" Width="265px"></asp:TextBox></td>
                                <td><asp:Button ID="Button2" runat="server" Text="Search" CausesValidation="false" onclick="Button1_Click" 
                                        Width="87px" /></td>
                            </tr>
                        </table>
			        </fieldset>
			    </div>
                        
			    
			    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                    CellPadding="4" ForeColor="#333333" GridLines="None" Width="645px" 
                            DataKeyNames="DrugID" onrowcommand="GridView5_RowCommand">
                    <RowStyle BackColor="#E3EAEB" />
                    <Columns>
                        <asp:BoundField DataField="DrugID" HeaderText="Code" Visible="False" />
                        <asp:BoundField DataField="DrugName" HeaderText="DrugName" >
                            <ItemStyle Font-Underline="True" ForeColor="#003300" />
                        </asp:BoundField>
                        <asp:BoundField DataField="GenericName" HeaderText="GenericName" />
                        <asp:BoundField DataField="BrandName" HeaderText="BrandName" />
                        <asp:CommandField ShowSelectButton="True" SelectText="Manage">
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
			    
				</a>
                        
                    </div>
                </fieldset>
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
