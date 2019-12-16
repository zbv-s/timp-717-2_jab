<?php

//if (isset($_POST['textBoxLog.Text']) && isset($_POST['textBoxPass.Text'])){
$servername = "localhost";
$database = "aleksax0_pytn";
$username = "aleksax0_pytn";
$password = "Zra3&wbZQBFXU8Z";
// Create connection
$conn = mysqli_connect($servername, $username, $password, $database);

$login = $_POST['login'];
$pass = $_POST['pass'];
$pass = md5($pass."awgjvbx5336");
if(empty($_POST['login']) && empty($_POST['pass'])){echo"Enter player`s name and password";}
else{
if(empty($_POST['login'])){echo"Enter player`s name";}
elseif(empty($_POST['pass'])){echo"Enter password";}
else{
$query = "SELECT `Name` FROM `Players` WHERE `Name` = '$login' ";
$result = mysqli_query($conn, $query) or die(mysqli_error($conn));
$count = mysqli_num_rows($result);
if($count != 1)
{
    $conn->query("INSERT INTO `Players` (`Name`, `Password`) VALUES('$login', '$pass') ");
//$result = $mysql->query("INSERT INTO Players (Name, Password) VALUES ('$name','$password')");
$result=mysqli_query($conn);
if($result){echo "Error";}
else{echo"Account successfully created";}
}
else{echo "Such player already exists";}
}
}


//if($result == true){echo "New record created successfully";
//} else {
  //   echo "Error ";}

//if (mysqli_query($conn, $sql)) {
  //    echo "New record created successfully";
//} else {
  //    echo "Error: " . $sql . "<br>" . mysqli_error($conn);
//}
//}
mysqli_close($conn);
?>