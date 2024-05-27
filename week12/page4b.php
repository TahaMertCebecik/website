<?php
    session_start();

?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP Session</title>
</head>
<body>


    <?php
        if(isset($_SESSION["favourite_color"])){
            $color =  $_SESSION["favourite_color"];
        } else {
            $color = "<b>not specified</b>";
        }

        echo "Your favourite color is $color";
    ?>
</body>
</html>