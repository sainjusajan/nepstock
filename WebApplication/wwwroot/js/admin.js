/*
Written by:
Mahesh Sunuwar
Team Teknean
*/
$('.tn-sidebar li').on('click', function () {
    $('.tn-sidebar li').removeClass('tn-bg-nav-click');
    $(this).addClass('tn-bg-nav-click');
    $(this).find('span:nth-child(3)').removeClass('fa fa-caret-down').toggleClass('fa fa-caret-left');
});




$('.tn-nav li.expand a').on('click', function () {
   
        $('.tn-sidebar li span').addClass('display');
       $('.tn-sidebar').addClass('tn-sidebar-togglewidth');
        //$('.tn-nav').addClass('tn-header-nav-toggle');
        $('.tn-nav li:nth-child(2).expand').css({
            'display': 'none'
        });
        $('.tn-nav li:nth-child(2).close').css({
            'display': 'block'
        });
        $('.tn-body-content').addClass('tn-header-body-toggle');
        //documnent.cookie = "tn="+1;
      

});

$('.tn-body-content').on('click', function () {
  
        $('.tn-sidebar li span').removeClass('display');
        $('.tn-sidebar').removeClass('tn-sidebar-togglewidth');
        //$('.tn-nav').removeClass('tn-header-nav-toggle');
        $('.tn-nav li:nth-child(2).close').css({
            'display': 'none'
        });
        $('.tn-nav li:nth-child(1).open').css({
            'display': 'block'
        });
        $('.tn-body-content').removeClass('tn-header-body-toggle');
});


/*dropdown toggle*/


/*dropdown toggle end*/
