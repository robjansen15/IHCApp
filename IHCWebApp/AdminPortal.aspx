<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPortal.aspx.cs" Inherits="UserWebApp.AdminPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Portal</title>
    
        <!-- Bootstrap CSS -->    
    <link href="/nice-assets/css/bootstrap.min.css" rel="stylesheet" />
    <!-- bootstrap theme -->
    <link href="/nice-assets/css/bootstrap-theme.css" rel="stylesheet" />
    <!--external css-->
    <!-- font icon -->
    <link href="/nice-assets/css/elegant-icons-style.css" rel="stylesheet" />
    <link href="/nice-assets/css/font-awesome.min.css" rel="stylesheet" />    
    <!-- full calendar css-->
    <link href="/nice-assets/assets/fullcalendar/fullcalendar/bootstrap-fullcalendar.css" rel="stylesheet" />
	<link href="/nice-assets/assets/fullcalendar/fullcalendar/fullcalendar.css" rel="stylesheet" />
    <!-- easy pie chart-->
    <link href="/nice-assets/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.css" rel="stylesheet" type="text/css" media="screen"/>
    <!-- owl carousel -->
    <link rel="stylesheet" href="/nice-assets/css/owl.carousel.css" type="text/css" />
    <link href="/nice-assets/css/jquery-jvectormap-1.2.2.css" rel="stylesheet" />
    <!-- Custom styles -->
    <link rel="stylesheet" href="/nice-assets/css/fullcalendar.css" />
    <link href="/nice-assets/css/widgets.css" rel="stylesheet" />
    <link href="/nice-assets/css/style.css" rel="stylesheet" />
    <link href="/nice-assets/css/style-responsive.css" rel="stylesheet" />
    <link href="/nice-assets/css/xcharts.min.css" rel=" stylesheet" />	
    <link href="/nice-assets/css/jquery-ui-1.10.4.min.css" rel="stylesheet" />
