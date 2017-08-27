<!DOCTYPE html>
<html lang="en">
    <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <meta name="keyword" content="">
    <title>User | Topupnp</title>
    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/bootstrap-reset.css" rel="stylesheet">
    <!--external css-->
    <link href="css/font-awesome.min.css" rel="stylesheet" />
    <!--right slidebar-->
    <link href="css/slidebars.css" rel="stylesheet">
    <!-- css for jquery ui -->
    <link href="http://code.jquery.com/ui/1.10.4/themes/ui-lightness/jquery-ui.css" rel="stylesheet">
        <!-- css for DATATABLES -->
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.12/css/jquery.dataTables.min.css">
        <!-- Custom styles for this template -->
    <link href="css/style.css" rel="stylesheet">
    <link href="css/style-responsive.css" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="css/mixins.css">
    <link rel="stylesheet" type="text/css" href="css/global.css">
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 tooltipss and media queries -->
    <!--[if lt IE 9]>
    <script src="js/html5shiv.js"></script>
    <script src="js/respond.min.js"></script>
    <![endif]-->
    <style type="text/css">
      .small-image {
        height: 22px;
    margin-right: 5px;
      }
  

    </style>
  </head>
  <body class="boxed-page">
    <div class="container">
    <section id="container" class="">
     <!--header start-->
          <header class="header white-bg">
              <div class="container">
                  <div class="sidebar-toggle-box">
                      <i class="fa fa-bars"></i>
                  </div>
                  <!--logo start-->
        <a href="index.php" class="logo"><img src="./img/logo.png"></a>
                  <!--logo end-->
                  <div class="top-nav ">
                            <span class="label label-success custom_label_of_header" style="position: relative;
    top: 14px;
    left: 30px;
    font-size: 14px;">Reseller</span>
                      <ul class="nav pull-right top-menu">
            <li>
              <input type="text" class="form-control search" placeholder="Search">
            </li>
            <!-- user login dropdown start-->
            <li class="dropdown">
              <a data-toggle="dropdown" class="dropdown-toggle" href="#">
                <img alt="" src="./img/admin.png">
                <span class="username">Bishal Rana</span>
                <b class="caret"></b>
              </a>
              <ul class="dropdown-menu extended logout">
                <div class="log-arrow-up"></div>
                <li><a href="#"><i class=" fa fa-suitcase"></i>Profile</a></li>
                <li><a href="#"><i class="fa fa-cog"></i> Settings</a></li>
                <li><a href="#"><i class="fa fa-bell-o"></i> Notification</a></li>
                <li><a href="login.html"><i class="fa fa-key"></i> Log Out</a></li>
              </ul>
            </li>
            <!-- user login dropdown end -->
          </ul>
                  </div> <!-- // top - nav -->
              </div> <!-- //container -->
          </header>
          <!--header end-->
      <!--sidebar start-->
      <aside>
        <div id="sidebar"  class="nav-collapse ">
          <!-- sidebar menu start-->
          <ul class="sidebar-menu" id="nav-accordion">
            <li>
              <a href="index.php" class="active">
<img src="./img/ntc.jpg" class="small-image">
                              <span>Dashboard</span>
              </a>
            </li>
            <li>
              <a href="my_users.php">
<img src="./img/sim.jpg" class="small-image">
                <span>My Users</span>
              </a>
            </li>
            <li class="sub-menu">
              <a href="#">
                          <img src="./img/ncell.jpg" class="small-image">
                <span>TopUp</span>
              </a>
              <ul class="sub">
              <li><a href="topup_neptalk.php">Neptalk</a></li>
              <li><a href="#"> NTC Prepaid</a></li>
              <li><a href="#"> NTC Postpaid</a></li>
              <li><a href="#"> Dish Home</a></li>
              </ul>
            </li>
            <li class="sub-menu">
              <a href="#">
<img src="./img/utl.jpg" class="small-image">
                <span>Recharge Cards</span>
              </a>
              <ul class="sub">
              <li><a href="#"> Neptalk Account</a></li>
              <li><a href="#"> Neptalk Voucher</a></li>
              <li><a href="#"> Palsvoice Account</a></li>
              <li><a href="#"> Palsvoice Voucher</a></li>
              <li><a href="#"> NT Recharge</a></li>
              <li><a href="#"> Dish Home</a></li>
              <li><a href="#"> Broadlink</a></li>
              <li><a href="#"> Smartcell</a></li>
              </ul>
            </li>
             <li>
              <a href="fund_transfer.php">
                <i class="fa fa-money"></i>
                <span>Fund Transfer</span>
              </a>
            </li>
            <li class="sub-menu">
              <a href="#">
                <i class="fa fa-envelope"></i>
                <span>Statement</span>
              </a>
              <ul class="sub">
                <li><a href="transactions.php">Transaction Statement</a></li>
                <li><a href="transactions.php">Commission Statement</a></li>
              </ul>
            </li>
           
          </ul>
          <!-- sidebar menu end-->
        </div>
      </aside>
      <!--sidebar end-->