<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DefaultHeader.ascx.cs" Inherits="DefaultHeader" %>
<div class="art-headerobject"></div>
<script type="text/javascript" src="swfobject.js"></script>
<script type="text/javascript">
jQuery((function (swf) {
    return function () {
        swf.switchOffAutoHideShow();
        swf.registerObject("art-flash-object", "9.0.0", "expressInstall.swf");
    }
})(swfobject));
</script>
<div id="art-flash-area">
<div id="art-flash-container">
<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="1165" height="330" id="art-flash-object">
    <param name="movie" value="images/flash.swf" />
    <param name="quality" value="high" />
	<param name="scale" value="exactfit" />
	<param name="wmode" value="transparent" />
	<param name="flashvars" value="color1=0xFFFFFF&amp;alpha1=.50&amp;framerate1=24&amp;loop=true&amp;wmode=transparent" />
    <param name="swfliveconnect" value="true" />
    <!--[if !IE]>-->
    <object type="application/x-shockwave-flash" data="images/flash.swf" width="1165" height="330">
        <param name="quality" value="high" />
	    <param name="scale" value="exactfit" />
	    <param name="wmode" value="transparent" />
	    <param name="flashvars" value="color1=0xFFFFFF&amp;alpha1=.50&amp;framerate1=24&amp;loop=true&amp;wmode=transparent" />
        <param name="swfliveconnect" value="true" />
    <!--<![endif]-->
      	<div class="art-flash-alt"><a href="http://www.adobe.com/go/getflashplayer"><img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash player" /></a></div>
    <!--[if !IE]>-->
    </object>
    <!--<![endif]-->
</object>
</div>
</div>
<div class="art-logo">
        <h1 class="art-logo-name"><a href="#">Jarich&#39;s Jewelry</a></h1>
            <h2 class="art-logo-text">Feel the Royal soundness of</h2>
            <h2 class="art-logo-text">the sourroundings..</h2>
            <h2 class="art-logo-text">the best value for you.</h2>
            <h2 class="art-logo-text">Start shopping with us now!</h2>
    </div>
