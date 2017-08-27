<?php include ('header.php') ?>
<!--main content start-->
<section id="main-content">
  <section class="wrapper site-min-height">
    <!-- page start-->
    <section class="bread_crumb">
      <div class="row">
        <div class="col-md-6 col-sm-6">
          <h3>NCell Prepaid TopUp
          </h3>
          </div> <!-- // col -->
          <div class="col-md-6 col-sm-6">
            <ul class="crumbs">
              <li><a href="index.php">Home</a></li>
              <li> > </li>
              <li>TopUp</li>
              <li> > </li>
              <li>Neptalk</li>
            </ul>
            </div> <!-- // col -->
            </div> <!-- // row -->
            </section> <!-- // bread_crumb -->
            <div class="panel">
              <div class="panel-body">
                <div class="row">
                  <div class="col-md-12 col-sm-12">
                    <form class="form-inline">
                      <div class="form-group">
                        <label for="exampleInputName2">From</label>
                        <input type="text" id="datepicker-1" class="form-control">
                      </div>
                      <div class="form-group">
                        <label for="exampleInputEmail2">To</label>
                        <input type="text" id="datepicker-2" class="form-control">
                      </div>
                      <button type="submit" class="btn btn-primary">Search</button>
                    </form>
                    <div class="table-responsive data_tableau">
                      <table id="example" class="display table-bordered">
                        <thead>
                          <tr>
                            <th>Transaction Date</th>
                            <th>Type</th>
                            <th>Details</th>
                            <th>Credit Amount</th>
                            <th>Balance</th>
                            <th>Status</th>
                          </tr>
                        </thead>
                        <tfoot>
                        <tr>
                          <th>Transaction Date</th>
                          <th>Type</th>
                          <th>Details</th>
                          <th>Credit Amount</th>
                          <th>Balance</th>
                          <th>Status</th>
                        </tr>
                        </tfoot>
                        <tbody>
                          <tr>
                            <td>2016/8/22</td>
                            <td>Ncell Prepaid</td>
                            <td></td>
                            <td>NPR 10</td>
                            <td>NPR 50000</td>
                            <td><a href="#" class="btn btn-success btn-xs">Success</a></td>
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