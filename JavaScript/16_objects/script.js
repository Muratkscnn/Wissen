let ogrenci = {
    ad: "Engin",
    yas: 47,
    email:"enginniyazi@gmail.com",
    meslek:"Developer",
    cocuklar:["umay","Begüm","Heda","Köfte"],
    dersler: [
        {ad:"Matematik",not:89},
        {ad:"Fizik",not:99},
        {ad:"Kimya",not:79}
    ],
    login(){
        console.log(this.ad + ", Başarıyla giriş Yaptınız.")
    },
    logout(){
        console.log("Hatalı giriş Yaptınız.")
    },
    printCocuklar(){
        //console.log(this.cocuklar);
        this.cocuklar.forEach(element => {
            console.log(element);
        });
    },
    printLesson(){
        this.dersler.forEach(element => {
            console.log(element);
        });
    }
};
ogrenci.printLesson();
// console.log(ogrenci);
// console.log(ogrenci.ad);
// console.log(ogrenci["meslek"]);
// ogrenci.login();
// ogrenci.printCocuklar();