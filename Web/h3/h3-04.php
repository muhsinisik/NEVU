<?php
 //$gun değişkenindeki sayısal değere göre ekrana 
 //haftanın hangi günü olduğunu yazan kodları yazın
        $gun = 1;
        switch ($gun) {
            case 1: 
                    echo "Pazartesi"; 
                    echo "Haftanın ilk günü";  
                break;
            case 2: echo "Salı"; break;
            case 3: echo "Çar"; break;
            case 4: echo "Per"; break;
            case 5: echo "Cum"; break;
            case 6: echo "Cmt"; break;
            case 7: echo "Pazar"; break;
            default: echo "Hatalı sayı"; break;
        }
 
 
 
    

    // if ($gun == 1){echo "Pazartesi" ;}
    // else if ($gun == 2){echo "Salı" ;}
    // else if ($gun == 3){echo "Çarşamba" ;}
    // else if ($gun == 4){echo "Perşembe" ;}
    // else if ($gun == 5){echo "Cuma" ;}
    // else if ($gun == 6){echo "Cumartesi" ;}
    // else if ($gun == 7){echo "Pazar" ;}
    // else {echo "Hatalı değer" ;}


