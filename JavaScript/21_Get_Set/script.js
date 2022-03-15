const link = document.querySelector("a");
console.log(link.getAttribute("href"));
link.setAttribute("href","https://www.wissenakademie.com");
link.textContent="Wissen";

const pDegeri=document.querySelector("p");
console.log(pDegeri.getAttribute("class"));
pDegeri.setAttribute("class","hata");
console.log(pDegeri.getAttribute("class"));

pDegeri.setAttribute("style","background:red");