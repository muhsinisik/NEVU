<?php

$kullaniciadi = $_POST["username"];
$sifre = $_POST["password"];

if ($kullaniciadi == "admin" && $sifre == "123"){
    setcookie("oturum", "TAMAM",time()+60);
    header("Location: hesabim.php");
} else {
    echo "Kullanıcı bilgileri yanlış";
}