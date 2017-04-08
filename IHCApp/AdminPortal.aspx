<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPortal.aspx.cs" Inherits="IHCApp.AdminPortal" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Portal</title>

    <!-- Bootstrap CSS -->    
    <link href="WebAssets/nice-assets/css/bootstrap.min.css" rel="stylesheet" />
    <!-- bootstrap theme -->
    <link href="WebAssets/nice-assets/css/bootstrap-theme.css" rel="stylesheet" />
    <!--external css-->
    <!-- font icon -->
    <link href="WebAssets/nice-assets/css/elegant-icons-style.css" rel="stylesheet" />
    <link href="WebAssets/nice-assets/css/font-awesome.min.css" rel="stylesheet" />    
    <!-- full calendar css-->
    <link href="WebAssets/nice-assets/assets/fullcalendar/fullcalendar/bootstrap-fullcalendar.css" rel="stylesheet" />
	<link href="WebAssets/nice-assets/assets/fullcalendar/fullcalendar/fullcalendar.css" rel="stylesheet" />
    <!-- easy pie chart-->
    <link href="WebAssets/nice-assets/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.css" rel="stylesheet" type="text/css" media="screen"/>
    <!-- owl carousel -->
    <link rel="stylesheet" href="WebAssets/nice-assets/css/owl.carousel.css" type="text/css" />
    <link href="WebAssets/nice-assets/css/jquery-jvectormap-1.2.2.css" rel="stylesheet" />
    <!-- Custom styles -->
    <link href="WebAssets/nice-assets/css/fullcalendar.css" rel="stylesheet" />
    <link href="WebAssets/nice-assets/css/widgets.css" rel="stylesheet" />
    <link href="WebAssets/nice-assets/css/style-responsive.css" rel="stylesheet" />
    <link href="WebAssets/nice-assets/css/xcharts.min.css" rel=" stylesheet" />	
    <link href="WebAssets/nice-assets/css/jquery-ui-1.10.4.min.css" rel="stylesheet" />
    <link href="WebAssets/nice-assets/css/style.css" rel="stylesheet" />

    <style type="text/css">

        .modalBackground {
    
        background-color: Black !important;
        filter: alpha(opacity=90) !important;
        opacity: 0.7 !important;
        }

        .modalPopup {
    
            background-color: #FFFFFF !important;
            border-width: 3px !important;
            border-style: solid !important; 
            border-color: black !important;
            padding-top: 10px !important;
            padding-left: 10px !important;
            width: 79% !important;
            height: 80% !important;
            overflow:scroll;
        }

        #btnClose{
        position: fixed;
        top: 7%;
        right: 9.5%;
        margin-right: 10px;
        margin-top: 10px;
        width:50px;
        height:50px;
        }

    </style>

