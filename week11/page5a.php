<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>

    <script type="text/javascript">
        function checkNumber(){
            var txtNumber = document.getElementById("txtNumber");
            
            if(txtNumber.value == "") {
                return false;
            } else {
                return true;
            }
            //shortcut of if block above
            return !(txtNumber.value == "");
        }
    </script>
</head>
<body>
    <form method="GET" action="page5b.php" onsubmit="return checkNumber();">
        <label for="txtNumber"> Enter a number: </label>
        <input type="number" name="txtNumber" id="txtNumber" value="5"/>
        <input type="submit" value="Send" />
    </form>
</body>
</html>