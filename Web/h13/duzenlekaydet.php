<?php
require_once('dbconfig.php');

print_r($_POST);

$komut = 
$baglanti
->prepare("update ogrenciler set 
            adi_soyadi = ? , bolum= ?, burs = ? where id = ?");
$sonuc = $komut->execute( [
                $_POST['adi'], 
                $_POST['bolum'], 
                $_POST['burs'], 
                $_POST['id'] 
            ]);
echo $sonuc;
header("Location: index.php");
