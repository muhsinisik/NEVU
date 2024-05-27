<?php
    session_start();
    if (isset($_SESSION["adisoyadi"])){
        echo "Hoşgeldin ".$_SESSION["adisoyadi"];
    } else {
        echo "Hoşgeldin misafir.";
    }
?>