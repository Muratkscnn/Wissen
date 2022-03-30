let slideIndex = 0;
let allSlides = $(".slide").toArray();
console.log(allSlides);
$(".nextSlide").click(function(){
    if(allSlides.length==slideIndex+1){
        slideIndex=-1;
    }
    showSlide(++slideIndex);
})

$(".prevSlide").click(function(){
    if(slideIndex==0){
        slideIndex=allSlides.length;
    }
    showSlide(--slideIndex);
})

function showSlide(n){
    
    for(let i=0; i<allSlides.length; i++){
        allSlides[i].style.display="none";
        $(".dot").eq(i).removeClass("active")

        //$(".slide").eq(i).hide("");
    }
        allSlides[n].style.display="block";
        $(".dot").eq(n).addClass("active")

    //$(".slide").eq(n).fadeTo(2000,0.8);
    //ÖDEV:
    //Kayarak giden slider yapın.
}

$(".dot").click(function(){
    slideIndex=$(this).index();
    showSlide(slideIndex);
})

showSlide(slideIndex);