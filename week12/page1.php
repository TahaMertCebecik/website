<?php
/*
    $fp = fopen ("page1.txt","r") or die("The file cannot be opened");
    $content = fread($fp, filesize("page1.txt"));
    
    $fp = fopen ("page1b.txt","w") or die("The file cannot be opened");
    fwrite($fp, "your cannot write this in read mode ");
    fclose($fp);
*/

$fp = fopen ("page1b.txt","w") or die("The file cannot be opened");
fwrite ($fp, "What time is it?");
fwrite ($fp, "\n". date("Y-m-d H:i", time()) );
//date("y-m-d H:i, time()) returns the server time
fclose($fp);

$fp = fopen ("page1data.txt","r") or die("The file cannot be opened");
$content = fread($fp, filesize("page1data.txt"));
fclose($fp);
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP File Operations</title>
</head>
<body>
    <?= "Content is: \n" . $content ?>
</body>
</html>