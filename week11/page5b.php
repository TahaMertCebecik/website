<?php 
    $num = intval($_GET["txtNumber"]);
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<h1>Your Courses</h1>
<form method="POST" action="page5c.php"> 
    <input type="hidden" name="txtNumber" id="txtNumber" value="<?php echo $num; ?>"/>
    <table>
        <thead>
            <tr>
                <th>#</th>
                <th>Name</th>
                <th>Grade</th>
            </tr>
        </thead>
        <tbody>
            <?php 
                    for($i=1; $i <= $num; $i++) {
                ?>
            <tr>
                <td><?=$i?></td>
                <td><input type="text" name="txtCourse<?=$i?>name" id="txtCourse<?=$i?>name"></td>
                <td><input type="number" name="txtCourse<?=$i?>grade" id="txtCourse<?=$i?>grade"></td>
            </tr>
            <?php 
                    }
                ?>
        </tbody>
        <tfoot>
                <tr>
                    <td colspan="3"><input type="submit" value="Send Form" /></td>
                </tr>
            </tfoot>
</table>


</form>
</body>
</html>