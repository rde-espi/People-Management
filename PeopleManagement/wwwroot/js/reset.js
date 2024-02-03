$('form').on('submit', function (event) {
    event.preventDefault();

    if ($("#password").val() != $("#confirmPassword").val()) {
        $(".error span").show();

        setTimeout(function () {
            $(".error span").hide();
        }, 5000)
        return;
    }

    const urlParam = new URLSearchParams(window.location.search);
    const id = urlParam.get("id");

    var formData = {
        password: $("#password").val(),
        confirmPassword: $("#confirmPassword").val(),
        id: id
    }


    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:44371/api/user/reset",
        success: function (result) {
            if (result.response == "OK")
                alert("Password updated sucessfully");
            else {
                alert("Something went wrong");
            }
        },
        error: function (error) {
            console.log(erro);
        }
    })
});