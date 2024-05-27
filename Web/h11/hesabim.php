<?php
if (isset($_COOKIE["oturum"])) {
    if ($_COOKIE["oturum"] == "TAMAM") {
        echo "Kişiye özel sayfa";
    ?>
        <a href="logout.php">Oturumu Kapat</a>
    <?php
    } else {
        echo "Cookie var ama içeriği yanlış. Login olması gerekir.";   
    }
    ?>

<?php
} else {
    echo "Bu sayfayı görmeye yetkiniz yok.";
?>
    <a href="login.php">Oturum Aç</a>
<?php
}
?>