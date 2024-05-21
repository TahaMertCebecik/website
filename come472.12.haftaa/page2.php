<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>File Upload</h1>
    <form action ="page2b.php" method="post " enctype="multipart/form-data">
        <label for = "fileToUpload">Select a file to upload</label>
        <input type="file" name= "fileToUpload" id="fileToUpload"/>
        <input type="submit" value= "Upload File" name=submit />
</form>
</body>
</html>