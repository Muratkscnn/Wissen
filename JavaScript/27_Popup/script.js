const buton=document.querySelector("button");
const mainPopup =document.querySelector(".main-popup");
const close =document.querySelector(".close-popup");

buton.addEventListener("click",() => {
    mainPopup.style.display="block";
}
)
close.addEventListener("click",() =>{
    mainPopup.style.display="none";
})
mainPopup.addEventListener("click",e =>{
    if (e.target.className=="main-popup") {
        mainPopup.style.display="none";
    }
})