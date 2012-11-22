<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUP.aspx.cs" Inherits="SignUP" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Log in</title>
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
             <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                 onclick="LinkButton1_Click1">LinkButton</asp:LinkButton></span></li>
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
					<h2>Other Diseases/Illness</h2>
					<br />
					<div id="side1">
						<ul>
							<hr id="hz"/>
							<li><a href="Diphtheria.aspx?">diphtheria</a></li><hr id="hz"/>
							<li><a href="Influenza.aspx?">Influenza</a></li><hr id="hz"/>
							<li><a href="HookWorm.aspx?">hookworm</a></li><hr id="hz"/>
							<li><a href="Meningitis.aspx?">meningitis</a></li><hr id="hz"/>
							<li><a href="Mumps.aspx?">mumps</a></li><hr id="hz"/>
							<li><a href="Ringworm.aspx?">ringworm</a></li><hr id="hz"/>
							<li><a href="Trush.aspx?">thrush</a></li><hr id="hz"/>
							<li><a href="Tubercolosis.aspx?">tubercolosis</a></li><hr id="hz"/>
							<li><a href="Tetanus.aspx?">tetanus</a></li><hr id="hz"/>
							<li><a href="Poliomyelitis.aspx?">poliomyelitis</a></li><hr id="hz"/>
						</ul>
					</div>
					</li>
					
					
					
					<li>
					<br />
					    <div>
					            
					    </div>
					<br />
					
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
				<h2 class="title"><a href="#">Objectives: it aims to--</a></h2>
				<div>
                    <asp:Label ID="Label2" runat="server" Text="Duldulao Jake V. : WEB Programmer" 
                        Font-Bold="True" Font-Underline="True" ForeColor="#003300"></asp:Label></div>
				<div class="entry">
					<p style="width: 650px">•	Determine the effectiveness of Electronic Drug Guide Book for common illnesses among children.</p>
					<p>•	Develop an Electronic Drug Guide Book Web Application.<asp:Label 
                            ID="lblsession" runat="server"></asp:Label>
                    </p>
				</div>
			</div>
			<hr />
		    <div class="post">
				<h1 class="title"><a href="#">Sign Up:</h1>
			</div>
			<hr />
			<div>
                        <asp:Label ID="lblViewMembers" runat="server" Font-Bold="True" 
                            Font-Size="Large" Font-Underline="True" ForeColor="#006600">Sign Up here..</asp:Label></div>
                            
			<hr />
			    
			<div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			
			<div>
			    <fieldset>
			        <table>
			            <tr>
			                <td>
                                <asp:Label ID="Label3" runat="server" Text="Last name:" Font-Bold="True" 
                                    ForeColor="#003300"></asp:Label></td><td>
                                <asp:TextBox ID="TextBox1" runat="server" Width="314px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="Required!" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                            </td>
			            </tr>
			            <tr>
			                <td>
                                <asp:Label ID="Label4" runat="server" Text="Firstname:" Font-Bold="True" 
                                    ForeColor="#003300"></asp:Label></td><td>
                                <asp:TextBox ID="TextBox2" runat="server" Width="311px"></asp:TextBox>
                            </td>
                            <td><a href="#">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ErrorMessage="Required!" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
				</a>
			                </td>
			            </tr>
			            <tr>
			                <td>
                                <asp:Label ID="Label5" runat="server" Text="Middlename:" Font-Bold="True" 
                                    ForeColor="#003300"></asp:Label></td><td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="311px"></asp:TextBox>
                            </td>
                            <td><a href="#">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ErrorMessage="Required!" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
				</a>
			                </td>
			            </tr>
			            <tr>
			                <td>
                                <asp:Label ID="Label6" runat="server" Text="age:" Font-Bold="True" 
                                    ForeColor="#003300"></asp:Label></td><td>
                                <asp:TextBox ID="TextBox4" runat="server" Width="91px"></asp:TextBox>
                            </td>
                            <td><a href="#">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                    ErrorMessage="Required!" ControlToValidate="TextBox4"></asp:RequiredFieldValidator>
				</a>
			                </td>
			            </tr>
			            <tr>
			                <td>
                                <asp:Label ID="Label7" runat="server" Text="Address:" Font-Bold="True" 
                                    ForeColor="#003300"></asp:Label></td><td>
                                <asp:TextBox ID="TextBox5" runat="server" Width="311px" Height="53px" 
                                    TextMode="MultiLine"></asp:TextBox>
                            </td>
                            <td><a href="#">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                    ErrorMessage="Required!" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
				</a>
			                </td>
			            </tr>
			            <tr>
			                <td>
                                <asp:Label ID="Label8" runat="server" Text="Contact number:" Font-Bold="True" 
                                    ForeColor="#003300"></asp:Label></td><td>
                                <asp:TextBox ID="TextBox6" runat="server" Width="311px"></asp:TextBox>
                            </td>
                            <td><a href="#">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                    ErrorMessage="Required!" ControlToValidate="TextBox6"></asp:RequiredFieldValidator>
				</a>
			                </td>
			            </tr>
			            <tr>
			                <td>
                                <asp:Label ID="Label9" runat="server" Text="email address(Optional):" Font-Bold="True" 
                                    ForeColor="#003300"></asp:Label></td><td>
                                <asp:TextBox ID="TextBox7" runat="server" Width="311px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
			            </tr>
			            <tr>
			                <td>
                                <asp:Label ID="Label10" runat="server" Text="Username:" Font-Bold="True" 
                                    ForeColor="#003300"></asp:Label></td><td>
                                <asp:TextBox ID="TextBox8" runat="server" Width="311px"></asp:TextBox>
                            </td>
                            <td><a href="#">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                    ErrorMessage="Required!" ControlToValidate="TextBox8"></asp:RequiredFieldValidator>
				</a>
			                </td>
			            </tr>
			            <tr>
			                <td>
                                <asp:Label ID="Label11" runat="server" Text="Password:" Font-Bold="True" 
                                    ForeColor="#003300"></asp:Label></td><td>
                                <asp:TextBox ID="TextBox9" runat="server" Width="311px" TextMode="Password"></asp:TextBox>
                            </td>
                            <td><a href="#">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                    ErrorMessage="Required!" ControlToValidate="TextBox9"></asp:RequiredFieldValidator>
				</a>
			                </td>
			            </tr>
			            <tr>
			                <td></td>
			                <td>
			                   
			                    <asp:Button ID="Button2" runat="server" Text="[Sign up]" Width="164px" 
                                    onclick="Button2_Click" />
			                   
			                </td>
			            </tr>
			            <tr>
			                <td>
			                </td>
			                 <td>
			                     <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                                     onclick="LinkButton2_Click" Visible="False">[Successfully save: Proceed to login(Click here)]</asp:LinkButton>
                            </td>
			            </tr>
			            <tr>
			                <td></td><td>&nbsp;</td>
			            </tr>
			        </table>
			    </fieldset>
			</div>
			
			<div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			<div class="post">
				</a>
			</div>
			<div>
			    
			</div>
		</div>
		
		
		
		
		
			<div style="clear: both;">&nbsp;</div>
		</div>
		</div>
		
		
		
		
	</div>
	
	<div id="footer">
        <div id="footer-bg">
	            <p class="copyright">&copy;&nbsp;&nbsp;Reprint authorized by Lippincott Williams & Wilkins &nbsp;&bull;&nbsp; Copyright &copy; <a href="#">Lipincott Williams & Wilkins</a>.</p>
	    
	            <p class="link">&nbsp;</p>
        </div>
    </div>
    <div style="text-align: center; font-size: 0.75em;"></div>
    </form>
</body>
</html>
