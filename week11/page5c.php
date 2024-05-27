<?php
    $num = intval($_POST["txtNumber"]);

    $total = 0;
    $average = 0;

    for($i=1; $i <= $num; $i++) {
        $total += intval($_POST["txtCourse".$i."grade"]);
    }

    $average = number_format( $total / $num, 0);

    ?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<h1>Result Page</h1>
<?php
    for($i=1; $i <= $num; $i++){
        $course1 = htmlentities( $_POST["txtCourse".$i."name"]);
        $grade1 = intval( $_POST["txtCourse".$i."grade"]);

        echo "<p>$i - $course1 -> $grade1 </p>";
    }

    ?>
    <p>You have taken <?=$num?> courses and the average grade is <?= $average?>.</p>
    
</body>
</html>