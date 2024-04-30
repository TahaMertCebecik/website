
// page3.js
function display() {
    var txtText = document.getElementById("txtText").value;
    var txtNumber = document.getElementById("txtNumber").value;
    var divMessage = document.getElementById("divMessage");

    if (txtText === "") {
      txtText = "Text";
    }
  
    divMessage.innerText = "";
  
    for (let i = 0; i < txtNumber; i++) {
      divMessage.innerText += "The value is : " + txtText + "\n";
    }
    return false;
  }