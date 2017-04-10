<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicantForm.aspx.cs" Inherits="IHCApp.ApplicantForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Stay Family Application</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!--[if lte IE 8]><script src="WebAssets/assets/js/ie/html5shiv.js"></script><![endif]-->

    <link rel="stylesheet" type="text/css" href="WebAssets/nice-assets\assets\jquery-ui\jquery-ui-1.10.1.custom.css" />
    <link rel="stylesheet" type="text/css" href="WebAssets/assets/linkeffects/css/normalize.css" />
	<link rel="stylesheet" type="text/css" href="WebAssets/assets/linkeffects/css/demo.css" />
	<link rel="stylesheet" type="text/css" href="WebAssets/assets/linkeffects/css/component.css" />
    <link rel="stylesheet" href="WebAssets/assets/css/style.css" />
    <link rel="stylesheet" href="WebAssets/assets/css/main.css" />

    <!-- temp assets -->
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
      $(function () {
          $("#accordion").accordion({
              autoHeight: false,
              heightStyle: 'panel'
          });
      });
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
                        <h1><a href="ApplicantForm.aspx">Home Stay</a></h1>
                    </div>

                    <!-- Nav -->
                    <nav id="nav" class="cl-effect-17">
                         <ul>
                                <li> <a href="Home.aspx">Home</a></li>
                                <li><a href="HostForm.aspx">Host</a></li>
                                <li class="active"><a href="ApplicantForm.aspx">Stay</a></li>
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
                                <div id="formHTML" runat="server">                            
                                   
                                </div>

                                <asp:Label ID="labelForTOS" AssociatedControlID="termsOfServiceCheckbox" Text="I agree to the terms of service: " runat="server"></asp:Label>
                                <asp:CheckBox id="termsOfServiceCheckbox" runat="server" Text="" TextAlign="Right" />

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
                                <asp:DropDownList ID="ddlYear" runat="server" onchange ="PopulateDOBDays()" />
                                <asp:DropDownList ID="ddlMonth" runat="server" onchange ="PopulateDOBDays()" />
                                <asp:DropDownList ID="ddlDay" runat="server" />

                                <br />
                                <br />

                               
                                <%-- temporary way to populate countries --%>
                             <%--   <asp:CompareValidator ControlToValidate="Country" ID="CompareValidator"  ValidationGroup="g1" ErrorMessage="Please select a country."  runat="server" Display="Dynamic" Operator="NotEqual" ValueToCompare="0" Type="Integer" Text="*" ForeColor="#ff3300" />--%>
                                <asp:Label AssociatedControlID="Country" Text="Nationality: " runat="server"></asp:Label>
                                <br />
                                <asp:DropDownList id="Country" runat="server">
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
                                <asp:ListItem Text="Male" Value="Male" Selected="true"/>
                                <asp:ListItem Text="Female" Value="Female" />
                                </asp:RadioButtonList>

                                <br />
                                <br />

                                <asp:Label AssociatedControlID="martialstatus" Text="Martial Status: " runat="server"></asp:Label>
                                <asp:RadioButtonList id="martialstatus"  RepeatDirection="Horizontal" RepeatLayout ="Flow" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="Married" Value="Married" Selected="true"/>
                                <asp:ListItem Text="Unmarried" Value="Unmarried" />
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
                
                                <asp:RequiredFieldValidator runat="server" controltovalidate="university" errormessage="Please enter the name of your sponser institution." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="Sponsor Institution (name of school, company or organization):" AssociatedControlID="university"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="university"></asp:TextBox>
                                <br />
                                <br />
                                <asp:RequiredFieldValidator runat="server" controltovalidate="universityAddress" errormessage="Please enter the address of your sponsor institution." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="Sponsor Institution Address: " AssociatedControlID="universityAddress"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="universityAddress"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label runat="server" Text="Program Start Date: "></asp:Label>
                                <br />
                                <asp:DropDownList ID="y" runat="server" onchange ="PopulateDays()" />
                                <asp:DropDownList ID="m" runat="server" onchange ="PopulateDays()" />
                                <asp:DropDownList ID="d" runat="server" />
                                <br />
                                <br />
                               <%-- <asp:RequiredFieldValidator runat="server" controltovalidate="major" errormessage="Please enter your major." ForeColor="#ff3300">*</asp:RequiredFieldValidator>--%>
                                <asp:Label runat="server" Text="Major (Subject of Study) if applicable: " AssociatedControlID="major"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="major"></asp:TextBox>
                                <br />
                                <br />
                                <asp:RequiredFieldValidator runat="server" controltovalidate="universityContactInfo" errormessage="Please provide your university contacts information." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="Sponsor Contact Information (Name / Phone Number): " AssociatedControlID="universityContactInfo"></asp:Label>
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


                            </asp:Panel> 

                                <br />
                                <br />

                            <asp:Panel runat="server" ID="confirmationPanel" Enabled="False">
                                <div id="accordion">

                                  <h3>Personal Information</h3>

                                  <div class="accordion-content">
                                          <%--name--%>
                                   
                                    <asp:Label AssociatedControlID="lastName" Text="Last Name: " runat="server"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmLastName"></asp:TextBox>

                                    <br />
                                    <br />

                                    
                                    <asp:Label AssociatedControlID="firstName" Text="First Name: " runat="server"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmFirstName"></asp:TextBox>

                                    <br />
                                    <br />

                                    <asp:Label Text="Date of Birth: " runat="server"></asp:Label>
                                    <br />

                                    <asp:TextBox runat="server" id="confirmDOB"></asp:TextBox>

                                    <br />
                                    <br />

                               
                             
                                    <asp:Label AssociatedControlID="Country" Text="Nationality: " runat="server"></asp:Label>
                                    <br />
                                    <asp:DropDownList id="confirmCountry" runat="server">
                                    </asp:DropDownList>

                                    <br />
                                    <br />
                           
                                    
                                    <asp:Label AssociatedControlID="firstLanguage" Text="First Language: " runat="server"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmFirstLanguage"></asp:TextBox>

                                    <br />
                                    <br />

                               
                                    <asp:Label AssociatedControlID="gender" Text="Gender: " runat="server"></asp:Label>
                                    <asp:RadioButtonList id="confirmGender"  RepeatDirection="Horizontal" RepeatLayout ="Flow" CssClass="rdoBtnItemSpacing" runat="server">
                                    <asp:ListItem Text="Male" Value="Male" Selected="true"/>
                                    <asp:ListItem Text="Female" Value="Female" />
                                    </asp:RadioButtonList>

                                    <br />
                                    <br />

                                    <asp:Label AssociatedControlID="martialstatus" Text="Martial Status: " runat="server"></asp:Label>
                                    <asp:RadioButtonList id="confirmMartialStatus"  RepeatDirection="Horizontal" RepeatLayout ="Flow" CssClass="rdoBtnItemSpacing" runat="server">
                                    <asp:ListItem Text="Married" Value="Married" Selected="true"/>
                                    <asp:ListItem Text="Unmarried" Value="Unmarried" />
                                    </asp:RadioButtonList>
                                  </div>

                                  <h3>Contact Information</h3>

                                  <div class="accordion-content">
                      
                                    <asp:Label runat="server" Text="Address: " AssociatedControlID="address"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="confirmAddress" Enabled="True" Width="50%"></asp:TextBox>

                                    <br />
                                    <br />

                    
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

       
                                        <asp:Label runat="server" Text="Sponsor Institution (name of school, company or organization): " AssociatedControlID="university"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmUniversity"></asp:TextBox>
                                        <br />
                                        <br />
                                     
                                        <asp:Label runat="server" Text="Sponsor Institution Address: " AssociatedControlID="universityAddress"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmUniversityAddress"></asp:TextBox>
                                        <br />
                                        <br />
                                        <asp:Label runat="server" Text="Program Start Date: "></asp:Label>
                                        <br />
                                        <br />
                                        <br />
                       
                                        <asp:Label runat="server" Text="Major (Subject of Study) if applicable: " AssociatedControlID="major"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmMajor"></asp:TextBox>
                                        <br />
                                        <br />
                                      
                                        <asp:Label runat="server" Text="Sponsor Contact Information (Name / Phone Number): " AssociatedControlID="universityContactInfo"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmUniversityContactInfo"></asp:TextBox>
                                        <br />
                                        <br />
                                        
                                        <asp:Label runat="server" Text="Requested Length of Homestay: " AssociatedControlID="homestayDuration"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmHomestayDuration"></asp:TextBox>
                                        <br />
                                        <br />
                           
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
    <script src="WebWebAssets/assets/js/jquery.min.js"></script>
    <script src="WebWebAssets/assets/js/jquery.dropotron.min.js"></script>
    <script src="WebWebAssets/assets/js/skel.min.js"></script>
    <script src="WebWebAssets/assets/js/util.js"></script>
    <!--[if lte IE 8]><script src="WebAssets/assets/js/ie/respond.min.js"></script><![endif]-->
    <script src="WebWebAssets/assets/js/main.js"></script>
    <script src="WebWebAssets/assets//js/modernizr.custom.js"></script>

      <!-- Nice-assets .js -->
    <script src="WebAssets/nice-assets/assets/js/jquery.js"></script>
	<script src="WebAssets/nice-assets/assets/js/jquery-ui-1.10.4.min.js"></script>
    <script src="WebAssets/nice-assets/assets/js/jquery-1.8.3.min.js"></script>
    <script type="text/javascript" src="WebAssets/nice-assets/assets/js/jquery-ui-1.9.2.custom.min.js"></script>
    <!-- bootstrap -->
    <script src="WebAssets/nice-assets/assets/js/bootstrap.min.js"></script>
    <!-- nice scroll -->
    <script src="WebAssets/nice-assets/assets/js/jquery.scrollTo.min.js"></script>
    <script src="WebAssets/nice-assets/assets/js/jquery.nicescroll.js" type="text/javascript"></script>
    <!-- charts scripts -->
    <script src="WebAssets/nice-assets/assets/jquery-knob/js/jquery.knob.js"></script>
    <script src="WebAssets/nice-assets/assets/js/jquery.sparkline.js" type="text/javascript"></script>
    <script src="WebAssets/nice-assets/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.js"></script>
    <script src="WebAssets/nice-assets/assets/js/owl.carousel.js" ></script>
    <!-- jQuery full calendar -->
    <<script src="WebAssets/nice-assets/assets/js/fullcalendar.min.js"></script> <!-- Full Google Calendar - Calendar -->
	<script src="WebAssets/nice-assets/assets/fullcalendar/fullcalendar/fullcalendar.js"></script>
    <!--script for this page only-->
    <script src="WebAssets/nice-assets/assets/js/calendar-custom.js"></script>
	<script src="WebAssets/nice-assets/assets/js/jquery.rateit.min.js"></script>
    <!-- custom select -->
    <script src="WebAssets/nice-assets/assets/js/jquery.customSelect.min.js" ></script>
	<script src="WebAssets/nice-assets/assets/chart-master/Chart.js"></script>
   
    <!--custome script for all page-->
    <script src="WebAssets/nice-assets/assets/js/scripts.js"></script>
    <!-- custom script for this page-->
    <script src="WebAssets/nice-assets/js/sparkline-chart.js"></script>
    <script src="WebAssets/nice-assets/js/easy-pie-chart.js"></script>
	<script src="WebAssets/nice-assets/js/jquery-jvectormap-1.2.2.min.js"></script>
	<script src="WebAssets/nice-assets/js/jquery-jvectormap-world-mill-en.js"></script>
	<script src="WebAssets/nice-assets/js/xcharts.min.js"></script>
	<script src="WebAssets/nice-assets/js/jquery.autosize.min.js"></script>
	<script src="WebAssets/nice-assets/js/jquery.placeholder.min.js"></script>
	<script src="WebAssets/nice-assets/js/gdp-data.js"></script>	
	<script src="WebAssets/nice-assets/js/morris.min.js"></script>
	<script src="WebAssets/nice-assets/js/sparklines.js"></script>	
	<script src="WebAssets/nice-assets/js/charts.js"></script>
	<script src="WebAssets/nice-assets/js/jquery.slimscroll.min.js"></script>
    <%-- For the editor--%>
    <script type="text/javascript" src="WebAssets/nice-assets/assets/ckeditor/ckeditor.js"></script>
    <!--custom tagsinput-->
    <script src="WebAssets/nice-assets/js/jquery.tagsinput.js"></script>
    <!--custom switch-->
    <script src="WebAssets/nice-assets/js/bootstrap-switch.js"></script>
    <!-- bootstrap-wysiwyg -->
    <script src="WebAssets/nice-assets/js/jquery.hotkeys.js"></script>
    <script src="WebAssets/nice-assets/js/bootstrap-wysiwyg.js"></script>
    <script src="WebAssets/nice-assets/js/bootstrap-wysiwyg-custom.js"></script>
</body>
</html>
