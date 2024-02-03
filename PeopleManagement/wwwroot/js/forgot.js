$('form').on('submit', function (event) {
    event.preventDefault();

    
    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF-8",
        data: JSON.stringify($("#email").val()),
        url: "https://localhost:44371/api/user/forgot",
        success: function (result) {
            if (result.response == "OK")
                alert("A email with a link was sended to restore your password");
            else {
                alert("Something went wrong");
            }
        },
        error: function (error) {
            console.log(erro);
        }
    })
});