<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FamilyForm.aspx.cs" Inherits="UserWebApp.FamilyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Stay Family Application</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
    <link rel="stylesheet" href="assets/css/style.css" />
    <link rel="stylesheet" href="assets/css/main.css" />
</head>
<body class="homepage">

    <div id="page-wrapper">
        <!-- Header -->
        <div id="header">
                <div class="container">

                    <!-- Logo -->
                    <div id="logo">
                        <span class="pennant"><span class="icon fa-tint"></span></span>
                        <h1><a href="FamilyForm.aspx">Home Stay</a></h1>
                    </div>

                    <!-- Nav -->
                    <nav id="nav">
                        <ul>
                            <li><a href="index.html">Home</a></li>
                            <li class="active"><a href="services.html">Host a Student</a></li>
                            <li><a href="StudentForm.aspx">Student Application</a></li>
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
                            <%-- Family panel --%>
                            <asp:Panel runat="server" id="familyPanel">

                                <asp:RequiredFieldValidator runat="server" controltovalidate="familyName" errormessage="You must provide your families last name." ForeColor="#ff3300">*</asp:RequiredFieldValidator>
                               <%-- <asp:RegularExpressionValidator runat="server" display="Dynamic"  ControlToValidate="familyName"  ErrorMessage="Family last name can only contain letters." ValidationExpression="123456789.*[@#$%^&*/].*" ForeColor="#ff3300" >*</asp:RegularExpressionValidator>--%>

                                   
                                <%--family name--%>
                                <asp:Label AssociatedControlID="familyName" Text="Family Last Name: " runat="server" ></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="familyName"></asp:TextBox>

                                <br />
                                <br />


                                <asp:Label AssociatedControlID="familyCnt" Text="Number of family members:" runat="server"></asp:Label>
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
            
            
                            <%-- living details panel --%>
                            <asp:Panel runat="server" id="livingDetailsPanel" Enabled="False">

                                <asp:Label runat="server" Text="Allow Smoking: " AssociatedControlID="allowSmoking"></asp:Label>
                                <br />
                                <asp:RadioButtonList id="allowSmoking" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="Yes" Value="0"/>
                                <asp:ListItem Text="No" Value="1" Selected="true" />
                                </asp:RadioButtonList>


                         

                                <asp:Label runat="server" Text="Does anyone in your family smoke: " AssociatedControlID="familySmoke"></asp:Label>
                                 <br />
                                 <asp:RadioButtonList id="familySmoke" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="Yes" Value="0"/>
                                <asp:ListItem Text="No" Value="1" Selected="true" />
                                </asp:RadioButtonList>



                                <asp:Label runat="server" Text="Does anyone in your family drink: " AssociatedControlID="familyDrinking"></asp:Label>
                                <br />
                                <asp:RadioButtonList id="familyDrinking" CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="Yes" Value="0"/>
                                <asp:ListItem Text="No" Value="1"  Selected="true" />
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
                
                                <asp:Label runat="server" Text="What are some things your family enjoys doing?" AssociatedControlID="hobbies"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="hobbies" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox>

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Please supply some additonal information so we can match you with the best candidate." AssociatedControlID="about"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="about" Height="100px" TextMode="MultiLine" Width="70%"></asp:TextBox>

                            </asp:Panel>            
            
            
                            <div id="btnDiv">                         
                     
                                   
                                <asp:Button class="btn btn-border" Text="Back" runat="server" id="backButon" OnClick="backButon_OnClick" CausesValidation="false"></asp:Button>
                                <asp:Button class="btn btn-border" Text="Continue" runat="server" id="continueButton" OnClick="continueButton_OnClick"></asp:Button>     
                         
                            </div>
                        </div>
  
                </section>
            </div>

           
       
        </form>
        
        <!-- Footer -->
        <div id="footer">
            <div class="container">         
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
    </div>
    
    <!-- Scripts -->
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/jquery.dropotron.min.js"></script>
    <script src="assets/js/skel.min.js"></script>
    <script src="assets/js/util.js"></script>
    <!--[if lte IE 8]><script src="assets/js/ie/respond.min.js"></script><![endif]-->
    <script src="assets/js/main.js"></script>
</body>
</html>
