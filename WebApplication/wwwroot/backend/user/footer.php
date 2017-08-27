<!--footer start-->
<footer class="site-footer">
  <div class="text-center">
    2016 &copy; Topupnp.com
    <a href="#" class="go-top">
      <i class="fa fa-angle-up"></i>
    </a>
  </div>
</footer>
<!--footer end-->
</section> <!-- main id container's section-->
</div> <!-- // container -->
<!-- scripts to be included in the footer -->
<script src="js/jquery.js"></script>
<script src="js/bootstrap.min.js"></script>
<script class="include" type="text/javascript" src="js/jquery.dcjqaccordion.2.7.js"></script>
<script src="js/jquery.scrollTo.min.js"></script>
<script src="js/slidebars.min.js"></script>
<script src="js/respond.min.js" ></script>

<!-- datatable js -->
<script type="text/javascript" src="https://cdn.datatables.net/1.10.12/js/jquery.dataTables.min.js"></script>
<script type="text/javascript">
$(document).ready(function() {
// Setup - add a text input to each footer cell
$('#example tfoot th').each( function () {
var title = $(this).text();
$(this).html( '<div class="table-inner-search"><form id="demo-2"><input type="search" placeholder="Search"></form></div>' );
} );
// DataTable
var table = $('#example').DataTable();
// Apply the search
table.columns().every( function () {
var that = this;
$( 'input', this.footer() ).on( 'keyup change', function () {
if ( that.search() !== this.value ) {
that
.search( this.value )
.draw();
}
} );
} );
} );
</script>
<!-- jquery for jquery ui and date -->
  <script src="http://code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
                                  <script>
                                  $(function() {
                                  $( "#datepicker-1" ).datepicker();
                                  $( "#datepicker-2" ).datepicker();
                                  });
                                  </script>
<!-- custom file upload ko js -->
<script type="text/javascript" src="js/file_upload.js"></script>
<!--common script for all pages-->
<script src="js/common-scripts.js"></script>
</body>
</html>