$(function () {
    var s;
    if (s == 1) {
        s = 1;
    }
    else
        s = 0;

    $('.sidebar-toggle').click(function () {
        toggle();
    });

    toggle();

    function toggle() {
        if (s != 1) {
            s = 1;

            //$('.sidebar').css('left', '0');
            $('.sidebar').css('width', '50px');

            $('.content').css('padding-left', '50px');

            $('.sidebar .pl-25').addClass('hidden');



        } else {
            s = 0;
            //$('.sidebar').css('left', '-200px');

            $('.sidebar').css('width', '200px');

            $('.content').css('padding-left', '200px');
            $('.sidebar .pl-25').removeClass('hidden');


        }
    }




});


/*dropdown open*/

$(".dopen").click(function () {
    $(this).toggleClass('open');
});

/*setting expanded*/


$(".nav-tabs a").click(function () {
  
    $(this).tab('show');

    

    });


/*setting expanded end*/


/*comment hide and show*/

$('.comment').click(function () {
    $(this).offsetParent('div#tn-feedbox').children('ul.comments').toggleClass('display-block');    
});
/*comments hide and shwo end*/