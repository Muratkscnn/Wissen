const section = document.querySelector("section");
console.log(section.children);
console.log(Array.from(section.children)); //html collection tipini diziye çevirme

Array.from(section.children).forEach(element => {
    element.classList.add("section_element");
});

const baslik=document.querySelector("h2");
console.log(baslik.parentElement);
console.log(baslik.nextElementSibling);
console.log(baslik.previousElementSibling);
