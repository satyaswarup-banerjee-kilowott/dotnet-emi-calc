
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
            // encode: true,
             success: function(response) {
                 var myjson = JSON.stringify(response,null,4);
                 var x = window.open();
                 x.document.open();
                 x.document.write('<html><body><pre>'+ myjson + '</pre></body><html>');
                 x.document.close();
                 
                console.log(myjson);
             }
            
        })

        // fetch("https://localhost:7281/api/emi/calculatemonthlyemi")
        // .then(function(response){
        //     return response.json()
        // })
        // .then(function(data)
        // {
        //     appendData(data);
        // })
        // .catch(function(err)
        // {
        //     console.log(err);
        // });
        
        // // .done(function(data){
        //     console.log(data);
           
            
        // });

        
       
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







