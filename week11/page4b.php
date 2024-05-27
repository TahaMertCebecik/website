<?php
    $num = intval($_POST["txtNumber"]); //third secure way
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document B</title>
</head>
<body>
<p> You have entered value <?php echo $num; ?> . </p>
<p> You have entered value <?= $num; ?> . </p>

<?php
        for($i=1; $i<=$num ; $i++){
            echo "<img src='https://picsum.photos/seed/$i/200/300' alt='Random Image $i' />\n";
        }
        ?>
</body>
</html>