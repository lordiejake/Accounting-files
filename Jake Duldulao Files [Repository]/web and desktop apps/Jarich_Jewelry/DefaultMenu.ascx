<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DefaultMenu.ascx.cs" Inherits="Menu" %>

<asp:Panel ID="PanelLogin" runat="server">
<ul class="art-hmenu">
    <li><a href="Default.aspx" class=" active"><span class="l"></span><span class="r"></span><span class="t">Home</span></a></li>
    <li><a href="IndexContacts.aspx"><span class="l"></span><span class="r"></span><span class="t">Contacts</span></a>
        <!--ul>
		    <li><a href="#">Menu Subitem 1</a></li>
		    <li><a href="#">Menu Subitem 2</a></li>
		    <li><a href="#">Menu Subitem 3</a></li>
	    </ul-->
    </li>
    <li><a href="IndexAbout.aspx"><span class="l"></span><span class="r"></span><span class="t">About</span></a></li>
    <li><a href="IndexServices.aspx"><span class="l"></span><span class="r"></span><span class="t">Services</span></a></li>
    <li><a href="IndexProducts.aspx"><span class="l"></span><span class="r"></span><span class="t">Products</span></a></li>
    <li><a href="IndexRegister.aspx"><span class="l"></span><span class="r"></span><span class="t">Register</span></a></li>

    <li><a href="IndexLogin.aspx"><span class="l"></span><span class="r"></span><span class="t">Login
    </span></a></li>

    <li><a href="IndexAdmin.aspx"><span class="l"></span><span class="r"></span><span class="t">Admin</span></a></li>
</ul>
</asp:Panel>

<asp:Panel ID="PanelLogout" runat="server">
<ul class="art-hmenu">
    <li><a href="Default.aspx" class=" active"><span class="l"></span><span class="r"></span><span class="t">Home</span></a></li>
    <li><a href="IndexContacts.aspx"><span class="l"></span><span class="r"></span><span class="t">Contacts</span></a>
        <!--ul>
		    <li><a href="#">Menu Subitem 1</a></li>
		    <li><a href="#">Menu Subitem 2</a></li>
		    <li><a href="#">Menu Subitem 3</a></li>
	    </ul-->
    </li>
    <li><a href="IndexAbout.aspx"><span class="l"></span><span class="r"></span><span class="t">About</span></a></li>
    <li><a href="IndexServices.aspx"><span class="l"></span><span class="r"></span><span class="t">Services</span></a></li>
    <li><a href="IndexProducts.aspx"><span class="l"></span><span class="r"></span><span class="t">Products</span></a></li>
    <li><a href="IndexRegister.aspx"><span class="l"></span><span class="r"></span><span class="t">Register</span></a></li>

    <li><a href="Logout.aspx"><span class="l"></span><span class="r"></span><span class="t">Logout
    </span></a></li>

    <li><a href="IndexAdmin.aspx"><span class="l"></span><span class="r"></span><span class="t">Admin</span></a></li>
   <%-- <li><a href="Select-Products-Transactions-CkecksOut-Shopping-Cart-Orders.aspx"><span class="l"><"images/view-cart.gif" /></span><span class="r"></span><span class="t"></span></a></li>--%>
</ul>
</asp:Panel>
