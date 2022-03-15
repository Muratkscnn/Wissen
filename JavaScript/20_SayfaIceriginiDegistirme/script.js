/* const selam = document.querySelector('p');
console.log(selam.innerText);
selam.innerText="AleykumSelam";

const topheader =document.getElementById("topheader");
topheader.innerText="JavaScript Dersleri"; */

/* const paragraflar = document.querySelectorAll("p");

paragraflar.forEach(element => {
    console.log(element.innerText);
    element.innerText+=" işte ben ekledim";
}); */

const icerik = document.querySelector(".content");
console.log(icerik.innerHTML);
icerik.innerHTML+="<h2>Bu da alt başlık</h2>";


const ogrenciler =["recep","mikail","aslı"];

ogrenciler.forEach(element => {
    
    icerik.innerHTML+= `<li>${element}</li>`;
});


