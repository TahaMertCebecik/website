<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Php upload result page</title>
</head>
<body>
    <?php
      $file =$_FILES["fileToUpload"];
      var_dump($file);

      $uploadFolder = "uploads/";
      $filename = "";
      $fileTempName=$file["tmp_name"];
      $extension=pathinfo($filename,PATHINFO_EXTENSION);

      if($extension =="png"){
        $result = move_uploaded_file($fileTempName,$uploadFolder.$filename);
      if($result){
        echo "File uploaded successfully";

      }else{
        echo"you can only upload png files";
      }
      }

      $result = move_uploaded_file($fileTempName,$uploadFolder.$filename);
      if($result){
        echo "File uploaded successfully";

      }else{
        echo"Error";
      }

    ?>
</body>
</html>