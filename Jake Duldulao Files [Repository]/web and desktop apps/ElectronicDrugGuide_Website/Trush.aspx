<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Trush.aspx.cs" Inherits="Trush" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Illness: Trush</title>
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
         <li class="last"><span><asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click1">LinkButton</asp:LinkButton></span></li>
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
					<p>•	Determine the effectiveness of Electronic Drug Guide Book for common illnesses among children.</p>
					<p>•	Develop an Electronic Drug Guide Book Web Application.</p>
				</div>
			</div>
			<hr />
		    <div class="post">
				<h1 class="title">Definition:<a href="#"></h1>
			</div>
			<hr />
			<div>
                        <asp:Label ID="lblViewMembers" runat="server" Font-Bold="True" 
                            Font-Size="Large" Font-Underline="True" ForeColor="#006600">Thrush:</asp:Label></div>
                            
			<div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			
			    <div>
			    <div class="entry">
					<p id = "bl">•	It is a fungoid infection of the throat especially in children or of the Vigina</p>
					
				</div>
			</div>
			
			<div>
			    <fieldset id = "threadconfig"></fieldset>
			</div>
			<div class="post">
				</a>
			</div>
			<div>
			    <hr />
			    <br />
			        
			    <br />
			    <hr />
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
