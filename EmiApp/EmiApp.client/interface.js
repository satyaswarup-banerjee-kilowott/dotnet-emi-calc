
//AJAX call for MontlyEmi API
$(document).ready(function() {
    $("#form1").submit(function(event) {
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





//AJAX call for DailyEmi API
$(document).ready(function() {
    $("#form2").submit(function(event) {
        var formData ={
            principal: $("#principal").val(),
            interestRateInPercentage: $("#interestRateInPercentage").val(),
            loanDurationInYearCount: $("#loanDurationInYearCount").val(),
        };
    
        $.ajax({
            type: "POST",
            url: "https://localhost:7281/api/emi/calculatedailyemi",
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








//AJAX call for ContinousEmi API
$(document).ready(function() {
    $("#form3").submit(function(event) {
        var formData ={
            principal: $("#principal").val(),
            interestRateInPercentage: $("#interestRateInPercentage").val(),
            loanDurationInYearCount: $("#loanDurationInYearCount").val(),
        };
    
        $.ajax({
            type: "POST",
            url: "https://localhost:7281/api/emi/calculatecontinousemi",
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







