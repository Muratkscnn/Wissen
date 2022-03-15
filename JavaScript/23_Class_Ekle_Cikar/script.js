const icerik = document.querySelector("p");
console.log(icerik.classList);
icerik.classList.add("topHeader");
icerik.classList.remove("error");

const pDegeri =document.querySelectorAll("p");
pDegeri.forEach(element => {
    if (element.textContent.includes("error")) {
        element.classList.add("error");
    }
    if (element.textContent.includes("succes")) {
        element.classList.add("succes");
    }
});