</head>
<body>
  <!-- container section start -->
     <form runat="server" id="mainForm">    
        <section id="container" class="">
     
        

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
                                        8 new student form sub...
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
                                    <img alt="" src="/nice-assets/img/avatar1_small.jpg">
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
                            <a class="" href="index.html">
                                <i class="icon_house_alt"></i>
                                <span>Dashboard</span>
                            </a>
                        </li>
                        
                        <li>
                            <asp:LinkButton runat="server" class="" OnClick="Click_SearchBtn">                              
                                <i class="icon_genius"></i>
                                <span>Search</span>                      
                            </asp:LinkButton>
                        <%--    <a class="">                              
                                <i class="icon_genius"></i>
                                <span>Search</span>                      
                            </a>--%>
                        </li>

				        <li class="sub-menu">
                            <a href="javascript:;" class="">
                                <i class="icon_document_alt"></i>
                                <span>Forms</span>
                                <span class="menu-arrow arrow_carrot-right"></span>
                            </a>
                            <ul class="sub">
                                <li><a class="" href="StudentForm.aspx">Student Form</a></li>                          
                                <li><a class="" href="FamilyForm.aspx">Family Form</a></li>
                            </ul>
                        </li>       
                        <li class="sub-menu">
                            <a href="javascript:;" class="">
                                <i class="icon_desktop"></i>
                                <span>Quick Search</span>
                                <span class="menu-arrow arrow_carrot-right"></span>
                            </a>
                            <ul class="sub">
                                <li><a class="" href="general.html">All Students</a></li>
                                <li><a class="" href="buttons.html">All Hosts</a></li>
                                <li><a class="" href="grids.html">All Students by School</a></li>
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
                           
 
                        <p style="text-align:center">Example Table</p>
                        <br />

                        <table class="table table-striped table-advance table-hover">
                               <tbody>
                                  <tr>
                                     <th><i class="icon_profile"></i> Full Name</th>
                                     <th><i class="icon_calendar"></i> Date</th>
                                     <th><i class="icon_mail_alt"></i> Email</th>
                                     <th><i class="icon_pin_alt"></i> City</th>
                                     <th><i class="icon_mobile"></i> Mobile</th>
                                     <th><i class="icon_cogs"></i> Action</th>
                                  </tr>
                                  <tr>
                                     <td>Angeline Mcclain</td>
                                     <td>2004-07-06</td>
                                     <td>dale@chief.info</td>
                                     <td>Rosser</td>
                                     <td>176-026-5992</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                                  <tr>
                                     <td>Sung Carlson</td>
                                     <td>2011-01-10</td>
                                     <td>ione.gisela@high.org</td>
                                     <td>Robert Lee</td>
                                     <td>724-639-4784</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                                  <tr>
                                     <td>Bryon Osborne</td>
                                     <td>2006-10-29</td>
                                     <td>sol.raleigh@language.edu</td>
                                     <td>York</td>
                                     <td>180-456-0056</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                                  <tr>
                                     <td>Dalia Marquez</td>
                                     <td>2011-12-15</td>
                                     <td>angeline.frieda@thick.com</td>
                                     <td>Alton</td>
                                     <td>690-601-1922</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                                  <tr>
                                     <td>Selina Fitzgerald</td>
                                     <td>2003-01-06</td>
                                     <td>moshe.mikel@parcelpart.info</td>
                                     <td>Waelder</td>
                                     <td>922-810-0915</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                                  <tr>
                                     <td>Abraham Avery</td>
                                     <td>2006-07-14</td>
                                     <td>harvey.jared@pullpump.org</td>
                                     <td>Harker Heights</td>
                                     <td>511-175-7115</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                                  <tr>
                                     <td>Caren Mcdowell</td>
                                     <td>2002-03-29</td>
                                     <td>valeria@hookhope.org</td>
                                     <td>Blackwell</td>
                                     <td>970-147-5550</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                                  <tr>
                                     <td>Owen Bingham</td>
                                     <td>2013-04-06</td>
                                     <td>thomas.christopher@firstfish.info</td>
                                     <td>Rule</td>
                                     <td>934-118-6046</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                                  <tr>
                                     <td>Ahmed Dean</td>
                                     <td>2008-03-19</td>
                                     <td>lakesha.geri.allene@recordred.com</td>
                                     <td>Darrouzett</td>
                                     <td>338-081-8817</td>
                                     <td>
                                      <div class="btn-group">
                                          <a class="btn btn-primary" href="#"><i class="icon_plus_alt2"></i></a>
                                          <a class="btn btn-success" href="#"><i class="icon_check_alt2"></i></a>
                                          <a class="btn btn-danger" href="#"><i class="icon_close_alt2"></i></a>
                                      </div>
                                      </td>
                                  </tr>
                                  <tr>
                                     <td>Mario Norris</td>
                                     <td>2010-02-08</td>
                                     <td>mildred@hour.info</td>
                                     <td>Amarillo</td>
                                     <td>945-547-5302</td>
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
   
                        <!-- project team & activity end -->
                    
                </section>
                

                <div class="text-right">
                <div class="credits">             
                    <div style="text-align:center"> 
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
        </section>

         </form>
        <!-- container section start -->

        <!-- javascripts -->
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
	    <script src="/nice-assets/js/jquery.autosize.min.js"></script>
	    <script src="/nice-assets/js/jquery.placeholder.min.js"></script>
	    <script src="/nice-assets/js/jquery.slimscroll.min.js"></script>
        
       <script>

          //knob
          $(function() {
              $(".knob").knob({
                  'draw': function() {
                      $(this.i).val(this.cv + '%');
                  }
              });
          });

          //carousel
          $(document).ready(function() {
              $("#owl-slider").owlCarousel({
                  navigation : true,
                  slideSpeed : 300,
                  paginationSpeed : 400,
                  singleItem : true

              });
          });

          //custom select box

          $(function(){
              $('select.styled').customSelect();
          });
	  
	      /* ---------- Map ---------- */
	    $(function(){
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
	        onLabelShow: function(e, el, code){
	          el.html(el.html()+' (GDP - '+gdpData[code]+')');
	        }
	      });
	    });

  </script>

    </body>
    
</html>
