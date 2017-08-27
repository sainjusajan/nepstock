<?php include ('header.php') ?>
<!--main content start-->
<section id="main-content">
  <section class="wrapper site-min-height">
    <!-- page start-->
    <section class="bread_crumb">
      <div class="row">
        <div class="col-md-6 col-sm-6">
          <h3>My Users
          </h3>
          </div> <!-- // col -->
          <div class="col-md-6 col-sm-6">
            <ul class="crumbs">
              <li><a href="index.php">Home</a></li>
              <li> > </li>
              <li>My Users</li>
            </ul>
            </div> <!-- // col -->
            </div> <!-- // row -->
            </section> <!-- // bread_crumb -->
            <div class="panel">
              <div class="panel-body">
                <a class="btn btn-primary" href="add_new_user.php"><i class="fa fa-plus m-r-5"></i>Add New User</a>
                <div class="row">
                  <div class="col-md-12 col-sm-12">
                   
                    <div class="table-responsive data_tableau">
                      <table id="example" class="display table-bordered">
                        <thead>
                          <tr>                           
<th>First Name  </th>
<th>Last Name </th>
<th>Email</th>
<th>Mobile</th>
<th>Added Date</th>
                          </tr>
                        </thead>
                        <tfoot>
                        <tr>
<th>First Name  </th>
<th>Last Name </th>
<th>Email</th>
<th>Mobile</th>
<th>Added Date</th>
                        </tr>
                        </tfoot>
                        <tbody>
                          <tr>
                          <td> Bishal</td>
                          <td> Rana</td>
                          <td> Rbishal50@gmail.com</td>
                          <td> +977-98XXXXXXXX</td>
                          <td> 2016/08/22</td>
                          </tr>
                          
                        </tbody>
                      </table>
                      </div> <!-- // table-responsive -->
                      </div> <!-- // col -->
                     
                        </div> <!-- // row -->
                        </div> <!-- //panel-body -->
                        </div> <!-- // panel -->
                        <!-- page end-->
                      </section>
                      <!-- //wrapper -->
                    </section>
                    <!--main content end-->
                    <?php include ('footer.php') ?>