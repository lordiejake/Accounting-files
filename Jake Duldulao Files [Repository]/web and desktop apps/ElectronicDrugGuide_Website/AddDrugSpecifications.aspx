<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddDrugSpecifications.aspx.cs" Inherits="AddDrugSpecifications" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Dosage: Side Effects: Drug Class</title>
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
        <li class="last"><span><asp:LinkButton ID="LinkButton7" runat="server" 
                onclick="LinkButton7_Click">LinkButton</asp:LinkButton></span></li>
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
					<h2>Category</h2>
			<hr />
					<br />
					<div id="side1">
						<ul>
							<hr id="hz"/>
							<br />
							<li><asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton1_Click" 
                                    ForeColor="White">----[Back]----</asp:LinkButton></li><hr id="hz"/>
							<li><asp:LinkButton ID="LinkButton3" CausesValidation ="false"   runat="server" 
                                    onclick="LinkButton3_Click">Add Diseases(Illness))</asp:LinkButton></li><hr id="hz"/>
							
						</ul>
					</div>
					</li>
					
					
					
					<li>
					<br />
					    
					<br />
					
					</div>
					</li>
					
					<ul>
					
				</ul>
			</div>
			
			
			
			
		<div id="content">
		 <div class="post">
				<div>
                    <asp:Label ID="Label3" runat="server" 
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
				<h2 class="title"><a href="#">Objectives: it aims to--</a></h2>
				<div>
                    <asp:Label ID="Label4" runat="server" Text="Duldulao Jake V. : WEB Programmer" 
                        Font-Bold="True" Font-Underline="True" ForeColor="#003300"></asp:Label></div>
				<div class="entry">
					<p>•	Determine the effectiveness of Electronic Drug Guide Book for common illnesses among children.</p>
					<p>•	Develop an Electronic Drug Guide Book Web Application.</p>
				</div>
			</div>
			<div>
			    <table>
			        <tr>
			            <td>
                            <asp:Label ID="Label11" runat="server" ForeColor="White"></asp:Label>
                        </td>
			            <td>
                            <asp:Label ID="Label12" runat="server" ForeColor="White"></asp:Label>
                            <asp:Label ID="Label13" runat="server" ForeColor="White"></asp:Label>
                            <asp:Label ID="Label14" runat="server" ForeColor="White"></asp:Label>
                            <asp:Label ID="Label15" runat="server" ForeColor="White"></asp:Label>
                            <asp:Label ID="Label16" runat="server" ForeColor="White"></asp:Label>
                            <asp:Label ID="Label17" runat="server" Text="Label" ForeColor="White"></asp:Label>
                            <asp:Label ID="Label18" runat="server" ForeColor="White"></asp:Label>
                            <asp:Label ID="Label19" runat="server"></asp:Label>
                        </td>
			        </tr>
			    </table>
			</div>
			<hr />
		    <div class="post">
				<div>
                    <asp:Label ID="Label1" runat="server" Text="SIDE EFFECTS OF:" 
                        Font-Bold="True" Font-Size="Large" Font-Underline="True" 
                        ForeColor="#003300"></asp:Label></div>
			</div>
			<div>
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" ForeColor="Green">----[Back]----</asp:LinkButton>
			</div>
			<div>
                        <asp:Label ID="lblViewMembers" runat="server" Font-Bold="True" 
                            Font-Size="X-Large" Font-Underline="True" ForeColor="#006600"></asp:Label>
                        <br />
                    </div>
             <div>
                <fieldset>
                    <div>
                        
                    <asp:Label ID="Label6" runat="server" Text="Drug Class:" 
                        Font-Bold="True" Font-Size="Large" Font-Underline="True" 
                        ForeColor="#003300"></asp:Label>
                        
                    </div>
                    <div>-Add Drug Class-</div>
                    <div>
                        <table>
                            <tr>
                                <td>
                                    <asp:TextBox ID="TextBox4" runat="server" BackColor="#FFE6CC" Width="520px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Button ID="Button4" runat="server" Text="Save" onclick="Button4_Click" 
                                        Width="105px" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div>
                        <asp:LinkButton ID="LinkButton6" runat="server" Font-Bold="True" 
                            Font-Underline="True" onclick="LinkButton6_Click" Visible="False"></asp:LinkButton>
                    </div>
                    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False" 
                        ShowHeader="False" Width="638px">
                        <Columns>
                            <asp:BoundField DataField="drugClass" HeaderText="DrugClass:">
                                <HeaderStyle HorizontalAlign="Left" />
                                <ItemStyle Font-Bold="True" ForeColor="#003300" />
                            </asp:BoundField>
                        </Columns>
                    </asp:GridView>
                    
                </fieldset>
             </div>
                     
             <hr />
             
             <fieldset>
             <div>
                        
                    <asp:Label ID="Label7" runat="server" Text="Available Forms" 
                        Font-Bold="True" Font-Size="Large" Font-Underline="True" 
                        ForeColor="#003300"></asp:Label>
                        
             </div>
             <div>
                    <div>
			            <table>
			                <tr>
			                    <td>-Add Forms-</td>
			                </tr>
			                <tr>
			                    <td>
                                    <asp:TextBox ID="TextBox3" runat="server" Width="523px" BackColor="#FFE6CC"></asp:TextBox>
			                    </td>
			                    <td>
                                    <asp:Button ID="Button3" runat="server" Text="Save" Width="103px" 
                                        onclick="Button3_Click" /> 
			                    </td>
			                </tr>
			                <tr>
			                    <td>
                                    <asp:Label ID="Label8" runat="server" Font-Bold="True"></asp:Label>
                                    </td>
			                </tr>
			                <tr>
			                    <td>
			                        
			                        <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" 
                                        Font-Underline="True" onclick="LinkButton4_Click" Visible="False"></asp:LinkButton>
			                        
			                    </td>
			                </tr>
			            </table>
			        </div>
			        
                    <asp:GridView ID="GridView6" runat="server" AutoGenerateColumns="False" 
                        ShowHeader="False" Width="638px">
                        <Columns>
                            <asp:BoundField DataField="AvailableForms">
                                <HeaderStyle HorizontalAlign="Left" />
                                <ItemStyle Font-Bold="True" ForeColor="#003300" />
                            </asp:BoundField>
                        </Columns>
                    </asp:GridView>
                    
             </div>
             </fieldset>
             
             
                <div>
                    <asp:Label ID="Label2" runat="server" Text="These are the SIDE effects:" Font-Bold="True" 
                        Font-Size="Large" Font-Underline="True" ForeColor="#003300"></asp:Label></div>
             <hr />               
             <div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			    <div>
			        <fieldset>
			        <div>
			            <table>
			                <tr>
			                    <td>-Add Side Effects-</td>
			                </tr>
			                <tr>
			                    <td>
                                    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="523px" 
                                        BackColor="#FFE6CC"></asp:TextBox>
			                    </td>
			                    <td>
                                    <asp:Button ID="Button2" runat="server" Text="Save" Width="103px" 
                                        onclick="Button2_Click" /> 
			                    </td>
			                </tr>
			                <tr>
			                    <td>
                                    <asp:Label ID="Label9" runat="server" Font-Bold="True"></asp:Label>
                                    </td>
			                </tr>
			                <tr>
			                    <td>
                                    <asp:LinkButton ID="LinkButton5" runat="server" Font-Bold="True" 
                                        Font-Underline="True" onclick="LinkButton5_Click" Visible="False"></asp:LinkButton>
                                </td>
			                </tr>
			            </table>
			        </div>
			        
			            <div>
			                
			                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" GridLines="None" Width="635px">
                                <RowStyle BackColor="#E3EAEB" />
                                <Columns>
                                    <asp:BoundField DataField="SideEffects" HeaderText="Side Effects" />
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
			        </fieldset>
			    </div>
			 <div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			
			<hr />
			    <div class="post">
				<asp:Label ID="Label5" runat="server" Text="Dosage:" 
                        Font-Bold="True" Font-Size="Large" Font-Underline="True" 
                        ForeColor="#003300"></asp:Label>
			</div>
			<hr />
			<div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			
			<div>
			    <fieldset>
			    
			        <div>
			            <table>
			                <tr>
			                    <td>-Add Dosage-</td>
			                </tr>
			                <tr>
			                    <td>
                                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="523px" 
                                        BackColor="#FFE6CC"></asp:TextBox>
			                    </td>
			                    <td>
                                    <asp:Button ID="Button1" runat="server" Text="Save" Width="103px" 
                                        onclick="Button1_Click" /> 
			                    </td>
			                </tr>
			                <tr>
			                    <td>
                                    <asp:Label ID="Label10" runat="server" Font-Bold="True"></asp:Label>
                                    </td>
			                </tr>
			            </table>
			        </div>
			        <div>
			                
			                <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" 
                                CellPadding="4" ForeColor="#333333" GridLines="None" Width="635px">
                                <RowStyle BackColor="#E3EAEB" />
                                <Columns>
                                    <asp:BoundField DataField="Dosage" HeaderText="Dosage" >
                                        <ItemStyle ForeColor="#003300" />
                                    </asp:BoundField>
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
			    </fieldset>
			</div>
			<div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			<div class="post">
				</a>
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
