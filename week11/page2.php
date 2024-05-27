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
//error_reporting(E_ERROR | E_PARSE);

$x = 5; // global scope
$p = 8; // global scope
function myTest() {
    global $p;
    static $m=122;
    
   $m++;
   $y = 10;
   // $x is undefined. there will be a warning.
   echo "<p>Variable x,y,m inside function is: $x , $y, $m</p>"; 
}

myTest();
myTest();
echo "<p>Variable x outside function is: $x</p>";

print_r($p);
echo "<br>";
var_dump   ($p);
   ?>

</body>
</html>l