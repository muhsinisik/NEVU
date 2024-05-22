<?
// sayısal $ay değişkeninin değerine göre ayın bulunduğu mevsimi ekrana yazan program
// 1-> Kış   8->Yaz  switch ile

    if ($ay == 12 || $ay == 1 || $ay == 2){
        echo "Kış"; 
    }

    $ay = 0;
    switch ($ay) {
        case 12:
        case 1: 
        case 2: echo "Kış";  break;

        case 3: 
        case 4: 
        case 5: echo "İlkbahar";  break;

        case 6: 
        case 7: 
        case 8: echo "Yaz";  break;

        case 9: 
        case 10: 
        case 11: echo "Sonbahar";  break;
        
        
    }