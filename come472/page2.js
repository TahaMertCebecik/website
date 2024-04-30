//alert("js is working");


function validateFormInput(){
    var txtNumber = document.getElementById("txtNumber");
    console.log({"1" : txtNumber});
    if (txtNumber == null || txtNumber.value == "") {
        return false;
    }


    if (isNaN(txtNumber.value)) {
        return false;
    }


    console.log({"2" : txtNumber});
    return true;


}




function checkNumber() {
    var txtNumber = document.getElementById("txtNumber");
    var divMessage = document.getElementById("divMessage");


    if (txtNumber.value == 0) {
        divMessage.innerText = "The value is 0";
        return false;
    }


    if (txtNumber.value == 15) {
        divMessage.innerText = "The value is 15";
        return false;
    }


    if (txtNumber.value == 7) {
        divMessage.innerText = "The value is 7 so we can send the form";
        return true;
    }


    else {
        divMessage.innerText = "Can not send the form"
        return false;
    }
}