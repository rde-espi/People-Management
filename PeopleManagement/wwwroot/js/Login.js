//function login(event) {

//    event.preventDefault();

//    var formData = {
//        email: $("#email").val(),
//        password: $("#password").val()
//    }


//    $.ajax({
//        type: "POST",
//        dataType: "json",
//        contentType: "application/json; charset=UTF-8",
//        data: JSON.stringify(formData),
//        url: "https://localhost:44371/api/user",
//        success: function (result) {

//        },
//        error: function (error) {
//        }
//    })

//}
$('form').on('submit', function (event) {
    event.preventDefault();

    var formData = {
        email: $("#email").val(),
        password: $("#password").val()
    }


    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify(formData),
        url: "https://localhost:44371/api/user",
        success: function (result) {
            if (result.response == 'OK')
                alert("Logado")
            else {
                alert("invalid credencials")

            }
                

        },
        error: function (error) {
            console.log(erro);
        }
    })
});