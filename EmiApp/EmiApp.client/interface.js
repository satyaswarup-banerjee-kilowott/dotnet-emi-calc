

$(document).ready(function() {
    $("form").submit(function(event) {
        var formData ={
            principal: $("#principal").val(),
            interestRateInPercentage: $("#interestRateInPercentage").val(),
            loanDurationInYearCount: $("#loanDurationInYearCount").val(),
        };
    
        $.ajax({
            type: "POST",
            url: "https://localhost:7281/api/emi/calculatemonthlyemi",
            data: formData,
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(formData),
            dataType: "json",
            encode: true,
        }).done(function(data){
            console.log(data);

            
        });
        (response) =>{
            console.log(response);
        }

        event.preventDefault();
    });
});






