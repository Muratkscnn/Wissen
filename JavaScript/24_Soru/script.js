const not=[10,20,75,75,15,35,100,95,35,75,51,45,25]
const div=document.querySelector("div");

not.forEach(element => {
    
     degisken="gecti";
    if (element<50) {
        degisken="kaldi";
        
    }
    div.innerHTML+=`<li class="${degisken}">${element}</li>`;
});


/* const not=[10,20,50,75,15,35,100,95,35,75,51,45,25]
const div=document.querySelector("div");
not.forEach(element => {
    div.innerHTML+=`<li>${element}</li>`;
});

const notlar=document.querySelectorAll("li");
console.log(notlar);

notlar.forEach(element => {
    if (element.innerText>=50) {
        element.classList.add("gecti");
    }
    if (element.innerText<50) {
        element.classList.add("kaldı");
    }
}); */