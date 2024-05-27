<?php
require_once('dbconfig.php');
$gelenId = $_GET["id"];

$sorgu = $baglanti->prepare('delete from ogrenciler where id = ?');
$sorgu->execute([$gelenId]);

echo "Silindi";

header("Location: index.php");

?>

<a href="index.php">Listeye dön</a>