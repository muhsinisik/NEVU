<form action="h6-02.php" method="POST" >
    Adınız &nbsp;Soyadınız:
    <input type="text" name="isim" />  
    <br />
    <select name="sehir">
        <option value="01">Adana</option>
        <option value="50">Nevşehir</option>
        <option value="38">Kayseri</option>
    </select>
    <br>


    Sayı 1: <input type="input" name="s1"><br>
    Sayı 2: <input type="input" name="s2"><br>

    <input type="submit" value="Kaydet" />
    <input type="button" value="Formu submit etmez" />
    <input type="reset" value="Temizle" />

    <!-- <button>Kaydet</button> -->

</form>
<hr>
<a href="h6-03.php?s=1">Adana</a><br>
<a href="h6-03.php?s=50">Nevşehir</a><br>
