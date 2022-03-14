let isimler=["engin","umay","begüm"];
console.log(isimler[0]);
console.log(isimler[1]);
console.log(isimler[2]);

let yaslar=[13,56,34];
console.log(yaslar[2]);

let karisik=["umay","begüm",15,22]
console.log(karisik[1]);
console.log(karisik.length);

let virgulluBirlestir=isimler.join(',');
//let virgulluBirlestir=isimler.join('/');
//let virgulluBirlestir=isimler.join('-');

console.log(virgulluBirlestir);

let siraNo=isimler.indexOf("umay");
console.log(siraNo);

let yeniIsımler= isimler.concat(["recep","mikail","aslı"]);
console.log(yeniIsımler);

isimler.push("elif");
console.log(isimler);

isimler.pop();
console.log(isimler);
