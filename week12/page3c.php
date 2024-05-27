<?php
    $cookieName= "fullname";
    $cookieValue= "Zahid Gürbüz";

    //to clear the cookie, set the expire date to a previous date
    setcookie($cookieName, $cookieValue, time() -1 , "/"); //1 seconds before
    
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        if(isset($_COOKIE[$cookieName])) {
            echo "Cookie '$cookieName' is set <br>";
            echo "value is : $cookieValue";
        } else {
            echo "Cookie '$cookieName' is not set <br>";
        }
    ?>
</body>
</html>