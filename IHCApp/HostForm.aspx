<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HostForm.aspx.cs" Inherits="IHCApp.HostForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Stay Host Application</title>
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
      $( function() {
          $("#accordion").accordion({
              autoHeight: false,
              heightStyle: 'content'
      });
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
                        <h1><a href="HostForm.aspx">Home Stay</a></h1>
                    </div>

                    <!-- Nav -->
                    <nav id="nav" class="cl-effect-17">
                         <ul>
                                <li><a href="Home.aspx">Home</a></li>
                                <li class="active"><a href="HostForm.aspx">Host</a></li>
                                <li><a href="ApplicantForm.aspx">Stay</a></li>
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
                            <asp:Panel runat="server" id="termsOfServicePanel" HorizontalAlign="Left">
                                <div id="formHTML" runat="server">
                                                               
                                </div>

                                <asp:Label id="labelForTOS" AssociatedControlID="termsOfServiceCheckbox" Text="I agree to the terms of service: " runat="server"></asp:Label>
                                <asp:CheckBox id="termsOfServiceCheckbox" runat="server" Text="" TextAlign="Right" />
                            </asp:Panel>

                            

                            <%-- Family panel --%>
                            <asp:Panel runat="server" id="familyPanel">

                                <asp:RequiredFieldValidator runat="server" controltovalidate="familyName" errormessage="You must provide your families last name." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                 <asp:RegularExpressionValidator runat="server" ControlToValidate="familyName" ErrorMessage="Last Name must only contain letters from A-Z" ForeColor="#ff3300" ValidationExpression="^[A-Za-z]+$" >*</asp:RegularExpressionValidator>
                               <%-- <asp:RegularExpressionValidator runat="server" display="Dynamic"  ControlToValidate="familyName"  ErrorMessage="Family last name can only contain letters." ValidationExpression="123456789.*[@#$%^&*/].*" ForeColor="#ff3300" >*</asp:RegularExpressionValidator>--%>

                                   
                                <%--family name--%>
                                <asp:Label AssociatedControlID="familyName" Text="Host Last Name: " runat="server" ></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="familyName"></asp:TextBox>

                                <br />
                                <br />


                                <asp:Label AssociatedControlID="familyCnt" Text="Number of host members:" runat="server"></asp:Label>
                                <br />
                                <asp:DropDownList runat="server" ID="familyCnt" OnSelectedIndexChanged="familyCnt_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="4" Text ="4" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="5" Text ="5" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="6" Text ="6" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="7" Text ="7" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="8" Text ="8" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="9" Text ="9" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="10" Text ="10" Enabled="True"></asp:ListItem>
                                </asp:DropDownList>
                
                                <br />

                                <asp:Panel runat="server" ID="familyListPanel" Width="100%"></asp:Panel>

                                <br />
             
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
                                  <asp:RegularExpressionValidator runat="server" ControlToValidate="phone1" ErrorMessage="Phone numbers must only contain numbers from 1-0" ForeColor="#ff3300" ValidationExpression="^[0-9]{1,10}$" >*</asp:RegularExpressionValidator>
                                <asp:Label runat="server" Text="Primary Phone: " AssociatedControlID="phone1"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="phone1" Width="50%"></asp:TextBox>

                                <br />
                                <br />
                                  <asp:RegularExpressionValidator runat="server" ControlToValidate="phone2" ErrorMessage="Phone numbers must only contain numbers from 1-0" ForeColor="#ff3300" ValidationExpression="^[0-9]{1,10}$" >*</asp:RegularExpressionValidator>
                                <asp:Label runat="server" Text="Secondary Phone: " AssociatedControlID="phone2"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="phone2" Width="50%"></asp:TextBox>

                                <br />
                                <br />


                                <asp:RequiredFieldValidator runat="server" controltovalidate="email" errormessage="Please enter an email address." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                  <asp:RegularExpressionValidator runat="server" ControlToValidate="email" ErrorMessage="You must enter a valid Email" ForeColor="#ff3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" >*</asp:RegularExpressionValidator>
                                <asp:Label runat="server" Text="Email: " AssociatedControlID="email"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="email" Width="50%"></asp:TextBox>
                    
                            </asp:Panel>
            
            
                            <%-- living details panel --%>
                            <asp:Panel runat="server" id="livingDetailsPanel" Enabled="False">

                                <asp:Label runat="server" Text="Allow Smoking: " AssociatedControlID="allowSmoking"></asp:Label>
                                <br />
                                <asp:RadioButtonList id="allowSmoking" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="yes" Value="yes"/>
                                <asp:ListItem Text="no" Value="no" Selected="true" />
                                </asp:RadioButtonList>

                                <asp:Label runat="server" Text="Allow Smoking: " AssociatedControlID="allowDrinking"></asp:Label>
                                <br />
                                <asp:RadioButtonList id="allowDrinking" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="yes" Value="yes"/>
                                <asp:ListItem Text="no" Value="no" Selected="true" />
                                </asp:RadioButtonList>


                         

                                <asp:Label runat="server" Text="Does anyone in your homestay smoke: " AssociatedControlID="familySmoke"></asp:Label>
                                 <br />
                                 <asp:RadioButtonList id="familySmoke" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="yes" Value="yes"/>
                                <asp:ListItem Text="no" Value="no" Selected="true" />
                                </asp:RadioButtonList>



                                <asp:Label runat="server" Text="Does anyone in your homestay drink: " AssociatedControlID="familyDrinking"></asp:Label>
                                <br />
                                <asp:RadioButtonList id="familyDrinking" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="yes" Value="yes"/>
                                <asp:ListItem Text="no" Value="no"  Selected="true" />
                                </asp:RadioButtonList>


                                <asp:Label AssociatedControlID="dogs" Text="Number of dogs: " runat="server"></asp:Label>
                                <asp:DropDownList runat="server" ID="dogs">
                                    <asp:ListItem Value="0" Text="None" Selected="True" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="1" Text ="1" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                                </asp:DropDownList>

        
                                <br />
                                  <br />
             
                                <asp:Label AssociatedControlID="cats" Text="Number of cats: " runat="server"></asp:Label>
                        
                                <asp:DropDownList runat="server" ID="cats">
                                    <asp:ListItem Value="0" Text ="None" Selected="True" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="1" Text ="1"  Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                                </asp:DropDownList>

                                <br />
                                  <br />
             
                                <asp:Label AssociatedControlID="internet" Text= "Internet access details:" runat="server"></asp:Label>
                    
                                <asp:DropDownList runat="server" ID="internet">
                                    <asp:ListItem Value="None" Text ="None" Selected="True" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="High Speed Wifi" Text ="High Speed Wifi" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="Normal Wifi" Text ="Normal Wifi" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="Wired" Text ="Wired" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="Other" Text ="Other" Enabled="True"></asp:ListItem>
                                </asp:DropDownList>

                                <br />
                                  <br />

                                <asp:Label AssociatedControlID="bathrooms" Text="Number of guest bathrooms: " runat="server"></asp:Label>
                         
                                <asp:DropDownList runat="server" ID="bathrooms">
                                    <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                                </asp:DropDownList>

                                <br />
                                  <br />

                                <asp:RequiredFieldValidator runat="server" controltovalidate="transportation" errormessage="Please describe the method of transportation intended for the guest." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                <asp:Label runat="server" Text="Please describe the method of transportation intended for the guest:" AssociatedControlID="transportation"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="transportation" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox>
                          
                            </asp:Panel>
            
            
                            <%-- additional information panel --%>
                            <asp:Panel runat="server" ID="moreInfoPanel" Enabled="False">
                
                                <asp:Label runat="server" Text="What are some things you or others in your home enjoy doing?" AssociatedControlID="hobbies"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="hobbies" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox>

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Please supply some additonal information so we can match you with the best candidate." AssociatedControlID="about"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="about" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox>

                            </asp:Panel> 
                        
                          <asp:Panel runat="server" ID="confirmationPanel" Enabled="False">
                                <div id="accordion">

                                     <h3>Family Information</h3>
                                  <div class="accordion-content">

                                        <asp:Label AssociatedControlID="familyName" Text="Host Last Name: " runat="server" ></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmFamilyName"></asp:TextBox>

                                        <br />
                                        <br />


                                        <asp:Label AssociatedControlID="familyCnt" Text="Number of host members:" runat="server"></asp:Label>
                                        <br />
                                        <asp:DropDownList runat="server" ID="confirmfamilyCnt" OnSelectedIndexChanged="familyCnt_SelectedIndexChanged" AutoPostBack="true">
                                            <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="4" Text ="4" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="5" Text ="5" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="6" Text ="6" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="7" Text ="7" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="8" Text ="8" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="9" Text ="9" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="10" Text ="10" Enabled="True"></asp:ListItem>
                                        </asp:DropDownList>
                
                                        <br />

                                        <asp:Panel runat="server" ID="confirmFamilyMembersPanel" Width="100%"></asp:Panel>

                                        <br />
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

                                  <h3>Living Details</h3>

                                  <div class="accordion-content">
                                        <asp:Label runat="server" Text="Allow Smoking: " AssociatedControlID="allowSmoking"></asp:Label>
                                        <br />
                                        <asp:RadioButtonList id="confirmAllowSmoking" CssClass="rdoBtnItemSpacing" runat="server">
                                        <asp:ListItem Text="yes" Value="yes"/>
                                        <asp:ListItem Text="no" Value="no" Selected="true" />
                                        </asp:RadioButtonList>


                                        <asp:Label runat="server" Text="Allow Drinking: " AssociatedControlID="allowSmoking"></asp:Label>
                                        <br />
                                        <asp:RadioButtonList id="confirmAllowDrinking" CssClass="rdoBtnItemSpacing" runat="server">
                                        <asp:ListItem Text="yes" Value="yes"/>
                                        <asp:ListItem Text="no" Value="no" Selected="true" />
                                        </asp:RadioButtonList>


                         

                                        <asp:Label runat="server" Text="Does anyone in your homestay smoke: " AssociatedControlID="familySmoke"></asp:Label>
                                         <br />
                                         <asp:RadioButtonList id="confirmFamilySmoke" CssClass="rdoBtnItemSpacing" runat="server">
                                        <asp:ListItem Text="yes" Value="yes"/>
                                        <asp:ListItem Text="no" Value="no" Selected="true" />
                                        </asp:RadioButtonList>



                                        <asp:Label runat="server" Text="Does anyone in your homestay drink: " AssociatedControlID="familyDrinking"></asp:Label>
                                        <br />
                                        <asp:RadioButtonList id="RadioButtonList3" CssClass="rdoBtnItemSpacing" runat="server">
                                        <asp:ListItem Text="yes" Value="yes"/>
                                        <asp:ListItem Text="no" Value="no"  Selected="true" />
                                        </asp:RadioButtonList>


                                        <asp:Label AssociatedControlID="dogs" Text="Number of dogs: " runat="server"></asp:Label>
                                        <asp:DropDownList runat="server" ID="confirmDogs">
                                            <asp:ListItem Value="0" Text="None" Selected="True" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="1" Text ="1" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                                        </asp:DropDownList>

        
                                        <br />
                                          <br />
             
                                        <asp:Label AssociatedControlID="cats" Text="Number of cats: " runat="server"></asp:Label>
                        
                                        <asp:DropDownList runat="server" ID="confirmCats">
                                            <asp:ListItem Value="0" Text ="None" Selected="True" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="1" Text ="1"  Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                                        </asp:DropDownList>

                                        <br />
                                          <br />
             
                                        <asp:Label AssociatedControlID="internet" Text= "Internet access details:" runat="server"></asp:Label>
                    
                                        <asp:DropDownList runat="server" ID="confirmInternet">
                                            <asp:ListItem Value="None" Text ="None" Selected="True" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="High Speed Wifi" Text ="High Speed Wifi" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="Normal Wifi" Text ="Normal Wifi" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="Wired" Text ="Wired" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="Other" Text ="Other" Enabled="True"></asp:ListItem>
                                        </asp:DropDownList>

                                        <br />
                                          <br />

                                        <asp:Label AssociatedControlID="bathrooms" Text="Number of guest bathrooms: " runat="server"></asp:Label>
                         
                                        <asp:DropDownList runat="server" ID="confirmBathrooms">
                                            <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                            <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                                        </asp:DropDownList>

                                        <br />
                                          <br />

                                        <asp:RequiredFieldValidator runat="server" controltovalidate="transportation" errormessage="Please describe the method of transportation intended for the guest." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                                        <asp:Label runat="server" Text="Please describe the method of transportation intended for the guest:" AssociatedControlID="transportation"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmTransportation" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox>
                          
                                  
                         
                                  </div>
                                  <h3>Additional Information</h3>

                                  <div class="accordion-content">

                                        <asp:Label runat="server" Text="What are some things you or others in your home enjoy doing?" AssociatedControlID="hobbies"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmHobbies" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox>

                                        <br />
                                        <br />

                                        <asp:Label runat="server" Text="Please supply some additonal information so we can match you with the best candidate." AssociatedControlID="about"></asp:Label>
                                        <br />
                                        <asp:TextBox runat="server" id="confirmAbout" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox>

                             

                                  </div>
                                </div>
                            </asp:Panel>                       
            
            
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
    <script src="WebAssets/nice-assets/assets/WebAssets/assets/jquery-knob/js/jquery.knob.js"></script>
    <script src="WebAssets/nice-assets/assets/js/jquery.sparkline.js" type="text/javascript"></script>
    <script src="WebAssets/nice-assets/assets/WebAssets/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.js"></script>
    <script src="WebAssets/nice-assets/assets/js/owl.carousel.js" ></script>
    <!-- jQuery full calendar -->
    <<script src="WebAssets/nice-assets/assets/js/fullcalendar.min.js"></script> <!-- Full Google Calendar - Calendar -->
	<script src="WebAssets/nice-assets/assets/WebAssets/assets/fullcalendar/fullcalendar/fullcalendar.js"></script>
    <!--script for this page only-->
    <script src="WebAssets/nice-assets/assets/js/calendar-custom.js"></script>
	<script src="WebAssets/nice-assets/assets/js/jquery.rateit.min.js"></script>
    <!-- custom select -->
    <script src="WebAssets/nice-assets/assets/js/jquery.customSelect.min.js" ></script>
	<script src="WebAssets/nice-assets/assets/WebAssets/assets/chart-master/Chart.js"></script>
   
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
