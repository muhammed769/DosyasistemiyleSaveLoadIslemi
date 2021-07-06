using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player2 : MonoBehaviour // AÇIKLAMA : Bu Script'tede  OKUMA ÝÞLEMÝNÝ yapýcaz.
{
    public int puan;
    public string ad;

    //public InputField GelenPuanDegeri;
    //public InputField GelenAdDegeri;

    public TextMeshProUGUI puanText;
    public TextMeshProUGUI adText;

    void Start()
    {
        Load();
    }


    public void Save()
    {
        SaveSystem2.SavePlayer2(this);
        Load(); // Kaydettikten sonra hemen datayý  ekranda okumak için.
    }

    public void Load()
    {
        // Oyun ilk açýldýðýnda burasý hata verir. Çünkü dosya olmayacaðý için okuma iþlemide olmaz.

        PlayerData data = SaveSystem2.LoadPlayer2(this);

        puanText.text = data.puan.ToString();
        adText.text = data.ad;

        puan = data.puan;
        ad = data.ad;
      
    }
    
}
