let x = document.getElementsByClassName("Theloai-style");

// Lặp qua các phần tử có class là menu
for (let i = 0; i < x.length; i++) {

    // Lắng nghe sự kiện click
    // và đổi màu chữ thành màu đỏ
    x[i].onclick = function () {
        if (typeof sessionStorage.html_class !== 'undefined') {
            var a = x[sessionStorage.html_class];
            a.classList.remove("Theloai-style-js");
            sessionStorage.removeItem("html_class");
        }
        this.classList.add("Theloai-style-js");
        sessionStorage.setItem("html_class", i);
    };
}
if (typeof sessionStorage.html_class !== 'undefined') {
    var a = x[sessionStorage.html_class];   
    a.classList.add("Theloai-style-js");    
};