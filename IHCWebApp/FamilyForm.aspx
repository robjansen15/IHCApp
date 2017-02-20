<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FamilyForm.aspx.cs" Inherits="UserWebApp.FamilyForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Stay Family Application</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!--[if lte IE 8]><script src="assets/js/ie/html5shiv.js"></script><![endif]-->
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
                            <li class="active"><a href="index.html">Home</a></li>
                            <li><a href="services.html">Host a Family</a></li>
                            <li><a href="apage.html">Visit</a></li>
                            <li><a href="contact.php">Contact</a></li>
                        </ul>
                    </nav>

                </div>
            </div>

        <form id="form1" runat="server">
        
            <!-- Main -->
            <div id="main">
                <section class="container">

                    <div id="formDiv" style="text-align:center">
                            <%-- Family panel --%>
                            <asp:Panel runat="server" id="familyPanel">
                
                                <%--family name--%>
                                <asp:Label AssociatedControlID="familyName" Text="Family Name? " runat="server"></asp:Label>
                                <asp:TextBox runat="server" id="familyName"></asp:TextBox>

                                <br />
                                <br />
                                <asp:Label AssociatedControlID="familyCnt" Text="How many family members? " runat="server"></asp:Label>
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

                                <asp:Panel runat="server" ID="familyListPanel"></asp:Panel>

                                <br />
             
                            </asp:Panel>
         

                            <%-- Contact info panel --%>
                            <asp:Panel runat="server" id="contactInfoPanel" Enabled="False">

                                <asp:Label runat="server" Text="Address? " AssociatedControlID="address"></asp:Label>
                                <asp:TextBox runat="server" id="address" Enabled="True"></asp:TextBox>

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Primary Phone? " AssociatedControlID="phone1"></asp:Label>
                                <asp:TextBox runat="server" id="phone1"></asp:TextBox>

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Secondary Phone? " AssociatedControlID="phone2"></asp:Label>
                                <asp:TextBox runat="server" id="phone2"></asp:TextBox>

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Email? " AssociatedControlID="email"></asp:Label>
                                <asp:TextBox runat="server" id="email"></asp:TextBox>
                    
                            </asp:Panel>
            
            
                            <%-- living details panel --%>
                            <asp:Panel runat="server" id="livingDetailsPanel" Enabled="False">

                                <asp:Label runat="server" Text="Allow Smoking? " AssociatedControlID="allowSmoking"></asp:Label>
                                <asp:CheckBox runat="server" ID="allowSmoking" />

                                <br />

                                <br />

                                <asp:Label runat="server" Text="Does anyone in your family smoke? " AssociatedControlID="familySmoke"></asp:Label>
                                <asp:CheckBox runat="server" ID="familySmoke" />

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Does anyone in your family smoke? " AssociatedControlID="allowDrinking"></asp:Label>
                                <asp:CheckBox runat="server" ID="allowDrinking" />

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Does anyone in your family drink? " AssociatedControlID="familyDrinking"></asp:Label>
                                <asp:CheckBox runat="server" ID="familyDrinking" />

                                <br />
                                <br />

                                <asp:Label AssociatedControlID="dogs" Text="How many dogs do you own? " runat="server"></asp:Label>
                                <asp:DropDownList runat="server" ID="dogs">
                                    <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                                </asp:DropDownList>

                                <br />
                                <br />
             
                                <asp:Label AssociatedControlID="cats" Text="How many cats do you own? " runat="server"></asp:Label>
                                <asp:DropDownList runat="server" ID="cats">
                                    <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                                </asp:DropDownList>

                                <br />
                                <br />
             
                                <asp:Label AssociatedControlID="internet" Text="How kind of internet do you have? " runat="server"></asp:Label>
                                <asp:DropDownList runat="server" ID="internet">
                                    <asp:ListItem Value="High Speed Wifi" Text ="High Speed Wifi" Selected="True" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="Normal Wifi" Text ="Normal Wifi" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="Wired" Text ="Wired" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="Other" Text ="Other" Enabled="True"></asp:ListItem>
                                </asp:DropDownList>

                                <br />
                                <br />

                                <asp:Label AssociatedControlID="bathrooms" Text="How many bathrooms will your guest have access to? " runat="server"></asp:Label>
                                <asp:DropDownList runat="server" ID="bathrooms">
                                    <asp:ListItem Value="1" Text ="1" Selected="True" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="2" Text ="2" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="3" Text ="3" Enabled="True"></asp:ListItem>
                                    <asp:ListItem Value="9" Text ="More than 3" Enabled="True"></asp:ListItem>
                                </asp:DropDownList>

                                <asp:Label runat="server" Text="Is the primary bathroom shared? " AssociatedControlID="shareBathroom"></asp:Label>
                                <asp:CheckBox runat="server" ID="shareBathroom" />

                                <br />
                                <br />

                                <asp:Label runat="server" Text="How can your guest trasport downtown? How long does it take approximately? What bus number? Additional details?" AssociatedControlID="transportation"></asp:Label>
                                <asp:TextBox runat="server" id="transportation"></asp:TextBox>
                          
                            </asp:Panel>
            
            
                            <%-- additional information panel --%>
                            <asp:Panel runat="server" ID="moreInfoPanel" Enabled="False">
                
                                <asp:Label runat="server" Text="What are some things your family enjoys doing?" AssociatedControlID="hobbies"></asp:Label>
                                <asp:TextBox runat="server" id="hobbies"></asp:TextBox>

                                <br />
                                <br />

                                <asp:Label runat="server" Text="Please supply some additonal information so we can match you with the best candidate." AssociatedControlID="about"></asp:Label>
                                <asp:TextBox runat="server" id="about"></asp:TextBox>

                            </asp:Panel>            
            
                            <br />
                            <br />
            
                            <div id="btnDiv">                             
                                <div>
                                    <asp:ImageButton ImageUrl="images/back.png" runat="server" id="backButon" OnClick="backButon_OnClick"></asp:ImageButton>
                                </div>
                                
                                <div>
                                <asp:ImageButton  ImageUrl="images/next.png" runat="server" id="continueButton" OnClick="continueButton_OnClick"></asp:ImageButton>     
                                </div>
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
