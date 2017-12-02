var loginController = function () {

    this.initialize = function () {
        registerEvent();
    }

    var registerEvent = function () {
        $("#btnLogin").on('click', function (e) {
            e.preventDefault();
            var user = $("#username").val();
            var pass = $("#password").val();
            login(user, pass);
        });
    }

    var login = function (user, pass) {
        $.ajax({
            type: "POST",
            data: {
                UserName: user,
                Password: pass
            },
            dataType: "json",
            url: "/Admin/Login/Auth",
            success: function (result) {
                if (result.Success) {
                    window.location.href = "/Admin/Home/Index";
                }
                else {
                    nui.notify("Đăng nhập chưa thành công", "error");
                }
            }
        });
    }
}