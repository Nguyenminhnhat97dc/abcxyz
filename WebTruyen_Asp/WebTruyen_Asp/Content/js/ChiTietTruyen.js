const slider = document.querySelector('.slider-2-master2');
const slidershows = document.querySelector('.slidershows-master2');
const prev = document.querySelector('.prev');
const next = document.querySelector('.next');
var direction;
prev.addEventListener("click", function () {
    if (direction === -1) {
        slider.appendChild(slider.firstElementChild);
        direction = 1;
    }
    slidershows.style.justifyContent = 'flex-end';
    slider.style.transform = 'translate(20%)';
});
next.addEventListener("click", function () {

    direction = -1;

    slidershows.style.justifyContent = 'flex-start';
    slider.style.transform = 'translate(-20%)';
});
slider.addEventListener('transitionend', function () {
    if (direction === -1) {
        slider.appendChild(slider.firstElementChild);
    } else if (direction === 1) {
        slider.prepend(slider.lastElementChild)
    }

    slider.style.transition = 'none';
    slider.style.transform = 'translate(0)';
    setTimeout(function () {
        slider.style.transition = 'all 0.5s';
    });

});
/*--------------------------Review Truyenj---------------------------*/
const Slidevalue_1 = document.querySelector('.value-range-1')
const inputSlide_1 = document.querySelector('.input-Review-1')
inputSlide_1.oninput = (() => {
    let value = inputSlide_1.value;
    Slidevalue_1.textContent = value;
});

const Slidevalue_2 = document.querySelector('.value-range-2')
const inputSlide_2 = document.querySelector('.input-Review-2')
inputSlide_2.oninput = (() => {
    let value = inputSlide_2.value;
    Slidevalue_2.textContent = value;
});

const Slidevalue_3 = document.querySelector('.value-range-3')
const inputSlide_3 = document.querySelector('.input-Review-3')
inputSlide_3.oninput = (() => {
    let value = inputSlide_3.value;
    Slidevalue_3.textContent = value;
});
/*--------------------------Rastring Star-----------------------------------*/
//var Value_Ratring = document.getElementById("input_1").value
//const Star_Rating = document.querySelectorAll("#star_1")
//const Star_Rating_3 = document.querySelectorAll("#star_3")
//const Star_Rating_4 = document.querySelectorAll("#star_4")
//const Star_Rating_5 = document.querySelectorAll("#star_5")
//const Star_Rating_6 = document.querySelectorAll("#star_6")
//for (var i = 0; i < Value_Ratring; i++) {
//    Star_Rating[i].style.color = "orange"
//}
//const Star_Rating_2 = document.querySelectorAll("#star_2")
//for (var i = 0; i < Value_Ratring; i++) {
//    Star_Rating_2[i].style.color = "orange"
//}

const Star_Rating = [
    Star_1 = document.querySelectorAll("#star_1"),
    Star_2 = document.querySelectorAll("#star_2"),
    Star_3 = document.querySelectorAll("#star_3"),
    Star_4 = document.querySelectorAll("#star_4"),
    Star_5 = document.querySelectorAll("#star_5"),
    Star_6 = document.querySelectorAll("#star_6")
];
var value_2 = document.getElementById("input_2");
if (value_2 == null) {
    value_2 = 0;
}
else {
    value_2 = document.getElementById("input_2").value;
}
const Value_Rating = [
    Value_1 = document.getElementById("input_1").value,
    Value_2 = value_2,
    Value_3 = document.getElementById("value-star_3").value,
    Value_4 = document.getElementById("value-star_4").value,
    Value_5 = document.getElementById("value-star_5").value,
    Value_6 = document.getElementById("value-star_6").value
];

for (var i = 0; i <= Star_Rating.length; i++) {
    for (var j = 0; j < Value_Rating[i]; j++) {
        Star_Rating[i][j].style.color = "orange"
    }
}