let email="muratkscn@gmail.com";
console.log(email);

let bolumAd='Web Gelistirme';
console.log(bolumAd);

let tumu = bolumAd + " " + email;
console.log(tumu);
console.log(bolumAd[2]);
console.log(bolumAd.length)

let sehirAd="Irak";
console.log(sehirAd.toUpperCase());
console.log(sehirAd.toLocaleUpperCase());
console.log(sehirAd.toLowerCase());
console.log(sehirAd.toLocaleLowerCase());

let siraNo =email.indexOf("i");
console.log(siraNo);

let adSoyad="Murat Kuşcan";
console.log(adSoyad);

let sonSiraNo=adSoyad.lastIndexOf('a');
console.log(sonSiraNo);

let bastanAl=adSoyad.slice(0,5);
console.log(bastanAl);

let bastanAl2=adSoyad.slice(6,12);
console.log(bastanAl2);
let bastanAl3=adSoyad.substring(6,0);
console.log(bastanAl3);
let bastanAl4=adSoyad.substring(6,12);
console.log(bastanAl4);

let degistir = adSoyad.replace("u", "C")
console.log(degistir);
