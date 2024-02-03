$('form').on('submit', function (event) {
    event.preventDefault();

    if ($("#password").val() != $("#confirmPassword").val()) {
        $(".error span").show();

        setTimeout(function(){
            $(".error span").hide();
        },5000)
        return;
    }

    var formData = {
        email: $("#email").val(),
        password: $("#password").val(),
        confirmPassword: $("#confirmPassword").val(),
        username: $("#username").val()
    }


    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:44371/api/user/create",
        success: function (result) {
            if (result.response == "OK")
                alert("User Created");
            else {
                alert("Wasn't possible create the User");
            }
        },
        error: function (error) {
            console.log(erro);
        }
    })
});