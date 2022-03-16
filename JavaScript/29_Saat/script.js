const clock = document.querySelector(".clock");
function zamaniYaz() {
var zaman = new Date();
    
    let saat = zaman.getHours();
    let dakika = zaman.getMinutes();
    let saniye = zaman.getSeconds();
    const html = `<span>${saat}</span> :
                <span>${dakika}</span> :
                <span>${saniye}</span>`;
    clock.innerHTML = html;
}


setInterval(zamaniYaz,1000);