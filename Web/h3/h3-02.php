<?php

    // trafik ışındaği renge göre ekrana
    // dur, geç, hazırlan yazan kodları yazınız.
    // ışın rengini tutan değişkenin değerini
    // IF bloğundan önce değiştirebiliriz

    $renk = "sarı";

    if ($renk == "kırmızı"){
        echo "Dur";
    } else if ($renk == "yeşil"){
        echo "Geç";
    } else if ($renk == "sarı") {
        echo "Hazırlan";
    } else {
        echo "Işık bozuk";
    }