const slider = document.querySelector('.slider-2');
const slidershows = document.querySelector('.slidershows');
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


/*--------------------------Master_3-----------------------*/

/*--------------------------End of Master_3-----------------------*/
/*--------------------------End of Rastring Star----------------------------*/
/*--------------------------End of Review Truyenj---------------------------*/
//var submit = $("button[type='submit']");
//submit.click(function () {
//    var user = $("input[name='User']").val();
//    var matruyen = $("input[name='MaTruyen']").val();
//    var binhluan = $("textarea[name='BinhLuan']").val();
//    alert(user);
//    // Kiểm tra đã nhập tên tài khoản chưa
//    if (binhluan == '') {
//        alert('Vui lòng nhập bình luận');
//        return false;
//    }
//    // Lấy tất cả dữ liệu trong form login
//    //var data = $('form#form-login').serialize();
//     //sử dụng $.ajax()
//    $.ajax({
//        type: 'post', //kiểu post
//        url: 'Truyen/loadajax1', //gửi dữ liệu sang trang submit.php
//        data: { a: user, b: matruyen, c: binhluan },
//        success: function (data) {
//            if (data == 'false') {
//                alert('sai tên đăng nhập hoặc mật khẩu');
//            } else {
//                alert(data);
//                $('#productresult').html(data);
//            }
//        }
//    });
//});
//$(document).ready(function () {
//    $("button[type = 'submit']").click(function () {
//            var user = $("input[name='User']").val();
//            var matruyen = $("input[name='MaTruyen']").val();
//            var binhluan = $("textarea[name='BinhLuan']").val();
//            alert(user);
//    });
//});