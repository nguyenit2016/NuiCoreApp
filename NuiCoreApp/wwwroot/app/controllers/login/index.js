var loginController = function () {

    this.initialize = function () {
        registerEvent();
    }

    var registerEvent = function () {
        $("#frmLogin").validate({
            errorClass: "red",
            ignore: [],
            lang: "vi",
            rules: {
                username: {
                    required: true
                },
                password: {
                    requred: true
                }
            }
        });

        $("#btnLogin").on('click', function (e) {
            if ($("#frmLogin").valid()) {
                e.preventDefault();
                var user = $("#username").val();
                var pass = $("#password").val();
                login(user, pass);
            }
        });
        $("#username").keypress(function () {
            var user = $("#username").val();
            var pass = $("#password").val();
            if (user != "" || pass != "") {
                login(user, pass);
            }
            else if (user == "") {
                $("#username").focus();
            } else {
                $("#password").focus();
            }
        });
        $("#password").keypress(function () {
            var user = $("#username").val();
            var pass = $("#password").val();
            if (user != "" || pass != "") {
                login(user, pass);
            }
            else if (user == "") {
                $("#username").focus();
            } else {
                $("#password").focus();
            }
        });
    }

    var login = function (user, pass) {
        $.ajax({
            type: "POST",
            data: {
                UserName: user,
                Password: pass
            },
            beforeSend: function () {
                NProgress.start();
            },
            dataType: "json",
            url: "/Admin/Login/Auth",
            success: function (result) {
                NProgress.done();
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