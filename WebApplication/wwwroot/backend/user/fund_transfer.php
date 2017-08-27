<?php include ('header.php') ?>
<!--main content start-->
<section id="main-content">
  <section class="wrapper site-min-height">
    <!-- page start-->
    <section class="bread_crumb">
<div class="row">
<div class="col-md-6 col-sm-6">
<h3>Fund Transfer
</h3>
</div> <!-- // col -->
<div class="col-md-6 col-sm-6">
<ul class="crumbs">
<li><a href="index.php">Home</a></li>
<li> > </li>
<li>Fund Transfer</li>  
</ul>
</div> <!-- // col -->
</div> <!-- // row -->
    </section> <!-- // bread_crumb -->
            <div class="panel">
              <div class="panel-body">
    <div class="row">
      <div class="col-md-9 col-sm-8">
        <form action="" method="">
          <div class="row">
            <div class="col-md-6 col-sm-6">
 <div class="form-group">
    <label for="mobile">Email Address</label>
    <input type="email" class="form-control" id="email" placeholder="Email Address">
  </div>
            </div> <!-- col -->
             <div class="col-md-6 col-sm-6">
 <div class="form-group">
    <label for="amount">Amount</label>
    <select class="form-control">
      <option>NRS 10</option>
      <option>NRS 20</option>
      <option>NRS 30</option>
      <option>NRS 40</option>
      <option>NRS 50</option>
      <option>NRS 100</option>
    </select>
  </div>
            </div> <!-- col -->
              <div class="col-md-12 col-sm-12">
 <div class="form-group">
    <label for="remarks">Remarks (Optional)</label>
    <textarea class="form-control" rows="5" placeholder="Remarks (Optional)"></textarea>
  </div>
            </div> <!-- col -->
          </div> <!-- // row -->
          <button type="submit" class="btn btn-primary">Submit</button>
        </form>
      </div> <!-- // col -->

        <div class="col-md-3 col-sm-4">
          <table class="table table-striped table-bordered side_table">
            <thead>
            <tr>
                <th colspan="2">Available Balance</th>

            </tr>
            </thead>
            <tbody>
            <tr>
                <td>NPR</td>
                <td>5905</td>
            </tr>
            </tbody>
        </table>

           <table class="table table-striped table-bordered side_table_2">
            <thead>
            <tr>
                <th colspan="3">Earned Commission
</th>

            </tr>
            </thead>
            <tbody>
            <tr>
                <td>Today</td>
                <td>NPR</td>
                <td>0</td>
            </tr>
            <tr>
                <td>Yesterday</td>
                <td>NPR</td>
                <td>0</td>
            </tr>
            <tr>
                <td>This Month</td>
                <td>NPR</td>
                <td>10000</td>
            </tr>
            <tr>
                <td>Last Month</td>
                <td>NPR</td>
                <td>0</td>
            </tr>
            </tbody>
        </table>
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