<?php
$servername = "localhost";
$database = "aleksax0_pytn";
$username = "aleksax0_pytn";
$password = "Zra3&wbZQBFXU8Z";
// Create connection
$conn = mysqli_connect($servername, $username, $password, $database);
// Check connection
if (!$conn)
{
die("Connection failed: " . mysqli_connect_error());
}
$login = $_POST['login'];
$points = $_POST['points'];
// = "SELECT `ID` FROM `Players` WHERE `Name` = '$login'";
//$result = mysqli_query($conn, $id) or die("Error " . mysqli_error($conn)); 
//if($result)

  //  echo $row = mysqli_fetch_row($result);

//$sql = "SELECT `ID` FROM `Players` WHERE `Name` = '$login' ";
//$id = mysqli_stmt_fetch($sql);

    //$conn->query("INSERT INTO Games (Player_ID, Points) VALUES([SELECT ID FROM Players WHERE Name = '$login'], '$points') ");
//$result = $mysql->query("INSERT INTO Players (Name, Password) VALUES ('$name','$password')");
//$res=mysqli_query($conn);
//if($res){echo "Post added";}
//else{echo"Error";}

$query = "INSERT INTO Games (Player_ID, Points) VALUES ((SELECT ID FROM Players WHERE Name='$login'), '$points')";
$res = mysqli_query($conn, $query);
if($res){echo "Post added";}
else{echo"Error";}

mysqli_close($conn);
?>