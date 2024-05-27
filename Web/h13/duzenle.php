<?php
require_once('dbconfig.php');
$gelenId = $_GET["id"];

$sorgu = $baglanti->prepare("SELECT * FROM ogrenciler where id = ?");
$sorgu->execute([  $gelenId ]);
$sonuc = $sorgu->fetch(PDO::FETCH_ASSOC);

print_r($sonuc);


?>

<form method="POST" action="duzenlekaydet.php">    
<input  type="hidden" name="id" value="<?=$sonuc["id"]?>">
Adı Soyadı: <input type="text" name="adi" value="<?=$sonuc["adi_soyadi"]?>"> <br>
Bölüm: <input type="text"  name="bolum" value="<?=$sonuc["bolum"]?>" ><br>
Burs: <input type="number"  name="burs"  value="<?=$sonuc["burs"]?>"><br>
<button type="submit">Kaydet</button>

</form>