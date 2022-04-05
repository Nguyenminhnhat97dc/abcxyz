const Mau1 = document.querySelector('.container-context')
const test = document.querySelector('#Color-1')
const test_2 = document.querySelector('#Color-2')
const test_3 = document.querySelector('#Color-3')
const test_4 = document.querySelector('#Color-4')
const test_5 = document.querySelector('#Color-5')
const test_6 = document.querySelector('#Color-6')
const test_7 = document.querySelector('#Color-7')
const test_8 = document.querySelector('#Color-8')
test.addEventListener('click', function () {
    if (typeof sessionStorage.Mau1 !== 'undefined') {
        var abc = document.querySelector(sessionStorage.content)
        abc.innerHTML = "";
    } 
    Mau1.classList.remove(sessionStorage.Mau1);
    document.body.classList.remove(sessionStorage.body);
    Mau1.classList.add("bg-content-item-1")
    document.body.classList.add("body-bg-content-item-1");
    test.innerHTML = "&#10003;";
    sessionStorage.removeItem('Mau1');
    sessionStorage.removeItem('body');
    sessionStorage.setItem('content', '#Color-1')
    sessionStorage.setItem('Mau1', "bg-content-item-1");
    sessionStorage.setItem('body', "body-bg-content-item-1");
});
test_2.addEventListener('click', function () {
    if (typeof sessionStorage.Mau1 !== 'undefined') {
        var abc = document.querySelector(sessionStorage.content)
        abc.innerHTML = "";
    } 
    Mau1.classList.remove(sessionStorage.Mau1);
    document.body.classList.remove(sessionStorage.body);
    Mau1.classList.add("bg-content-item-2")
    document.body.classList.add("body-bg-content-item-2")
    test_2.innerHTML = "&#10003;";
    sessionStorage.removeItem('Mau1');
    sessionStorage.removeItem('body');
    sessionStorage.setItem('content', '#Color-2')
    sessionStorage.setItem('Mau1', "bg-content-item-2");
    sessionStorage.setItem('body', "body-bg-content-item-2");
  
});
test_3.addEventListener('click', function () {
    if (typeof sessionStorage.Mau1 !== 'undefined') {
        var abc = document.querySelector(sessionStorage.content)
        abc.innerHTML = "";
    } 
    Mau1.classList.remove(sessionStorage.Mau1);
    document.body.classList.remove(sessionStorage.body);
    Mau1.classList.add("bg-content-item-3")
    document.body.classList.add("body-bg-content-item-3")
    test_3.innerHTML = "&#10003;";
    sessionStorage.removeItem('Mau1');
    sessionStorage.removeItem('body');
    sessionStorage.setItem('content', '#Color-3')
    sessionStorage.setItem('Mau1', "bg-content-item-3");
    sessionStorage.setItem('body', "body-bg-content-item-3");

});
test_4.addEventListener('click', function () {
    if (typeof sessionStorage.Mau1 !== 'undefined') {
        var abc = document.querySelector(sessionStorage.content)
        abc.innerHTML = "";
    } 
    Mau1.classList.remove(sessionStorage.Mau1);
    document.body.classList.remove(sessionStorage.body);
    Mau1.classList.add("bg-content-item-4")
    document.body.classList.add("body-bg-content-item-4")
    test_4.innerHTML = "&#10003;";
    sessionStorage.removeItem('Mau1');
    sessionStorage.removeItem('body');
    sessionStorage.setItem('content', '#Color-4')
    sessionStorage.setItem('Mau1', "bg-content-item-4");
    sessionStorage.setItem('body', "body-bg-content-item-4");

});
test_5.addEventListener('click', function () {
    if (typeof sessionStorage.Mau1 !== 'undefined') {
        var abc = document.querySelector(sessionStorage.content)
        abc.innerHTML = "";
    } 
    Mau1.classList.remove(sessionStorage.Mau1);
    document.body.classList.remove(sessionStorage.body);
    Mau1.classList.add("bg-content-item-5")
    document.body.classList.add("body-bg-content-item-5")
    test_5.innerHTML = "&#10003;";
    sessionStorage.removeItem('Mau1');
    sessionStorage.removeItem('body');
    sessionStorage.setItem('content', '#Color-5')
    sessionStorage.setItem('Mau1', "bg-content-item-5");
    sessionStorage.setItem('body', "body-bg-content-item-5");
});
test_6.addEventListener('click', function () {
    if (typeof sessionStorage.Mau1 !== 'undefined') {
        var abc = document.querySelector(sessionStorage.content)
        abc.innerHTML = "";
    } 
    Mau1.classList.remove(sessionStorage.Mau1);
    document.body.classList.remove(sessionStorage.body);
    Mau1.classList.add("bg-content-item-6")
    document.body.classList.add("body-bg-content-item-6")
    test_6.innerHTML = "&#10003;";
    sessionStorage.removeItem('Mau1');
    sessionStorage.removeItem('body');
    sessionStorage.setItem('content', '#Color-6')
    sessionStorage.setItem('Mau1', "bg-content-item-6");
    sessionStorage.setItem('body', "body-bg-content-item-6");
});
test_7.addEventListener('click', function () {
    if (typeof sessionStorage.Mau1 !== 'undefined') {
        var abc = document.querySelector(sessionStorage.content)
        abc.innerHTML = "";
    } 
    Mau1.classList.remove(sessionStorage.Mau1);
    document.body.classList.remove(sessionStorage.body);
    Mau1.classList.add("bg-content-item-7")
    document.body.classList.add("body-bg-content-item-7")
    test_7.innerHTML = "&#10003;";
    sessionStorage.removeItem('Mau1');
    sessionStorage.removeItem('body');
    sessionStorage.setItem('content', '#Color-7')
    sessionStorage.setItem('Mau1', "bg-content-item-7");
    sessionStorage.setItem('body', "body-bg-content-item-7");
});
test_8.addEventListener('click', function () {
    if (typeof sessionStorage.Mau1 !== 'undefined') {
        var abc = document.querySelector(sessionStorage.content)
        abc.innerHTML = "";
    } 
    Mau1.classList.remove(sessionStorage.Mau1);
    document.body.classList.remove(sessionStorage.body);
    Mau1.classList.add("bg-content-item-8")
    document.body.classList.add("body-bg-content-item-8")
    test_8.innerHTML = "&#10003;";
    sessionStorage.removeItem('Mau1');
    sessionStorage.removeItem('body');
    sessionStorage.setItem('content', '#Color-8')
    sessionStorage.setItem('Mau1', "bg-content-item-8");
    sessionStorage.setItem('body', "body-bg-content-item-8");
});
if (typeof sessionStorage.Mau1 !== 'undefined') {
    Mau1.classList.add(sessionStorage.Mau1);
    document.body.classList.add(sessionStorage.body);
    var abc = document.querySelector(sessionStorage.content)
    abc.innerHTML = "&#10003;";
};
const plus = document.querySelector('.plus')
const minus = document.querySelector('.minus')
const TenTruyen = document.querySelector('.TenTruyen')
const Chuong = document.querySelector('.Chuong')
const NoiDung = document.querySelector('.NoiDung-Truyen')
const previous = document.querySelector('.previous')
const next = document.querySelector('.next')
minus.addEventListener('click', function () {
    const value_size = document.querySelector('.value').innerHTML
    if (value_size > 20) {
        var size = value_size - '1';
        NoiDung.style.fontSize = size + 'px';
        TenTruyen.style.fontSize = size + 'px';
        Chuong.style.fontSize = size + 'px';
        var abc = document.querySelector('.value');
        abc.innerHTML = size;
    }
});
plus.onclick = function () { myfunction() };
function myfunction() {
    const value_size = document.querySelector('.value').innerHTML
    if (value_size < 30) {
        var size = Number(value_size) + 1;
        NoiDung.style.fontSize = size + 'px';
        TenTruyen.style.fontSize = size + 'px';
        Chuong.style.fontSize = size + 'px';
        var abc = document.querySelector('.value');
        abc.innerHTML = size;
    }
};
const plus_line = document.querySelector('.plus-line')
const minus_line = document.querySelector('.minus-line')
minus_line.addEventListener('click', function () {
    const value_size = document.querySelector('.value-line').innerHTML
    if (value_size >= 2) {
        var size = value_size - '1';
        NoiDung.style.lineHeight  = size + 'rem';
        TenTruyen.style.lineHeight = size + 'rem';
        Chuong.style.lineHeight = size + 'rem';
        var abc = document.querySelector('.value-line');
        abc.innerHTML = size;
    }
});
plus_line.onclick = function () { myfunction_line() };
function myfunction_line() {
    const value_size = document.querySelector('.value-line').innerHTML
    if (value_size <= 5) {
        var size = Number(value_size) + 0.5;
        NoiDung.style.lineHeight = size + 'rem';
        TenTruyen.style.lineHeight = size + 'rem';
        Chuong.style.lineHeight = size + 'rem';
        var abc = document.querySelector('.value-line');
        abc.innerHTML = size;
    }
};
window.onscroll = function () { myFunction() };

// Get the header
var header = document.querySelector('#myMenuAction')

// Get the offset position of the navbar
var sticky = header.offsetTop;

// Add the sticky class to the header when you reach its scroll position. Remove "sticky" when you leave the scroll position
function myFunction() {
    if (window.pageYOffset > sticky) {
        header.classList.remove("Menu-action");
        header.classList.add("sticky");
    } else {
        header.classList.remove("sticky");
        header.classList.add("Menu-action");
    }
}

    