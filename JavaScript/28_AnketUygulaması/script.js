const correctAnswers =["E","E","E","E","E","E","E","E"];
const form = document.querySelector("form");
const result=document.querySelector(".result");
form.addEventListener("submit",e =>
{
    e.preventDefault();//bunun sayesinde submit refresh atmayacak
    let score=0;
    const userAnswers=[form.q1.value,form.q2.value,form.q3.value,form.q4.value,form.q5.value,form.q6.value,form.q7.value,form.q8.value];
   /*  userAnswers.forEach((answer,index) => {
        if (answer==correctAnswers[index]) {
            score+=12.5;
        }
    }); */
    for (let i = 0; i < correctAnswers.length; i++) {
        if (correctAnswers[i]==userAnswers[i]) {
            score+=12.5;
            
        }
        
    }
    result.classList.remove("result-none");
    //result.querySelector("span").textContent=`%${score}`;
    //console.log(score)

    let score2=0;
    const animateScore=setInterval(()=>{
        result.querySelector("span").textContent=`%${score2}`;
        if (score2>score) {
            clearInterval(animateScore);
        }
        else{
            score2+=1;
        }
    },20);
    
})