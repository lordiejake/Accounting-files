<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DefaultSidebarWhatsnew.ascx.cs" Inherits="DefaultSidebarWhatsnew" %>
<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultVerticalMenu" Src="DefaultVerticalMenuWhatsnew.ascx" %>

<art:DefaultVerticalMenu ID="DefaultVMenuContent" runat="server" />
                  <artisteer:Block ID="NewsletterBlock" Caption="Newsletter" runat="server"><ContentTemplate><div>
          <input type="text" value="" name="email" id="s" style="width: 95%;" />
          <span class="art-button-wrapper">
          	<span class="art-button-l"> </span>
          	<span class="art-button-r"> </span>
          	<input class="art-button" type="submit" name="search" value="Subscribe" />
          </span>
          
          </div>
             </ContentTemplate></artisteer:Block>