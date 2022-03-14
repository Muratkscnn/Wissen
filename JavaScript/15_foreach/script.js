let ogrenciler = ["Aslı","Doğukan","Elif","Murat","Berrak","Candan"];
// ogrenciler.forEach(element => {
//     console.log("Selam" + " " + element);
// });
let html=``;
const ulmain=document.querySelector(".main");
ogrenciler.forEach(element => {
    html+=`<li>${element}</li>`
});
console.log(html);
ulmain.innerHTML=html;

const pDegeri=document.querySelector("p");
pDegeri.innerText="Selam";
