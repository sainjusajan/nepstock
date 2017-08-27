<?php include ('header.php') ?>
<style type="text/css">
  .custom-info-circle{
    font-size: 50px;
    background: #efefef;
    height: 80px;
    width: 80px;
    text-align: center;
    border-radius: 50%;
    color: #fff;
    margin-bottom: 25px;
    vertical-align: middle;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-align: center;
    -ms-flex-align: center;
    align-items: center;
    -ms-flex-line-pack: center;
    align-content: center;
    -webkit-box-pack: center;
    -ms-flex-pack: center;
    justify-content: center;
  }
  @media (min-width: 992px){
.custom-col-border{
    border-right: 1px solid #eee;
}
}
</style>
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
      <div class="col-md-9 col-sm-8">
        <form action="" method="">
          <div class="row">
            <div class="col-md-6 col-sm-6 custom-col-border">
 <div class="form-group">
    <label for="mobile">Mobile no.</label>
    <div class="row">
      <div class="col-md-2 col-sm-2 col-xs-3">
        <p class="nine_seven_seven">+977</p>
      </div>
            <div class="col-md-10 col-sm-10 col-xs-9">
    <input type="number" class="form-control" id="mobile" placeholder="Mobile no.">
  </div>
  </div> <!-- // row -->
  </div> <!-- // form- group -->
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
  </div> <!-- // form - group -->
 <div class="form-group">
    <label for="remarks">Remarks (Optional)</label>
    <textarea class="form-control" rows="5" placeholder="Remarks (Optional)"></textarea>
  </div> <!-- // form - group -->
          <button type="submit" class="btn btn-primary">Submit</button>

          </div> <!-- // col -->
          <div class="col-md-6 col-sm-6">
          <i class="fa fa-info custom-info-circle"></i>
            <p class="text-justify">

Please enter your NT Landline number. Enter the amount for which you wish to make the payment 
</p>
<p class="text-justify">
If your Bill Amount is NPR 430, pay NPR 500. Your remaining amount will be carried forward for next payment.
</p>
            </p>
          </div> <!-- // col -->
                    </div> <!-- // row -->

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