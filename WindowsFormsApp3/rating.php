<?php

$servername = "localhost";
$database = "aleksax0_pytn";
$username = "aleksax0_pytn";
$password = "Zra3&wbZQBFXU8Z";
// Create connection
$conn = mysqli_connect($servername, $username, $password, $database);

 
$sql = "SELECT Players.Name, Games.Points FROM Players, Games WHERE Games.Player_ID = Players.ID ORDER BY Points ASC LIMIT 0, 10";
$result = mysqli_query($conn, $sql) or die("Error " . mysqli_error($conn)); 
if($result)
{
    $rows = mysqli_num_rows($result); // количество полученных строк
     //echo "<table><tr><th>Player</th><th>Points</th><th>";
    echo "Player    Points";
    for ($i = 0 ; $i < $rows ; ++$i)
    {
        $row = mysqli_fetch_row($result);
        echo "\n";
            for ($j = 0 ; $j < 3 ; ++$j) echo "$row[$j]  ";
        echo " ";
    }
    echo " ";
     
}



mysqli_close($conn);
?>