<?php
require_once('dbconfig.php');

$komut = $baglanti->prepare("INSERT INTO ogrenciler (adi_soyadi, bolum, burs) values (?,?,?)");
$sonuc = $komut->execute([$_POST['adi'], $_POST['bolum'], $_POST['burs'] ]);

echo $sonuc;

header("Location: index.php");
