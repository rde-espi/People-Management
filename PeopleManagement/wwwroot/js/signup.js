$('form').on('submit', function (event) {
    event.preventDefault();

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