</head>
<body>
  <!-- container section start -->
      
        <section id="container" class="">
            <form runat="server" id="mainForm">   
      
            <header class="header dark-bg">
                <div class="toggle-nav">
                    <div class="icon-reorder tooltips" data-original-title="Toggle Navigation" data-placement="bottom"><i class="icon_menu"></i></div>
                </div>

                <!--logo start-->
                <a href="AdminPortal.aspx" class="logo"><span class="lite">Homestay</span></a>
                <!--logo end-->


                <div class="top-nav notification-row">                
                    <!-- notificatoin dropdown start-->
                    <ul class="nav pull-right top-menu">        
                        <!-- alert notification start-->
                        <li id="alert_notificatoin_bar" class="dropdown">
                            <a data-toggle="dropdown" class="dropdown-toggle" href="#">

                                <i class="icon-bell-l"></i>
                                <span class="badge bg-important">2!</span>
                            </a>
                            <ul class="dropdown-menu extended notification">
                                <div class="notify-arrow notify-arrow-blue"></div>
                                <li>
                                    <p class="blue">You have 4 new notifications</p>
                                </li>                      
                                <li>
                                    <a href="#">
                                        <span class="label label-danger"><i class="icon_book_alt"></i></span> 
                                        3 new arrivals this week... 
                                        <span class="small italic pull-right"> Sunday</span>
                                    </a>
                                </li>
                                <li>
                                    <a href="#">
                                        <span class="label label-success"><i class="icon_like"></i></span> 
                                        8 new Applicant form sub...
                                        <span class="small italic pull-right"> Today</span>
                                    </a>
                                </li>                            
                            </ul>
                        </li>
                        <!-- alert notification end-->
                        <!-- user login dropdown start-->
                        <li class="dropdown">
                            <a data-toggle="dropdown" class="dropdown-toggle" href="#">
                                <span class="profile-ava">
                                    <img alt="" src="WebAssets/nice-assets/img/avatar1_small.jpg">
                                </span>
                                <span class="username">Welcome Admin!</span>
                                <b class="caret"></b>
                            </a>
                            <ul class="dropdown-menu extended logout">
                                <div class="log-arrow-up"></div>
                                <li class="eborder-top">
                                    <a href="#"><i class="icon_profile"></i>Settings</a>
                                </li>                     
                                <li>
                                    <a href="AdminLogin.aspx"><i class="icon_key_alt"></i>Log Out</a>
                                </li>
                               
                            </ul>
                        </li>
                        <!-- user login dropdown end -->
                    </ul>
                    <!-- notificatoin dropdown end-->
                </div>
            </header>      
            <!--header end-->
            
          

            <!--sidebar start-->
            <aside>
                <div id="sidebar"  class="nav-collapse ">
                    <!-- sidebar menu start-->
                    <ul class="sidebar-menu">                
                        <li class="active">
                            <asp:LinkButton class="" runat="server" ID="dashboardBtn" OnClick="dashboardBtn_Click"  CausesValidation="false">
                                <i class="icon_house_alt"></i>
                                <span>Dashboard</span>
                            </asp:LinkButton>
                        </li>
                        
                        <li>
                           <asp:LinkButton runat="server" class="" OnClick="Click_SearchBtn"  CausesValidation="false">                       
                                <i class="icon_genius"></i>
                                <span>Search</span>                      
                            </asp:LinkButton>
                        </li>   
                        <li class="sub-menu">
                            <a href="javascript:;" class="">
                                <i class="icon_folder"></i>
                                <span>Manage</span>
                                <span class="menu-arrow arrow_carrot-right"></span>
                            </a>
                            <ul class="sub">
                                 <li><asp:LinkButton class="" runat="server" ID="applicantManagementBtn" OnClick="applicantManagementBtn_Click"  CausesValidation="false">Manage Applicants</asp:LinkButton></li>          
                                 <li><asp:LinkButton class="" runat="server" ID="hostManagementBtn" OnClick="hostManagementBtn__Click"  CausesValidation="false">Manage Hosts</asp:LinkButton></li> 
                            </ul>
                        </li>    

				        <li class="sub-menu">
                            <a href="javascript:;" class="">
                                <i class="icon_document_alt"></i>
                                <span>Forms</span>
                                <span class="menu-arrow arrow_carrot-right"></span>
                            </a>
                            <ul class="sub">
                                <li><asp:LinkButton runat="server" class="" id="studentFormBtn" OnClick="studentFormBtn_Click"  CausesValidation="false">Applicant Form</asp:LinkButton></li>                          
                                <li><asp:LinkButton runat="server" class="" id="familyFormBtn" OnClick="familyFormBtn_Click"  CausesValidation="false">Host Form</asp:LinkButton></li>
                            </ul>
                        </li>       
                        <li class="sub-menu">
                            <a href="javascript:;" class="">
                                <i class="icon_desktop"></i>
                                <span>Quick Search</span>
                                <span class="menu-arrow arrow_carrot-right"></span>
                            </a>
                            <ul class="sub">
                                <li><asp:LinkButton runat="server" id="allApplicants" OnClick="allApplicants_Click" class=""  CausesValidation="false">All Applicants</asp:LinkButton></li>                               
                                <li><asp:LinkButton runat="server" id="allActiveApplicants" OnClick="allActiveApplicants_Click" class=""  CausesValidation="false">All Active Applicants</asp:LinkButton></li>                                
                                <li><asp:LinkButton runat="server" id="lookingApplicants" OnClick="lookingApplicants_Click" class=""  CausesValidation="false">All Looking Applicants</asp:LinkButton></li>
                                <li><asp:LinkButton runat="server" id="allHosts" OnClick="allHosts_Click" class=""  CausesValidation="false">All Hosts</asp:LinkButton></li>
                                <li><asp:LinkButton runat="server" id="allActiveHosts" OnClick="allActiveHosts_Click" class=""  CausesValidation="false">All Active Hosts</asp:LinkButton></li>
                                <li><asp:LinkButton runat="server" id="lookingHosts" OnClick="lookingHosts_Click" class=""  CausesValidation="false">All Looking Hosts</asp:LinkButton></li>
                            </ul>
                        </li>
                                    
                    </ul>
                    <!-- sidebar menu end-->
                </div>
            </aside>
            <!--sidebar end-->
            
            
          
      
            <!--main content start-->
            
            <section id="main-content">                            
                <section class="wrapper"> 
                
                <asp:Panel runat="server" ID="exampleDashboard" Visible="false">
                                
                      
                   <div class="row">
				    <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12">
					    <div class="info-box blue-bg">
						    <i class="fa fa-cloud-download"></i>
						    <div class="count">12</div>
						    <div class="title">Active Students</div>						
					    </div><!--/.info-box-->			
				    </div><!--/.col-->
				
				    <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12">
					    <div class="info-box brown-bg">
						    <i class="fa fa-shopping-cart"></i>
						    <div class="count">14</div>
						    <div class="title">Families Looking</div>						
					    </div><!--/.info-box-->			
				    </div><!--/.col-->	
				
				    <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12">
					    <div class="info-box dark-bg">
						    <i class="fa fa-thumbs-o-up"></i>
						    <div class="count">9</div>
						    <div class="title">Pending Payment</div>						
					    </div><!--/.info-box-->			
				    </div><!--/.col-->
				
				    <div class="col-lg-3 col-md-3 col-sm-12 col-xs-12">
					    <div class="info-box green-bg">
						    <i class="fa fa-cubes"></i>
						    <div class="count">5</div>
						    <div class="title">New form Submissions</div>						
					    </div><!--/.info-box-->			
				    </div><!--/.col-->

                    <!--START TABLE OF EVENTS-->
                        <table class="table table-striped table-advance table-hover">
                               <tbody>
                                  <tr>
                                    <th><i class="icon_calendar"></i> Date</th>
                                     <th><i class="icon_profile"></i> Event Type</th>
                                     <th><i class="icon_mail_alt"></i> Description</th>   
                                     <th><i class="icon_cogs"></i> Action</th>
                                  </tr>
                                  <tr>
                                     <td>2004-07-06</td>
                                     <td>New Host Form</td>
                                     <td>A new family "Jansen" has applied for Homestay</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                                <tr>
                                     <td>2004-07-06</td>
                                     <td>New Student Form</td>
                                     <td>A new student "Jim" has applied for Homestay</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>                                 
                                  <tr>
                                     <td>2004-07-06</td>
                                     <td>Arrival</td>
                                     <td>"John" will be arriving by plane today at 3:15 PM</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                               </tbody>
                            </table>
				
			</div>
                        
                    </asp:Panel>

                   <%--TABLE--%>
                    <asp:Panel runat="server" id="exampleTable" Visible="false">
                        <p style="text-align:center">Example Table</p>
                        <br />

                        <!-- project team & activity end -->
                    </asp:Panel>    


                    <asp:Panel runat="server" id="exampleUpdateStudents" Visible="false">
                       <!-- CKEditor -->
                          <div class="col-lg-12">
                              <section class="panel">
                                  <header class="panel-heading">
                                      Update Applicant Info Page                    
                                  </header>
                                  <div class="panel-body">
                                      <div class="form">
                                          
                                              <div class="form-group">
                                                  <label class="control-label col-sm-2">Update Applicant Info Page </label>
                                                   <asp:Button runat="server" ID="saveFormApplicant" OnClick="saveFormApplicant_Click" Text="SAVE"></asp:Button>
                                                  <asp:Button runat="server" ID="rollBackFormApplicant" OnClick="rollBackFormApplicant_Click" Text="Rollback"></asp:Button>
                                                  <div class="col-sm-10">
                                                      <br />
                                                   <%--  <textarea class="form-control ckeditor" name="editor1" rows="6"></textarea>--%>
                                                      <asp:TextBox id="applicantEditor" TextMode="multiline" Columns="50" Rows="6" CssClass="form-control ckeditor" runat="server" />
                                                 </div>
                                              </div>
                                          
                                      </div>
                                  </div>
                              </section>
                          </div>
                       

                    </asp:Panel>

                    <asp:Panel runat="server" id="exampleUpdateFamily" Visible="false">
                         <!-- CKEditor -->
                          <div class="col-lg-12">
                              <section class="panel">
                                  <header class="panel-heading">
                                      Update Host Info Page
                                  </header>
                                  <div class="panel-body">
                                      <div class="form">
                                         
                                              <div class="form-group">
                                                  <label class="control-label col-sm-2">Update Host Info Page</label>
                                                  <asp:Button runat="server" ID="saveFormHost" OnClick="saveFormHost_Click" Text="SAVE"></asp:Button>
                                                  <asp:Button runat="server" ID="rollbackFormHost" OnClick="rollbackFormHost_Click" Text="Rollback"></asp:Button>
                                                  <div class="col-sm-10">
                                                      <br />
                                                      <asp:TextBox id="hostEditor" TextMode="multiline" Columns="50" Rows="6" CssClass="form-control ckeditor" runat="server" />
                                                  </div>
                                              </div>
                                         
                                      </div>
                                  </div>
                              </section>
                          </div>

                    </asp:Panel>

                    <asp:Panel runat="server" ID="exampleSearch" Visible="false">
                 
                        <section class="panel">
                            <header class="panel-heading">
                                Filters
                            </header>
                            <div class="panel-body">                                   
                                <div class="checkboxes">
                                    <label class="label_check c_on" for="checkbox-01"><input name="sample-checkbox-01" id="checkbox-01" value="1" type="checkbox" checked="" /> Search Applicants</label>
                                    <label class="label_check c_off" for="checkbox-02"><input name="sample-checkbox-02" id="checkbox-02" value="1" type="checkbox" /> Search Families </label>
                                    <label class="label_check c_off" for="checkbox-03"><input name="sample-checkbox-02" id="checkbox-03" value="1" type="checkbox" /> Search Schools</label>
                                </div>
                            </div>

                            <div class="panel-body">                        
                                <asp:Label runat="server">Item to Search:</asp:Label>
                                <asp:TextBox runat="server" ID="searchTextBox"></asp:TextBox>

                                <br />
                                <br />

                                <asp:Button ID="customSearchBtn" runat="server" Text="Search"></asp:Button>
                            </div>

                        </section>
                    </asp:Panel>

                    <asp:Panel runat="server" ID="applicantManagement" Visible="false">

                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                         <%--   <asp:Button ID="btnShow" runat="server" Text="Edit" CausesValidation="False" />--%>


                            <asp:GridView runat="server" ID="applicantGrid" DataKeyNames="A_id" AutoGenerateColumns="false" ViewStateMode="Enabled" OnRowCommand="applicantGrid_RowCommand" Visible="false">
	                            <Columns>

                                <%--Visible Columns--%>
                                <asp:BoundField DataField="A_Id"/>
	                            <asp:BoundField DataField="A_FirstName" HeaderText="First Name" />
	                            <asp:BoundField DataField="A_LastName" HeaderText="Last Name" />
                                <asp:BoundField DataField="A_D.O.B" HeaderText="Date of Birth" />
                                <asp:BoundField DataField="A_Country" HeaderText="Country" />
                                <asp:BoundField DataField="A_Language" HeaderText="Language"/>
	                            <asp:BoundField DataField="A_Gender" HeaderText="Gender" />
                                <asp:BoundField DataField="A_Status" HeaderText="Martial Status" />
                                <asp:BoundField DataField="A_Street" HeaderText="Address" />

                             <%--   Hidden Columns--%>
	                            <asp:BoundField DataField="A_Nationality" HeaderText="Nationality" />
	                            <asp:BoundField DataField="A_Dog" HeaderText="Dogs" />
	                            <asp:BoundField DataField="A_Cat" HeaderText="Cats" />
	                            <asp:BoundField DataField="A_Street" HeaderText="Address" />
	                            <asp:BoundField DataField="A_PrimePh_no" HeaderText="Primary Phone" />
	                            <asp:BoundField DataField="A_SecPh_no" HeaderText="Secondary Phone" />
                                <asp:BoundField DataField="A_HealthIssues" HeaderText="Health Issues" />
	                            <asp:BoundField DataField="A_Hobbies" HeaderText="Hobbies" />
                                <asp:BoundField DataField="A_About" HeaderText="About" />
	                            <asp:BoundField DataField="OtherUniversity" HeaderText="Other Sponsor" />
                                <asp:BoundField DataField="A_Email" HeaderText="Email" />
	                            <asp:BoundField DataField="A_EmergencyContact" HeaderText="Emergency Contact" />
	                            <asp:TemplateField>
                                 <ItemTemplate>
                                 <asp:Button ID="applicantRowEdit" runat="server" 
                                  CommandName="EditRow" 
                                  CommandArgument="<%# ((GridViewRow) Container).RowIndex %>"
                                  Text="Edit"
                                  CausesValidation="false"
                                   />
                                </ItemTemplate> 
                                </asp:TemplateField>
	                            </Columns>
                            </asp:GridView>
 
                            <asp:Button ID="modelPopup" runat="server" style="display:none"  CausesValidation="false" />
                            <cc1:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panel1" TargetControlID="modelPopup"
                                CancelControlID="btnClose" BackgroundCssClass="modalBackground">
                            </cc1:ModalPopupExtender>


                            <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="left">
                                <h1><u>Edit Applicant</u></h1>
                                <asp:ValidationSummary runat="server" headertext="Please correct the following errors before continuing:" ForeColor="#ff3300" DisplayMode="List"/>
                                <table style="width:100%; border-collapse:separate; border-spacing:3em;">

                                <tr>
                                <td>
                                <h3><u>Personal Information</u></h3>
                              
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
                                <asp:TextBox runat="server" id="dateOfBirth"></asp:TextBox>

                                <br />
                                <br />

                                <asp:Label AssociatedControlID="Country" Text="Nationality: " runat="server"></asp:Label>
                                <br />
                                <asp:DropDownList id="Country" runat="server">
                                </asp:DropDownList>

                                <br />
                                <br />
                           
                                    
                                <asp:Label AssociatedControlID="firstLanguage" Text="First Language: " runat="server"></asp:Label>
                                <br />
                                <asp:TextBox runat="server" id="firstLanguage"></asp:TextBox>

                                <br />
                                <br />

                               
                                <asp:Label AssociatedControlID="gender" Text="Gender: " runat="server"></asp:Label>
                                <asp:RadioButtonList id="gender"   CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="Male" Value="0" Selected="true"/>
                                <asp:ListItem Text="Female" Value="1" />
                                </asp:RadioButtonList>

                                <br />
                   

                                <asp:Label AssociatedControlID="martialstatus" Text="Martial Status: " runat="server"></asp:Label>
                                <asp:RadioButtonList id="martialstatus"  CssClass="rdoBtnItemSpacing" runat="server">
                                <asp:ListItem Text="Married" Value="0" Selected="true"/>
                                <asp:ListItem Text="Unmarried" Value="1" />
                                </asp:RadioButtonList>

                                <h3><u>Conditions and Preferences</u></h3>
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

                                </td>


                                <td>
                                </td>
                                <td>

                                <h3><u>Sponsor Information</u></h3>
                                <asp:Label runat="server" Text="Sponsor Institution (name of school, company or organization): " AssociatedControlID="university"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="university"></asp:TextBox>
                                    <br />
                                    <br />
                                     
                                    <asp:Label runat="server" Text="Sponsor Institution Address: " AssociatedControlID="universityAddress"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="universityAddress"></asp:TextBox>
                                    <br />
                                    <br />
                                    <asp:Label runat="server" Text="Program Start Date: "></asp:Label>
                                    <br />
                                    <br />
                                    <br />
                       
                                    <asp:Label runat="server" Text="Major (Subject of Study) if applicable: " AssociatedControlID="major"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="major"></asp:TextBox>
                                    <br />
                                    <br />
                                      
                                    <asp:Label runat="server" Text="Sponsor Contact Information (Name / Phone Number): " AssociatedControlID="universityContactInfo"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="universityContactInfo"></asp:TextBox>
                                    <br />
                                    <br />
                                        
                                    <asp:Label runat="server" Text="Requested Length of Homestay: " AssociatedControlID="homestayDuration"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="homestayDuration"></asp:TextBox>

                                    <br />
                                     <br />
                                     <br />


                                    
                                    <h3><u>Contact Information</u></h3>
                                    <asp:Label runat="server" Text="Address: " AssociatedControlID="address"></asp:Label>
                                    <br />
                                    <asp:TextBox runat="server" id="address" Enabled="True" Width="50%"></asp:TextBox>

                                    <br />
                                    <br />

                    
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
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                                    <br />
                               
                              
                              
                                    <div style="text-align:center">
                                    <asp:Button ID="modalSave" class="btn btn-default btn-lg" Text="Save Applicant" runat="server"></asp:Button>
                                    </div>
                               
                       
                           
                                </td>
                                <td>

                                </td>


                                </tr>

                             

                                </table>
                                <br />
                                <br />
                                  <asp:ImageButton ID="btnClose" runat="server" align="right" ImageUrl="WebAssets/nice-assets/img/close-button-3.png" CausesValidation="False"  />
                            </asp:Panel>

                            
                        <section class="panel">

                        </section>
                    </asp:Panel>

                          <asp:Panel runat="server" ID="hostManagement" Visible="false">
                 
                        <section class="panel">

                        </section>
                    </asp:Panel>

                </section>
                
                <div class="text-right">
                <div class="credits">      
                    
                    <div style="text-align:center" hidden="hidden"> 
                        <p>We can do 10 rows per page or something to keep it looking clean</p>
                        <br />                       
                        <ul class="pagination pagination-lg">
                            <li><a href="#">«</a></li>
                            <li><a href="#">1</a></li>
                            <li><a href="#">2</a></li>
                            <li><a href="#">3</a></li>
                            <li><a href="#">4</a></li>
                            <li><a href="#">5</a></li>
                            <li><a href="#">»</a></li>
                        </ul>
                    </div>     
                    
                </div>
            </div>
            </section>

            
            <!--main content end-->
            </form>
        </section>
    
        <!-- container section start -->

        <!-- javascripts -->
        <script src="WebAssets/nice-assets/js/jquery.js"></script>
	    <script src="WebAssets/nice-assets/js/jquery-ui-1.10.4.min.js"></script>
        <script src="WebAssets/nice-assets/js/jquery-1.8.3.min.js"></script>
        <script type="text/javascript" src="WebAssets/nice-assets/js/jquery-ui-1.9.2.custom.min.js"></script>
        <!-- bootstrap -->
        <script src="WebAssets/nice-assets/js/bootstrap.min.js"></script>
        <!-- nice scroll -->
        <script src="WebAssets/nice-assets/js/jquery.scrollTo.min.js"></script>
        <script src="WebAssets/nice-assets/js/jquery.nicescroll.js" type="text/javascript"></script>
        <!-- charts scripts -->
        <script src="WebAssets/nice-assets/assets/jquery-knob/js/jquery.knob.js"></script>
        <script src="WebAssets/nice-assets/js/jquery.sparkline.js" type="text/javascript"></script>
        <script src="WebAssets/nice-assets/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.js"></script>
        <script src="WebAssets/nice-assets/js/owl.carousel.js" ></script>
        <!-- jQuery full calendar -->
        <<script src="WebAssets/nice-assets/js/fullcalendar.min.js"></script> <!-- Full Google Calendar - Calendar -->
	    <script src="WebAssets/nice-assets/assets/fullcalendar/fullcalendar/fullcalendar.js"></script>
        <!--script for this page only-->
        <script src="WebAssets/nice-assets/js/calendar-custom.js"></script>
	    <script src="WebAssets/nice-assets/js/jquery.rateit.min.js"></script>
        <!-- custom select -->
        <script src="WebAssets/nice-assets/js/jquery.customSelect.min.js" ></script>
	    <script src="WebAssets/nice-assets/assets/chart-master/Chart.js"></script>
   
        <!--custome script for all page-->
        <script src="WebAssets/nice-assets/js/scripts.js"></script>
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



        
       <script>
           //knob
           $(function () {
               $(".knob").knob({
                   'draw': function () {
                       $(this.i).val(this.cv + '%')
                   }
               })
           });
           //carousel
           $(document).ready(function () {
               $("#owl-slider").owlCarousel({
                   navigation: true,
                   slideSpeed: 300,
                   paginationSpeed: 400,
                   singleItem: true
               });
           });
           //custom select box
           $(function () {
               $('select.styled').customSelect();
           });

           /* ---------- Map ---------- */
           $(function () {
               $('#map').vectorMap({
                   map: 'world_mill_en',
                   series: {
                       regions: [{
                           values: gdpData,
                           scale: ['#000', '#000'],
                           normalizeFunction: 'polynomial'
                       }]
                   },
                   backgroundColor: '#eef3f7',
                   onLabelShow: function (e, el, code) {
                       el.html(el.html() + ' (GDP - ' + gdpData[code] + ')');
                   }
               });
           });
  </script>

    </body>
    
</html>