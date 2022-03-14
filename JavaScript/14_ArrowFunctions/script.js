// const topla = function(sayi1,sayi2){
//     return sayi1 + sayi2;
// }

// const topla =(sayi1,sayi2) => sayi1+sayi2; //parametreli

// console.log(topla(12,45));

// const mesajYaz=() => console.log("Merhaba"); //parametre yoksa..
// mesajYaz();
// const alan =kenar => kenar**2; //tek parametreli
// console.log(alan(5));
const Fatura =(urunFiyatlari,vergiOrani) => {
    let toplam =0;
    for (let i = 0; i < urunFiyatlari.length; i++) 
    {
        let vergiliUrunFiyati=urunFiyatlari[i]*(1+vergiOrani);
        console.log(vergiliUrunFiyati);
        toplam += vergiliUrunFiyati;
    }
return toplam;
}

console.log(Fatura([10,20,30],0.2));