<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

<?php
require_once('dbconfig.php');
$sorgu = $baglanti->prepare("select * from ogrenciler");
$sorgu->execute();
$sonuc = $sorgu->fetchAll(PDO::FETCH_ASSOC);


//print_r($sonuc);

foreach ($sonuc as $row){
     echo $row["adi_soyadi"]."   Bölüm: ".$row["bolum"]. "<br>";
 }
?>


 <a href="yeni.php" class="btn btn-primary">Yeni Öğrenci Ekle</a>

 <table class="table table-striped table-hover">
    <tr>
        <th>Id</th>
        <th>Adı Soyadı</th>
        <th>Bölüm</th>
        <th>Burs</th>
        <th>İşlem</th>
    </tr>
<?php
    foreach ($sonuc as $ogrenci){        
?>
    <tr>
        <td> <?php echo $ogrenci["id"] ?> </td>
        <td> <?=$ogrenci["adi_soyadi"] ?> </td>
        <td> <?=$ogrenci["bolum"] ?></td>
        <td> <?=$ogrenci["burs"] ?></td>
        <td>   <a href="sil.php?id=<?=$ogrenci["id"]?>">Sil</a> - 
               <a href="duzenle.php?id=<?=$ogrenci["id"]?>">Düzenle</a>   
    
    </td>
    </tr>
<?php
    }
?>
 </table>


 <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
