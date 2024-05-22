<?php

$server = "localhost";
$dbname = "ubys";
$user  = "root";
$pass = "";


try {
    $baglanti = new PDO("mysql:host=$server;dbname=$dbname", $user, $pass);
    //echo "Bağlandı" ;
} catch (PDOException $pe) {
    echo "Bağlantı hatası". $pe;
}

?>