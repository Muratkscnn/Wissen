$(document).ready(function () {
    $("li a").each(function () {
        console.log($(this))
        if ($(this).attr("href") == window.location.pathname)
            
            $(this).addClass("active");
    })
   
})


