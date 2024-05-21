<?php

$fp = fopen ("page1b.txt","w") or die ("The File cannot be opened");
fwrite ($fp, "What time is it?");

fwrite ($fp ,"\n". date("y-m-d H:i" ,time() )) ;



$fp = fopen ("page2.txt","r") or die ("The File cannot be opened");
$content = fread($fp,filesize("page2.txt"));
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
    <?="Content is:\n". $content ?>
</body>
</html>