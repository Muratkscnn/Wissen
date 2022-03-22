/* const slider=document.querySelectorAll(".slider");
let slideNo=0;
//console.log(slider);

/* slider kodları */
/* function previous(){
    if (slideNo==0) {
        slideNo=slider.length-1;
    }
     else {
        slideNo--;
        
    }
    slideShow(slideNo);
    
}
function next() {
    
    if (slideNo==slider.length-1) {
        slideNo=0;
    } else {
        slideNo++;
    }
    slideShow(slideNo);

}
function slideShow(slideNumber){
    let slideNo=slideNumber;
    for (let i = 0; i < slider.length ; i++) {
           slider[i].style.display="none";
    }
    slider[slideNo].style.display="block";
}
slideShow(slideNo);
console.log(slider.length);
const my=setInterval(next,5000);
 */
//todo list Kodları
const newTaskButton =document.querySelector("#newTaskButton");
const newTaskTextBox=document.querySelector("#newTaskTextBox");
const taskListBox=document.querySelector("#taskListBox");
const ul=document.querySelector("ul");
let html="";

newTaskButton.addEventListener("click",newTask)
function newTask() 
{
    if (newTaskTextBox.value=="") {
        alert("Lütfen görev açıklamasını yazınız..")     
    }
    else{
        /* let li =document.createElement("li");
        li.innerText=newTaskTextBox.value;
        taskListBox.appendChild(li);
        newTaskTextBox.value="";
        let i=document.createElement("i");
        i.classList="fa fa-close";
        li.appendChild(i); */
        //oluşturulan kapatma butonlarına listener ekliyoruz
        html +=`<li>${newTaskTextBox.value}<i>X</i></li>`;
        ul.innerHTML=html;
        newTaskTextBox.value="";
        let deleteTaskButtons=ul.querySelectorAll("i");
        for (let i = 0; i < deleteTaskButtons.length; i++) {
          deleteTaskButtons[i].addEventListener("click",e =>{
              
              e.target.parentElement.remove();
              html=ul.innerHTML;             
          })
          
            
        }
        
    }
}