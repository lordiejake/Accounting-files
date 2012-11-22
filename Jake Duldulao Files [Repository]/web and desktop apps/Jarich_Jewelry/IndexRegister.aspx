<%@ Page Title="" Language="C#" MasterPageFile="~/design/MasterPage.master" AutoEventWireup="true" CodeFile="IndexRegister.aspx.cs" Inherits="IndexRegister" %>

<%@ Import Namespace="Artisteer" %>
<%@ Register TagPrefix="artisteer" Namespace="Artisteer" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenuRegister.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Register..
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

<artisteer:Article ID="Article1" Caption="Welcome" runat="server"><ContentTemplate>
    <p>Jewelry for men has largely consisted of expensive watches or rings. rarely has a guy considered wearing a pendant. If the guy wears a pendant that is manly enough, it actually can make him look really good. 
    Jarich has designed some really amazing and manly jewelry which come with stainless steel or titanium.
    </p>

    <asp:Panel ID="PanelDirectToLogin" runat="server">  
    <p>
    	<span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="IndexLogin.aspx">[Click here if you are already a member(Login)]</a>
    	</span>
    </p>
    </asp:Panel>

    <asp:Panel ID="PanelLogout" runat="server">  
    <p>
    	<span class="art-button-wrapper">
    		<span class="art-button-l"> </span>
    		<span class="art-button-r"> </span>
    		<a class="art-button" href="Logout.aspx">[Logout]</a>
    	</span>
    </p>
    </asp:Panel>
   
    <asp:Panel ID="PanelWelcomemessage" runat="server">
      <blockquote>
            <p>
                &#8220;You should Register to make Orders.. then enjoy.!.&#8221;
                <br />
                - Jarich's Jewelry Shop
            </p>
        </blockquote>
    </asp:Panel>
    <asp:Panel ID="PanelErrormessage" runat="server" Visible="False">
      <blockquote>
            <p>
                &#8220;Please complete the details&#8221;
            </p>
        </blockquote>
    </asp:Panel>
    <asp:Panel ID="PanelProceedmessage" runat="server" Visible="False">
      <blockquote>
            <p>
                &#8220;Thank you for Registering..&#8221; 
            </p>
            <p>
                click <a class="hover" href="IndexLogin.aspx" title="hovered link">HERE</a> to Login.
            </p>
        </blockquote>
    </asp:Panel>
    <asp:Panel ID="PanelCountryValidation" runat="server" Visible="False">
      <blockquote>
            <p>
                &#8220;Select a Country!..&#8221;
            </p>
        </blockquote>
    </asp:Panel>
    <asp:Panel ID="PanelAgeValidation" runat="server" Visible="False">
      <blockquote>
            <p>
                &#8220;Incorrect Age Format! please check the age...&#8221;
            </p>
        </blockquote>
    </asp:Panel>
    <asp:Panel ID="PanelUsernameDuplicateValidation" runat="server" Visible="False">
      <blockquote>
            <p>
                &#8220;The username you entered alredy exist...&#8221;
            </p>
        </blockquote>
    </asp:Panel>

    <asp:Panel ID="PanelRegistrationForm" runat="server">
    <blockquote>
            <table>
                <tr>
                    <td>Last Name:</td>
                    <td><asp:TextBox ID="txtlastname" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator  ID="RequiredFieldValidator1" ControlToValidate="txtlastname" ForeColor="Gold" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>First Name:</td>
                    <td><asp:TextBox ID="txtfirstname" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtfirstname" ForeColor="Gold" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Middle Name:</td>
                    <td><asp:TextBox ID="txtmiddlename" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtmiddlename" ForeColor="Gold" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Country:</td>
                    <td>
                        <asp:DropDownList ID="drpDropDownCountry" runat="server" Height="16px" 
                            Width="137px">
                        <asp:ListItem>--SelectCountry--</asp:ListItem>
                           <asp:ListItem Value="AF">Afghanistan</asp:ListItem>
    <asp:ListItem Value="AL">Albania</asp:ListItem>
    <asp:ListItem Value="DZ">Algeria</asp:ListItem>
    <asp:ListItem Value="AS">American Samoa</asp:ListItem>
    <asp:ListItem Value="AD">Andorra</asp:ListItem>
    <asp:ListItem Value="AO">Angola</asp:ListItem>
    <asp:ListItem Value="AI">Anguilla</asp:ListItem>
    <asp:ListItem Value="AQ">Antarctica</asp:ListItem>
    <asp:ListItem Value="AG">Antigua And Barbuda</asp:ListItem>
    <asp:ListItem Value="AR">Argentina</asp:ListItem>
    <asp:ListItem Value="AM">Armenia</asp:ListItem>
    <asp:ListItem Value="AW">Aruba</asp:ListItem>
    <asp:ListItem Value="AU">Australia</asp:ListItem>
    <asp:ListItem Value="AT">Austria</asp:ListItem>
    <asp:ListItem Value="AZ">Azerbaijan</asp:ListItem>
    <asp:ListItem Value="BS">Bahamas</asp:ListItem>
    <asp:ListItem Value="BH">Bahrain</asp:ListItem>
    <asp:ListItem Value="BD">Bangladesh</asp:ListItem>
    <asp:ListItem Value="BB">Barbados</asp:ListItem>
    <asp:ListItem Value="BY">Belarus</asp:ListItem>
    <asp:ListItem Value="BE">Belgium</asp:ListItem>
    <asp:ListItem Value="BZ">Belize</asp:ListItem>
    <asp:ListItem Value="BJ">Benin</asp:ListItem>
    <asp:ListItem Value="BM">Bermuda</asp:ListItem>
    <asp:ListItem Value="BT">Bhutan</asp:ListItem>
    <asp:ListItem Value="BO">Bolivia</asp:ListItem>
    <asp:ListItem Value="BA">Bosnia And Herzegowina</asp:ListItem>
    <asp:ListItem Value="BW">Botswana</asp:ListItem>
    <asp:ListItem Value="BV">Bouvet Island</asp:ListItem>
    <asp:ListItem Value="BR">Brazil</asp:ListItem>
    <asp:ListItem Value="IO">British Indian Ocean Territory</asp:ListItem>
    <asp:ListItem Value="BN">Brunei Darussalam</asp:ListItem>
    <asp:ListItem Value="BG">Bulgaria</asp:ListItem>
    <asp:ListItem Value="BF">Burkina Faso</asp:ListItem>
    <asp:ListItem Value="BI">Burundi</asp:ListItem>
    <asp:ListItem Value="KH">Cambodia</asp:ListItem>
    <asp:ListItem Value="CM">Cameroon</asp:ListItem>
    <asp:ListItem Value="CA">Canada</asp:ListItem>
    <asp:ListItem Value="CV">Cape Verde</asp:ListItem>
    <asp:ListItem Value="KY">Cayman Islands</asp:ListItem>
    <asp:ListItem Value="CF">Central African Republic</asp:ListItem>
    <asp:ListItem Value="TD">Chad</asp:ListItem>
    <asp:ListItem Value="CL">Chile</asp:ListItem>
    <asp:ListItem Value="CN">China</asp:ListItem>
    <asp:ListItem Value="CX">Christmas Island</asp:ListItem>
    <asp:ListItem Value="CC">Cocos (Keeling) Islands</asp:ListItem>
    <asp:ListItem Value="CO">Colombia</asp:ListItem>
    <asp:ListItem Value="KM">Comoros</asp:ListItem>
    <asp:ListItem Value="CG">Congo</asp:ListItem>
    <asp:ListItem Value="CK">Cook Islands</asp:ListItem>
    <asp:ListItem Value="CR">Costa Rica</asp:ListItem>
    <asp:ListItem Value="CI">Cote D'Ivoire</asp:ListItem>
    <asp:ListItem Value="HR">Croatia (Local Name: Hrvatska)</asp:ListItem>
    <asp:ListItem Value="CU">Cuba</asp:ListItem>
    <asp:ListItem Value="CY">Cyprus</asp:ListItem>
    <asp:ListItem Value="CZ">Czech Republic</asp:ListItem>
    <asp:ListItem Value="DK">Denmark</asp:ListItem>
    <asp:ListItem Value="DJ">Djibouti</asp:ListItem>
    <asp:ListItem Value="DM">Dominica</asp:ListItem>
    <asp:ListItem Value="DO">Dominican Republic</asp:ListItem>
    <asp:ListItem Value="TP">East Timor</asp:ListItem>
    <asp:ListItem Value="EC">Ecuador</asp:ListItem>
    <asp:ListItem Value="EG">Egypt</asp:ListItem>
    <asp:ListItem Value="SV">El Salvador</asp:ListItem>
    <asp:ListItem Value="GQ">Equatorial Guinea</asp:ListItem>
    <asp:ListItem Value="ER">Eritrea</asp:ListItem>
    <asp:ListItem Value="EE">Estonia</asp:ListItem>
    <asp:ListItem Value="ET">Ethiopia</asp:ListItem>
    <asp:ListItem Value="FK">Falkland Islands (Malvinas)</asp:ListItem>
    <asp:ListItem Value="FO">Faroe Islands</asp:ListItem>
    <asp:ListItem Value="FJ">Fiji</asp:ListItem>
    <asp:ListItem Value="FI">Finland</asp:ListItem>
    <asp:ListItem Value="FR">France</asp:ListItem>
    <asp:ListItem Value="GF">French Guiana</asp:ListItem>
    <asp:ListItem Value="PF">French Polynesia</asp:ListItem>
    <asp:ListItem Value="TF">French Southern Territories</asp:ListItem>
    <asp:ListItem Value="GA">Gabon</asp:ListItem>
    <asp:ListItem Value="GM">Gambia</asp:ListItem>
    <asp:ListItem Value="GE">Georgia</asp:ListItem>
    <asp:ListItem Value="DE">Germany</asp:ListItem>
    <asp:ListItem Value="GH">Ghana</asp:ListItem>
    <asp:ListItem Value="GI">Gibraltar</asp:ListItem>
    <asp:ListItem Value="GR">Greece</asp:ListItem>
    <asp:ListItem Value="GL">Greenland</asp:ListItem>
    <asp:ListItem Value="GD">Grenada</asp:ListItem>
    <asp:ListItem Value="GP">Guadeloupe</asp:ListItem>
    <asp:ListItem Value="GU">Guam</asp:ListItem>
    <asp:ListItem Value="GT">Guatemala</asp:ListItem>
    <asp:ListItem Value="GN">Guinea</asp:ListItem>
    <asp:ListItem Value="GW">Guinea-Bissau</asp:ListItem>
    <asp:ListItem Value="GY">Guyana</asp:ListItem>
    <asp:ListItem Value="HT">Haiti</asp:ListItem>
    <asp:ListItem Value="HM">Heard And Mc Donald Islands</asp:ListItem>
    <asp:ListItem Value="VA">Holy See (Vatican City State)</asp:ListItem>
    <asp:ListItem Value="HN">Honduras</asp:ListItem>
    <asp:ListItem Value="HK">Hong Kong</asp:ListItem>
    <asp:ListItem Value="HU">Hungary</asp:ListItem>
    <asp:ListItem Value="IS">Icel And</asp:ListItem>
    <asp:ListItem Value="IN">India</asp:ListItem>
    <asp:ListItem Value="ID">Indonesia</asp:ListItem>
    <asp:ListItem Value="IR">Iran (Islamic Republic Of)</asp:ListItem>
    <asp:ListItem Value="IQ">Iraq</asp:ListItem>
    <asp:ListItem Value="IE">Ireland</asp:ListItem>
    <asp:ListItem Value="IL">Israel</asp:ListItem>
    <asp:ListItem Value="IT">Italy</asp:ListItem>
    <asp:ListItem Value="JM">Jamaica</asp:ListItem>
    <asp:ListItem Value="JP">Japan</asp:ListItem>
    <asp:ListItem Value="JO">Jordan</asp:ListItem>
    <asp:ListItem Value="KZ">Kazakhstan</asp:ListItem>
    <asp:ListItem Value="KE">Kenya</asp:ListItem>
    <asp:ListItem Value="KI">Kiribati</asp:ListItem>
    <asp:ListItem Value="KP">Korea, Dem People'S Republic</asp:ListItem>
    <asp:ListItem Value="KR">Korea, Republic Of</asp:ListItem>
    <asp:ListItem Value="KW">Kuwait</asp:ListItem>
    <asp:ListItem Value="KG">Kyrgyzstan</asp:ListItem>
    <asp:ListItem Value="LA">Lao People'S Dem Republic</asp:ListItem>
    <asp:ListItem Value="LV">Latvia</asp:ListItem>
    <asp:ListItem Value="LB">Lebanon</asp:ListItem>
    <asp:ListItem Value="LS">Lesotho</asp:ListItem>
    <asp:ListItem Value="LR">Liberia</asp:ListItem>
    <asp:ListItem Value="LY">Libyan Arab Jamahiriya</asp:ListItem>
    <asp:ListItem Value="LI">Liechtenstein</asp:ListItem>
    <asp:ListItem Value="LT">Lithuania</asp:ListItem>
    <asp:ListItem Value="LU">Luxembourg</asp:ListItem>
    <asp:ListItem Value="MO">Macau</asp:ListItem>
    <asp:ListItem Value="MK">Macedonia</asp:ListItem>
    <asp:ListItem Value="MG">Madagascar</asp:ListItem>
    <asp:ListItem Value="MW">Malawi</asp:ListItem>
    <asp:ListItem Value="MY">Malaysia</asp:ListItem>
    <asp:ListItem Value="MV">Maldives</asp:ListItem>
    <asp:ListItem Value="ML">Mali</asp:ListItem>
    <asp:ListItem Value="MT">Malta</asp:ListItem>
    <asp:ListItem Value="MH">Marshall Islands</asp:ListItem>
    <asp:ListItem Value="MQ">Martinique</asp:ListItem>
    <asp:ListItem Value="MR">Mauritania</asp:ListItem>
    <asp:ListItem Value="MU">Mauritius</asp:ListItem>
    <asp:ListItem Value="YT">Mayotte</asp:ListItem>
    <asp:ListItem Value="MX">Mexico</asp:ListItem>
    <asp:ListItem Value="FM">Micronesia, Federated States</asp:ListItem>
    <asp:ListItem Value="MD">Moldova, Republic Of</asp:ListItem>
    <asp:ListItem Value="MC">Monaco</asp:ListItem>
    <asp:ListItem Value="MN">Mongolia</asp:ListItem>
    <asp:ListItem Value="MS">Montserrat</asp:ListItem>
    <asp:ListItem Value="MA">Morocco</asp:ListItem>
    <asp:ListItem Value="MZ">Mozambique</asp:ListItem>
    <asp:ListItem Value="MM">Myanmar</asp:ListItem>
    <asp:ListItem Value="NA">Namibia</asp:ListItem>
    <asp:ListItem Value="NR">Nauru</asp:ListItem>
    <asp:ListItem Value="NP">Nepal</asp:ListItem>
    <asp:ListItem Value="NL">Netherlands</asp:ListItem>
    <asp:ListItem Value="AN">Netherlands Ant Illes</asp:ListItem>
    <asp:ListItem Value="NC">New Caledonia</asp:ListItem>
    <asp:ListItem Value="NZ" Selected="True">New Zealand</asp:ListItem>
    <asp:ListItem Value="NI">Nicaragua</asp:ListItem>
    <asp:ListItem Value="NE">Niger</asp:ListItem>
    <asp:ListItem Value="NG">Nigeria</asp:ListItem>
    <asp:ListItem Value="NU">Niue</asp:ListItem>
    <asp:ListItem Value="NF">Norfolk Island</asp:ListItem>
    <asp:ListItem Value="MP">Northern Mariana Islands</asp:ListItem>
    <asp:ListItem Value="NO">Norway</asp:ListItem>
    <asp:ListItem Value="OM">Oman</asp:ListItem>
    <asp:ListItem Value="PK">Pakistan</asp:ListItem>
    <asp:ListItem Value="PW">Palau</asp:ListItem>
    <asp:ListItem Value="PA">Panama</asp:ListItem>
    <asp:ListItem Value="PG">Papua New Guinea</asp:ListItem>
    <asp:ListItem Value="PY">Paraguay</asp:ListItem>
    <asp:ListItem Value="PE">Peru</asp:ListItem>
    <asp:ListItem Value="PH">Philippines</asp:ListItem>
    <asp:ListItem Value="PN">Pitcairn</asp:ListItem>
    <asp:ListItem Value="PL">Poland</asp:ListItem>
    <asp:ListItem Value="PT">Portugal</asp:ListItem>
    <asp:ListItem Value="PR">Puerto Rico</asp:ListItem>
    <asp:ListItem Value="QA">Qatar</asp:ListItem>
    <asp:ListItem Value="RE">Reunion</asp:ListItem>
    <asp:ListItem Value="RO">Romania</asp:ListItem>
    <asp:ListItem Value="RU">Russian Federation</asp:ListItem>
    <asp:ListItem Value="RW">Rwanda</asp:ListItem>
    <asp:ListItem Value="KN">Saint K Itts And Nevis</asp:ListItem>
    <asp:ListItem Value="LC">Saint Lucia</asp:ListItem>
    <asp:ListItem Value="VC">Saint Vincent, The Grenadines</asp:ListItem>
    <asp:ListItem Value="WS">Samoa</asp:ListItem>
    <asp:ListItem Value="SM">San Marino</asp:ListItem>
    <asp:ListItem Value="ST">Sao Tome And Principe</asp:ListItem>
    <asp:ListItem Value="SA">Saudi Arabia</asp:ListItem>
    <asp:ListItem Value="SN">Senegal</asp:ListItem>
    <asp:ListItem Value="SC">Seychelles</asp:ListItem>
    <asp:ListItem Value="SL">Sierra Leone</asp:ListItem>
    <asp:ListItem Value="SG">Singapore</asp:ListItem>
    <asp:ListItem Value="SK">Slovakia (Slovak Republic)</asp:ListItem>
    <asp:ListItem Value="SI">Slovenia</asp:ListItem>
    <asp:ListItem Value="SB">Solomon Islands</asp:ListItem>
    <asp:ListItem Value="SO">Somalia</asp:ListItem>
    <asp:ListItem Value="ZA">South Africa</asp:ListItem>
    <asp:ListItem Value="GS">South Georgia , S Sandwich Is.</asp:ListItem>
    <asp:ListItem Value="ES">Spain</asp:ListItem>
    <asp:ListItem Value="LK">Sri Lanka</asp:ListItem>
    <asp:ListItem Value="SH">St. Helena</asp:ListItem>
    <asp:ListItem Value="PM">St. Pierre And Miquelon</asp:ListItem>
    <asp:ListItem Value="SD">Sudan</asp:ListItem>
    <asp:ListItem Value="SR">Suriname</asp:ListItem>
    <asp:ListItem Value="SJ">Svalbard, Jan Mayen Islands</asp:ListItem>
    <asp:ListItem Value="SZ">Sw Aziland</asp:ListItem>
    <asp:ListItem Value="SE">Sweden</asp:ListItem>
    <asp:ListItem Value="CH">Switzerland</asp:ListItem>
    <asp:ListItem Value="SY">Syrian Arab Republic</asp:ListItem>
    <asp:ListItem Value="TW">Taiwan</asp:ListItem>
    <asp:ListItem Value="TJ">Tajikistan</asp:ListItem>
    <asp:ListItem Value="TZ">Tanzania, United Republic Of</asp:ListItem>
    <asp:ListItem Value="TH">Thailand</asp:ListItem>
    <asp:ListItem Value="TG">Togo</asp:ListItem>
    <asp:ListItem Value="TK">Tokelau</asp:ListItem>
    <asp:ListItem Value="TO">Tonga</asp:ListItem>
    <asp:ListItem Value="TT">Trinidad And Tobago</asp:ListItem>
    <asp:ListItem Value="TN">Tunisia</asp:ListItem>
    <asp:ListItem Value="TR">Turkey</asp:ListItem>
    <asp:ListItem Value="TM">Turkmenistan</asp:ListItem>
    <asp:ListItem Value="TC">Turks And Caicos Islands</asp:ListItem>
    <asp:ListItem Value="TV">Tuvalu</asp:ListItem>
    <asp:ListItem Value="UG">Uganda</asp:ListItem>
    <asp:ListItem Value="UA">Ukraine</asp:ListItem>
    <asp:ListItem Value="AE">United Arab Emirates</asp:ListItem>
    <asp:ListItem Value="GB">United Kingdom</asp:ListItem>
    <asp:ListItem Value="US">United States</asp:ListItem>
    <asp:ListItem Value="UM">United States Minor Is.</asp:ListItem>
    <asp:ListItem Value="UY">Uruguay</asp:ListItem>
    <asp:ListItem Value="UZ">Uzbekistan</asp:ListItem>
    <asp:ListItem Value="VU">Vanuatu</asp:ListItem>
    <asp:ListItem Value="VE">Venezuela</asp:ListItem>
    <asp:ListItem Value="VN">Viet Nam</asp:ListItem>
    <asp:ListItem Value="VG">Virgin Islands (British)</asp:ListItem>
    <asp:ListItem Value="VI">Virgin Islands (U.S.)</asp:ListItem>
    <asp:ListItem Value="WF">Wallis And Futuna Islands</asp:ListItem>
    <asp:ListItem Value="EH">Western Sahara</asp:ListItem>
    <asp:ListItem Value="YE">Yemen</asp:ListItem>
    <asp:ListItem Value="YU">Yugoslavia</asp:ListItem>
    <asp:ListItem Value="ZR">Zaire</asp:ListItem>
    <asp:ListItem Value="ZM">Zambia</asp:ListItem>
    <asp:ListItem Value="ZW">Zimbabwe</asp:ListItem>
                    
                        </asp:DropDownList>
                    </td>
                    <td><asp:RequiredFieldValidator  ID="RequiredFieldValidator4" ControlToValidate="drpDropDownCountry" ForeColor="Gold" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td><asp:TextBox ID="txtcity" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtcity" ForeColor="Gold" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Postal Code:</td>
                    <td><asp:TextBox ID="txtpostalcode" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtpostalcode" ForeColor="Gold" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Street:</td>
                    <td><asp:TextBox ID="txtstreet" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator  ID="RequiredFieldValidator7" ControlToValidate="txtstreet" ForeColor="Gold" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Age:</td>
                    <td><asp:TextBox ID="txtage" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator8" ControlToValidate="txtage" ForeColor="Gold" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>EmailAddress(Optional):</td>
                    <td><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ForeColor="Gold" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"   ControlToValidate="txtemail"  ErrorMessage="Input valid email address!"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>User Name:</td>
                    <td><asp:TextBox ID="txtusername" runat="server"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator  ID="RequiredFieldValidator9" ControlToValidate="txtusername" ForeColor="Gold" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="RequiredFieldValidator10" ControlToValidate="txtpassword" ForeColor="Gold" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="BtnRegister" runat="server" CssClass="art-button" 
                            Text="Register" onclick="BtnRegister_Click"  /></td>
                </tr>
            </table>
    <blockquote>
  </asp:Panel>

    <asp:Panel ID="PanelWarningForm" runat="server">
        <blockquote>
            <p>
                &#8220;You are Currently logged in.  Please logout first if you want to make another Account. Thank you.&#8221;
                <br />
                - Jarich's Jewelry Shop
            </p>
        </blockquote>
    </asp:Panel>

 </ContentTemplate></artisteer:Article>
    

</asp:Content>

