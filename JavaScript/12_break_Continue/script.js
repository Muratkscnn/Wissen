/* const notlar =[30,40,89,13,67,90,100,3];
for (let i = 0; i < notlar.length; i++) {
    
    if (notlar[i]==13) {
        continue;
    }
    console.log(notlar[i]);
    if (notlar[i]==100) {
        console.log("Tebrikler! En yüksek notu aldın.")
        break;
    }
} */
const not = "AA";
switch (not) {
    case "AA":
        console.log("En iyi not")
        break;
    case "BA":
        console.log("iyi not")
        break;
    case "CC":
        console.log("orta not")
        break; 
    case "DD":
        console.log("kötü not")
        break; 
    default:
        console.log("kötü")

    
}