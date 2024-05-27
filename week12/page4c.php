<?php
    session_start();

    //first way
    $_SESSION["favourite_color"] = null;

    //secondway
    session_unset();
    session_destroy();


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
    Remove the session variable
</body>
</html>