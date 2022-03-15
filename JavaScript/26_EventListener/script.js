const buton=document.querySelector("button");
const ul=document.querySelector("ul");
buton.addEventListener("click",() => 
{
    const li =document.createElement("li");
    li.textContent="JavaScript";
    ul.append(li); //sona ekleme yapar
    //ul.prepend(li);//başa ekleme yapar
})
// const li =document.querySelector("li");
// li.addEventListener("click",() => 
// {
//     alert("Tıklandı");
// })

const liElemanlari=document.querySelectorAll("li");
liElemanlari.forEach(element => {
    element.addEventListener("click",(e) => 
    {
        e.target.remove();
    }
    )
});
