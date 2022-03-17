const form = document.querySelector("form");
const label = document.querySelector(".label")
form.addEventListener("submit",e=>{
    e.preventDefault();
    const userName=form.userName.value;
    const userNameModel=/^[a-z]{6,10}$/; //regexkodları
    if (userNameModel.test(userName)) {
        label.innerHTML="<label>Kullanıcı Adı Kullanılabilir</label>"
        form.userName.classList.add("succes");
        form.userName.classList.remove("error");

    }
    else{
        label.innerHTML="<label>Hatalı Giriş</label>";
        form.userName.classList.add("error");
        form.userName.classList.remove("succes");
        
    }

    

});
