<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP Upload Result Page</title>
</head>
<body>
    <?php  
        $file = $_FILES["fileToUpload"];
        var_dump($file);

        $uploadFolder = "uploads/";
        //$filename=$file["name"]; //if user upload with same name of different files. it overrides.
        $filename= uniqid() . "-" . $file["name"];
        $fileTempName= $file["tmp_name"];
        $extension = pathinfo($filename, PATHINFO_EXTENSION);

        if($extension == "png"  || $extension == "jpg") {
            $result = move_uploaded_file($fileTempName, $uploadFolder . $filename);
            if($result) {
                echo "File uploaded successfully";
            } else {
                echo "Error";
            }
        } else {
            echo "You can only upload png and jpg files";
        }
    ?>
</body>
</html>