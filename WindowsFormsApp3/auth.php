<?php

$servername = "localhost";
$database = "aleksax0_pytn";
$username = "aleksax0_pytn";
$password = "Zra3&wbZQBFXU8Z";
// Create connection
$conn = mysqli_connect($servername, $username, $password, $database);
if(empty($_POST['login']) && empty($_POST['pass'])){echo"Enter player`s name and password";}
else{
if(empty($_POST['login'])){echo"Enter player`s name";}
elseif(empty($_POST['pass'])){echo"Enter password";}
else{
// = $_POST['login'];
//$pass = $_POST['pass'];
//$pass = md5($pass."awgjvbx5336");
//$query = mysql_fetch_assoc(mysql_query("SELECT * FROM `Players` WHERE `Name` = '".$_POST['login']."' AND `Password`= '".md5($_POST['pass']."awgjvbx5336")."' "));
//$data = $result->fetch_assoc();
//if($data['Players.Password'] == md5(md5($pass)))
//{
//    $hash = md5(generateCode(10));}
//setcookie('Player', $data['Player.Name'], time() +3600*24*30, "/") ;   
//$res=mysqli_fetch_array($result);
$login = $_POST['login'];
$pass = $_POST['pass'];
$pass = md5($pass."awgjvbx5336");
$query = "SELECT * FROM `Players` WHERE `Name` = '$login' AND `Password`='$pass' ";
$id = "SELECT ID FROM `Players` WHERE `Name` = '$login' AND `Password`='$pass'";
$result = mysqli_query($conn, $query) or die(mysqli_error($conn));
$count = mysqli_num_rows($result);
if($count == 1)
{
    //session_start();
    //$_SESSION['id'] = '$id';
    //setcookie('id', $id, time()+3600*24*30, "/" );
}
else{echo "Not Found. Such player doesn`t exist";}
}
}
mysqli_close($conn);
?>