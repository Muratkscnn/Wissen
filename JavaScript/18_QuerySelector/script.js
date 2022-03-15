//const error=document.querySelector('p'); //bu komut karşılaştığı ilk seçiciyi getirir..
//const error =document.querySelector('.hata');
//const error =document.querySelector('div.hata');
//const error =document.querySelector('div p.hata');
//const error =document.querySelector('#hata2');
//console.log(error);


const errors = document.querySelectorAll("p");
console.log(errors);
console.log(errors[1]);

errors.forEach(element => {
    console.log(element);
    
});