<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="UserWebApp.StudentForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Stay Family Application</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->

    <link rel="stylesheet" type="text/css" href="nice-assets\assets\jquery-ui\jquery-ui-1.10.1.custom.css" />
    <link rel="stylesheet" type="text/css" href="assets/linkeffects/css/normalize.css" />
	<link rel="stylesheet" type="text/css" href="assets/linkeffects/css/demo.css" />
	<link rel="stylesheet" type="text/css" href="assets/linkeffects/css/component.css" />
    <link rel="stylesheet" href="assets/css/style.css" />
    <link rel="stylesheet" href="assets/css/main.css" />

    <!-- temp assets -->
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
    $( function() {
    $( "#accordion" ).accordion();
    } );
  </script>
</head>
<body class="homepage">

    <div id="page-wrapper">
        <!-- Header -->
        <div id="header">
                <div class="container">

                    <!-- Logo -->
                    <div id="logo">
                        <span class="pennant"><span class="icon fa-home"></span></span>
                        <h1><a href="StudentForm.aspx">Home Stay</a></h1>
                    </div>

                    <!-- Nav -->
                    <nav id="nav" class="cl-effect-17">
                        <ul>
                            <li><a href="Home.aspx">Home</a></li>
                            <li><a href="FamilyForm.aspx">Host a Student</a></li>
                            <li class="active"><a href="index.html">Student Application</a></li>
                            <li><a href="contact.php">Contact</a></li>
                        </ul>
                    </nav>

                </div>
            </div>

        <form id="form1" runat="server">
        
            <!-- Main -->
            <div id="main">
                <section class="container">
                    <asp:ValidationSummary runat="server" headertext="Please correct the following errors before continuing:" ForeColor="#ff3300" DisplayMode="List"/>
                    <div id="formDiv" style="text-align:center">




                            <%-- Terms of Service Panel --%>
                            <asp:Panel runat="server" id="termsOfServicePanel">
                                <div>
                                   <section class="container">
						                <h2>Fees</h2>
						                <p>The current per session homestay fee is $650. Each session is four weeks. All fees are paid directly to International Homestay Consultants. The homestay fees may be paid by check, cash electronic-pay (ex: Chase Quick-pay) or bank transfer*. We do not accept credit cards. If paying by check, please send directly to International Homestay Consultants (7326 Hoover Road, Indianapolis IN 46260). If paying by cash, it is the student's responsibility to schedule an appointment with us, and make the payment in person, by the beginning of each session. A late fee will be assessed any outstanding account that has not been paid by the beginning of each session. (*All wire transfer fees are the responsibility of the student.)</p>

                                        <h3>Vacation Rates</h3>
                                        <p>Students who plan to return to homestay after a vacation* will be charged the vacation rate of 50% of regular homestay fee, for time absent from homestay. If student remains in homestay during class break, the regular homestay fee will be charged. (*Vacation rate is calculated in whole weeks.)</p>

					               </section>
                                    <section>
                                        <h2>Policies</h2>
                                            <p class="terms-of-service-policies">Homestay accommodations can be pre-arranged for any length of time, with the option of extending the stay if desired. If your arrival date does not correspond with published session dates, the fee is pro-rated accordingly, to the student&#39;s advantage.</span></p>

                                            <ol class ="terms-of-service-policies">
	                                            <li>A non-refundable reservation fee ($200) and homestay application should be submitted at least four week&#39;s prior to requested move-in date.</li>
	                                            <li>The first four week&#39;s rent must be paid to International Homestay Consultants prior to move-in.</li>
	                                            <li>All homestays include a private furnished bedroom, use of public areas of house, laundry facilities, internet access, breakfast and dinner.</li>
	                                            <li>You should plan to arrive at your homestay no more than two days before IUPUI orientation commences.</li>
	                                            <li>You should plan to depart the homestay on Saturday before 1:00pm following the end of the semester unless other arrangements with our company have been made.</li>
	                                            <li>Smoking is not permitted inside homestay houses.</li>
	                                            <li>If you are not comfortable in a home with indoor pets, we will make every effort to accommodate you. However, because most Americans have indoor pets we cannot guarantee a homestay without indoor pets.</li>
	                                            <li>Travel time to and from the university will vary. International Homestay Consultants will place you in a home within walking distance of public transportation.</li>
	                                            <li>The homestay hosts may be families with mother, father, and children; they may be single people or couples without children.</li>
	                                            <li>International Homestay Consultants is available to discuss student concerns by phone or e-mail during regular business hours, or face to face on Wednesdays, during regular campus visits.</li>
	                                            <li>Students will not be allowed to stay at the homestay, past or prior to their pre-arranged times, without the agreement of International Homestay Consultants. Privately arranged homestays will make hosts ineligible for hosting for us in the future.</li>
	                                            <li>Homestay Students pay homestay fees each session (4 weeks) directly to International Homestay Consultants. Hosts will receive payment directly from International Homestay Consultants. Money should never exchange hands between hosts and students.</li>
	                                            <li>Students are encouraged to bring their own notebook computer if they want to use computers in their homestay.</li>
	                                            <li>Hosts are not expected to cook differently for students; if students want limited kitchen privileges, they must ask the host first, and must clean up after themselves.</li>
                                            </ol>

                                            <p><span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium;">To apply, complete the&nbsp;</span><a href="http://internationalhomestay.us/Homestay_Application.pdf" style="font-family: &quot;Times New Roman&quot;; font-size: medium;">Homestay Application</a><span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium;">&nbsp;and submit it with your reservation fee at least four weeks prior to your time of study.</span></p>

                                    </section>

                                    <asp:Label AssociatedControlID="termsOfServiceCheckbox" Text="I agree to the terms of service: " runat="server"></asp:Label>
                                    <asp:CheckBox id="termsOfServiceCheckbox" runat="server" Text="" TextAlign="Right" />
                                </div>
                            </asp:Panel>









                            <%-- personal information panel --%>
                            <asp:Panel runat="server" id="personalInfoPanel">
                
                                <%--name--%>
                                <asp:RequiredFieldValidator runat="server" controltovalidate="lastName" errormessage="You must provide your last name." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label AssociatedControlID="lastName" Text="Last Name: " runat="server"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="lastName"></asp:TextBox>

                                <br />
                                <br />

                                <asp:RequiredFieldValidator runat="server" controltovalidate="firstName" errormessage="You must provide your first name." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label AssociatedControlID="firstName" Text="First Name: " runat="server"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="firstName"></asp:TextBox>

                                <br />
                                <br />

                                <asp:Label Text="Date of Birth: " runat="server"></asp:Label>
                                <br />
                                <asp:DropDownList ID="ddlYear" runat="server" onchange ="PopulateDays()" />
                                <asp:DropDownList ID="ddlMonth" runat="server" onchange ="PopulateDays()" />
                                <asp:DropDownList ID="ddlDay" runat="server" />

                                <br />
                                <br />

                               
                                <%-- temporary way to populate countries --%>
                             <%--   <asp:CompareValidator ControlToValidate="Country" ID="CompareValidator"  ValidationGroup="g1" ErrorMessage="Please select a country."  runat="server" Display="Dynamic" Operator="NotEqual" ValueToCompare="0" Type="Integer" Text="*" ForeColor="#ff3300" />--%>
                                <asp:Label AssociatedControlID="Country" Text="Nationality: " runat="server"></asp:Label>
                                <br />
                                <asp:DropDownList id="Country" runat="server">
                                <asp:ListItem Value="0" Selected="True">Select</asp:ListItem>
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
                                <asp:ListItem Value="NZ">New Zealand</asp:ListItem>
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
                                <asp:ListItem Value="O">Other</asp:ListItem>
                            </asp:DropDownList>
                                <br />
                                <br />
                           
                                <asp:RequiredFieldValidator runat="server" controltovalidate="firstLanguage" errormessage="You must provide your first language." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label AssociatedControlID="firstLanguage" Text="First Language: " runat="server"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="firstLanguage"></asp:TextBox>

                                <br />
                                <br />

                               
                                <asp:Label AssociatedControlID="gender" Text="Gender: " runat="server"></asp:Label>
                                <asp:RadioButtonList id="gender"  RepeatDirection="Horizontal" RepeatLayout ="Flow" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="Male" Value="0" Selected="true"/>
                                <asp:ListItem Text="Female" Value="1" />
                                </asp:RadioButtonList>

                                <br />
                                <br />

                                <asp:Label AssociatedControlID="martialstatus" Text="Martial Status: " runat="server"></asp:Label>
                                <asp:RadioButtonList id="martialstatus"  RepeatDirection="Horizontal" RepeatLayout ="Flow" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="Married" Value="0" Selected="true"/>
                                <asp:ListItem Text="Unmarried" Value="1" />
                                </asp:RadioButtonList>
                              

             
                            </asp:Panel>
         

                            <%-- Contact info panel --%>
                              <asp:Panel runat="server" id="contactInfoPanel" Enabled="False">

                                <asp:RequiredFieldValidator runat="server" controltovalidate="address" errormessage="Please provide an address." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="Address: " AssociatedControlID="address"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="address" Enabled="True" Width="50%"></asp:TextBox>

                                <br />
                                <br />

                                <asp:RequiredFieldValidator runat="server" controltovalidate="phone1" errormessage="Please provide a primary phone number" ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="Primary Phone: " AssociatedControlID="phone1"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="phone1" Width="50%"></asp:TextBox>

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Secondary Phone: " AssociatedControlID="phone2"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="phone2" Width="50%"></asp:TextBox>

                                <br />
                                <br />


                                <asp:RequiredFieldValidator runat="server" controltovalidate="email" errormessage="Please enter an email address." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="Email: " AssociatedControlID="email"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="email" Width="50%"></asp:TextBox>
                    
                            </asp:Panel>
            
            
                            <%-- conditions and preferences panel --%>
                            <asp:Panel runat="server" id="conditionsPreferencesPanel" Enabled="False">

                                <asp:Label AssociatedControlID="transportation" Text="Do you have transportation?: " runat="server"></asp:Label>
                                <asp:RadioButtonList id="transportation" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="Yes" Value="0" Selected="true"/>
                                <asp:ListItem Text="No" Value="1" />
                                </asp:RadioButtonList>

                                <br />

                                <asp:Label runat="server" Text="Allergies, Health Problems or Dietary Restrictions:" AssociatedControlID="allergies"></asp:Label>
                                <br />
                                <asp:TextBox id="allergies" runat="server" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox> 

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Do you have any particular preferences?" AssociatedControlID="hobbies"></asp:Label>
                                <br />
                                <asp:TextBox id="hobbies" runat="server" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox> 

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Tell us about yourself: " AssociatedControlID="about"></asp:Label>
                                <br />
                                 <asp:TextBox id="about" runat="server" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox> 

                                <br />
                                <br />
                           
                                
                          
                            </asp:Panel>
            
            
                            <%-- university information panel --%>
                            <asp:Panel runat="server" ID="universityInfoPanel" Enabled="False">
                
                                <asp:RequiredFieldValidator runat="server" controltovalidate="university" errormessage="Please enter the name of the university you are attending." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="University Name: " AssociatedControlID="university"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="university"></asp:TextBox>
                                <br />
                                <br />
                                <asp:RequiredFieldValidator runat="server" controltovalidate="universityAddress" errormessage="Please enter the university address." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="University Address: " AssociatedControlID="universityAddress"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="universityAddress"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label runat="server" Text="Semester Start Date: "></asp:Label>
                                <br />
                                <asp:DropDownList ID="y" runat="server" onchange ="PopulateDays()" />
                                <asp:DropDownList ID="m" runat="server" onchange ="PopulateDays()" />
                                <asp:DropDownList ID="d" runat="server" />
                                <br />
                                <br />
                                <asp:RequiredFieldValidator runat="server" controltovalidate="major" errormessage="Please enter your major." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="Major (Subject of Study): " AssociatedControlID="major"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="major"></asp:TextBox>
                                <br />
                                <br />
                                <asp:RequiredFieldValidator runat="server" controltovalidate="universityContactInfo" errormessage="Please provide your university contacts information." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="University Contact Information (Name / Phone Number): " AssociatedControlID="universityContactInfo"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="universityContactInfo"></asp:TextBox>
                                <br />
                                <br />
                                <asp:RequiredFieldValidator runat="server" controltovalidate="homestayDuration" errormessage="Please enter your requested homestay length." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="Requested Length of Homestay: " AssociatedControlID="homestayDuration"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="homestayDuration"></asp:TextBox>
                                <br />
                                <br />
                                <asp:RequiredFieldValidator runat="server" controltovalidate="flightInfo" errormessage="Please enter your flight arrival time." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="Flight/Arrival Information (time &amp; date): " AssociatedControlID="flightInfo"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="flightInfo"></asp:TextBox>


                            </asp:Panel> 

                                <br />
                                <br />

                            <asp:Panel runat="server" ID="confirmationPanel" Enabled="False">
                                <div id="accordion">

                                  <h3>Personal Information</h3>

                                  <div class="accordion-content">
                                          <%--name--%>
                                    <asp:RequiredFieldValidator runat="server" controltovalidate="lastName" errormessage="You must provide your last name." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                    <asp:Label AssociatedControlID="lastName" Text="Last Name: " runat="server"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmLastName"></asp:TextBox>

                                    <br />
                                    <br />

                                    <asp:RequiredFieldValidator runat="server" controltovalidate="firstName" errormessage="You must provide your first name." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                    <asp:Label AssociatedControlID="firstName" Text="First Name: " runat="server"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmFirstName"></asp:TextBox>

                                    <br />
                                    <br />

                                    <asp:Label Text="Date of Birth: " runat="server"></asp:Label>
                                    <br />
                                    <asp:DropDownList ID="confirmDDLYear" runat="server" />
                                    <asp:DropDownList ID="confirmDDLMonth" runat="server" />
                                    <asp:DropDownList ID="confirmDDLDay" runat="server" />

                                    <br />
                                    <br />

                               
                             
                                    <asp:Label AssociatedControlID="Country" Text="Nationality: " runat="server"></asp:Label>
                                    <br />
                                    <asp:DropDownList id="confirmCountry" runat="server">
                                    </asp:DropDownList>

                                    <br />
                                    <br />
                           
                                    <asp:RequiredFieldValidator runat="server" controltovalidate="firstLanguage" errormessage="You must provide your first language." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                    <asp:Label AssociatedControlID="firstLanguage" Text="First Language: " runat="server"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmFirstLanguage"></asp:TextBox>

                                    <br />
                                    <br />

                               
                                    <asp:Label AssociatedControlID="gender" Text="Gender: " runat="server"></asp:Label>
                                    <asp:RadioButtonList id="confirmGender"  RepeatDirection="Horizontal" RepeatLayout ="Flow" CssClass="rdoBtnItemSpacing" runat="server">
                                    <asp:ListItem Text="Male" Value="0" Selected="true"/>
                                    <asp:ListItem Text="Female" Value="1" />
                                    </asp:RadioButtonList>

                                    <br />
                                    <br />

                                    <asp:Label AssociatedControlID="martialstatus" Text="Martial Status: " runat="server"></asp:Label>
                                    <asp:RadioButtonList id="confirmMartialStatus"  RepeatDirection="Horizontal" RepeatLayout ="Flow" CssClass="rdoBtnItemSpacing" runat="server">
                                    <asp:ListItem Text="Married" Value="0" Selected="true"/>
                                    <asp:ListItem Text="Unmarried" Value="1" />
                                    </asp:RadioButtonList>
                                  </div>

                                  <h3>Contact Information</h3>

                                  <div class="accordion-content">
                                    <asp:RequiredFieldValidator runat="server" controltovalidate="address" errormessage="Please provide an address." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                    <asp:Label runat="server" Text="Address: " AssociatedControlID="address"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmAddress" Enabled="True" Width="50%"></asp:TextBox>

                                    <br />
                                    <br />

                                    <asp:RequiredFieldValidator runat="server" controltovalidate="phone1" errormessage="Please provide a primary phone number" ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                    <asp:Label runat="server" Text="Primary Phone: " AssociatedControlID="phone1"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmPhone1" Width="50%"></asp:TextBox>

                                    <br />
                                    <br />

                                    <asp:Label runat="server" Text="Secondary Phone: " AssociatedControlID="phone2"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmPhone2" Width="50%"></asp:TextBox>

                                    <br />
                                    <br />


                                    <asp:RequiredFieldValidator runat="server" controltovalidate="email" errormessage="Please enter an email address." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                    <asp:Label runat="server" Text="Email: " AssociatedControlID="email"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmEmail" Width="50%"></asp:TextBox>
                                  </div>
                                  <h3>Conditions & Preferences</h3>
                                  <div class="accordion-content">

                                        <asp:Label AssociatedControlID="transportation" Text="Do you have transportation?: " runat="server"></asp:Label>
                                        <asp:RadioButtonList id="confirmTransportation" CssClass="rdoBtnItemSpacing" runat="server">
                                        <asp:ListItem Text="Yes" Value="0" Selected="true"/>
                                        <asp:ListItem Text="No" Value="1" />
                                        </asp:RadioButtonList>

                                        <br />

                                        <asp:Label runat="server" Text="Allergies, Health Problems or Dietary Restrictions:" AssociatedControlID="allergies"></asp:Label>
                                        <br />
                                        <asp:TextBox id="confirmAllergies" runat="server" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox> 

                                        <br />
                                        <br />

                                        <asp:Label runat="server" Text="Do you have any particular preferences?" AssociatedControlID="hobbies"></asp:Label>
                                        <br />
                                        <asp:TextBox id="confirmHobbies" runat="server" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox> 

                                        <br />
                                        <br />

                                        <asp:Label runat="server" Text="Tell us about yourself: " AssociatedControlID="about"></asp:Label>
                                        <br />
                                         <asp:TextBox id="confirmAbout" runat="server" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox> 

                                        <br />
                                        <br />
                         
                                  </div>
                                  <h3>University Information</h3>
                                  <div class="accordion-content">

                                        <asp:RequiredFieldValidator runat="server" controltovalidate="university" errormessage="Please enter the name of the university you are attending." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                        <asp:Label runat="server" Text="University Name: " AssociatedControlID="university"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmUniversity"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:RequiredFieldValidator runat="server" controltovalidate="universityAddress" errormessage="Please enter the university address." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                        <asp:Label runat="server" Text="University Address: " AssociatedControlID="universityAddress"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmUniversityAddress"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:Label runat="server" Text="Semester Start Date: "></asp:Label>
                                        <br />
                                        <asp:DropDownList ID="DropDownList1" runat="server" onchange ="PopulateDays()" />
                                        <asp:DropDownList ID="DropDownList2" runat="server" onchange ="PopulateDays()" />
                                        <asp:DropDownList ID="DropDownList3" runat="server" />
                                        <br />
                                        <br />
                                        <asp:RequiredFieldValidator runat="server" controltovalidate="major" errormessage="Please enter your major." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                        <asp:Label runat="server" Text="Major (Subject of Study): " AssociatedControlID="major"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmMajor"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:RequiredFieldValidator runat="server" controltovalidate="universityContactInfo" errormessage="Please provide your university contacts information." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                        <asp:Label runat="server" Text="University Contact Information (Name / Phone Number): " AssociatedControlID="universityContactInfo"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmUniversityContactInfo"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:RequiredFieldValidator runat="server" controltovalidate="homestayDuration" errormessage="Please enter your requested homestay length." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                        <asp:Label runat="server" Text="Requested Length of Homestay: " AssociatedControlID="homestayDuration"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmHomestayDuration"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:RequiredFieldValidator runat="server" controltovalidate="flightInfo" errormessage="Please enter your flight arrival time." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                        <asp:Label runat="server" Text="Flight/Arrival Information (time &amp; date): " AssociatedControlID="flightInfo"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmFlightInfo"></asp:TextBox>

                                  </div>
                                </div>
                            </asp:Panel>            
            
                            <br />
                            <br />
            
                        <div id="btnDiv">                         
                                <asp:Button class="btn btn-border" Text="Back" runat="server" id="backButon" OnClick="backButon_OnClick" CausesValidation="false"></asp:Button>
                                <asp:Button class="btn btn-border" Text="Continue" runat="server" id="continueButton" OnClick="continueButton_OnClick"></asp:Button>
                                <asp:Button class="btn btn-border" Text="Submit" runat="server" id="submitButton" OnClick="submitButton_OnClick"></asp:Button>   
                         
                            </div>
                        </div>
  
                </section>
            </div>

           
       
        </form>
        
        <!-- Footer -->
        <div id="footer">
     
                <!-- Social -->
                <section>
                    <ul class="icons">
                        <li><a href="#" class="icon fa-twitter"><span>Twitter</span></a></li>
                        <li><a href="#" class="icon fa-facebook"><span>Facebook</span></a></li>
                        <li><a href="#" class="icon fa-google-plus"><span>Google+</span></a></li>
                        <li><a href="#" class="icon fa-linkedin"><span>Linkedin</span></a></li>
                        <li><a href="#" class="icon fa-pinterest"><span>Pinterest</span></a></li>
                    </ul>
                </section>

                <!-- Copyright -->
                <div class="copyright">
                    &copy; CSS3_lagoon | <a href="http://www.css3templates.co.uk">a css3templates.co.uk design</a>
                </div>

            </div>

    </div>
    
    <!-- Scripts -->
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/jquery.dropotron.min.js"></script>
    <script src="assets/js/skel.min.js"></script>
    <script src="assets/js/util.js"></script>
    <!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
    <script src="assets/js/main.js"></script>
    <script src="js/modernizr.custom.js"></script>

    <!-- Nice-assets .js -->
    <script src="/nice-assets/js/jquery.js"></script>
	<script src="/nice-assets/js/jquery-ui-1.10.4.min.js"></script>
    <script src="/nice-assets/js/jquery-1.8.3.min.js"></script>
    <script type="text/javascript" src="/nice-assets/js/jquery-ui-1.9.2.custom.min.js"></script>
    <!-- bootstrap -->
    <script src="/nice-assets/js/bootstrap.min.js"></script>
    <!-- nice scroll -->
    <script src="/nice-assets/js/jquery.scrollTo.min.js"></script>
    <script src="/nice-assets/js/jquery.nicescroll.js" type="text/javascript"></script>
    <!-- charts scripts -->
    <script src="/nice-assets/assets/jquery-knob/js/jquery.knob.js"></script>
    <script src="/nice-assets/js/jquery.sparkline.js" type="text/javascript"></script>
    <script src="/nice-assets/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.js"></script>
    <script src="/nice-assets/js/owl.carousel.js" ></script>
    <!-- jQuery full calendar -->
    <<script src="/nice-assets/js/fullcalendar.min.js"></script> <!-- Full Google Calendar - Calendar -->
	<script src="/nice-assets/assets/fullcalendar/fullcalendar/fullcalendar.js"></script>
    <!--script for this page only-->
    <script src="/nice-assets/js/calendar-custom.js"></script>
	<script src="/nice-assets/js/jquery.rateit.min.js"></script>
    <!-- custom select -->
    <script src="/nice-assets/js/jquery.customSelect.min.js" ></script>
	<script src="/nice-assets/assets/chart-master/Chart.js"></script>
   
    <!--custome script for all page-->
    <script src="/nice-assets/js/scripts.js"></script>
    <!-- custom script for this page-->
    <script src="/nice-assets/js/sparkline-chart.js"></script>
    <script src="/nice-assets/js/easy-pie-chart.js"></script>
	<script src="/nice-assets/js/jquery-jvectormap-1.2.2.min.js"></script>
	<script src="/nice-assets/js/jquery-jvectormap-world-mill-en.js"></script>
	<script src="/nice-assets/js/xcharts.min.js"></script>
	<script src="/nice-assets/js/jquery.autosize.min.js"></script>
	<script src="/nice-assets/js/jquery.placeholder.min.js"></script>
	<script src="/nice-assets/js/gdp-data.js"></script>	
	<script src="/nice-assets/js/morris.min.js"></script>
	<script src="/nice-assets/js/sparklines.js"></script>	
	<script src="/nice-assets/js/charts.js"></script>
	<script src="/nice-assets/js/jquery.slimscroll.min.js"></script>
    <%-- For the editor--%>
    <script type="text/javascript" src="/nice-assets/assets/ckeditor/ckeditor.js"></script>
    <!--custom tagsinput-->
    <script src="/nice-assets/js/jquery.tagsinput.js"></script>
    <!--custom switch-->
    <script src="/nice-assets/js/bootstrap-switch.js"></script>
    <!-- bootstrap-wysiwyg -->
    <script src="/nice-assets/js/jquery.hotkeys.js"></script>
    <script src="/nice-assets/js/bootstrap-wysiwyg.js"></script>
    <script src="/nice-assets/js/bootstrap-wysiwyg-custom.js"></script>
</body>
</html>
