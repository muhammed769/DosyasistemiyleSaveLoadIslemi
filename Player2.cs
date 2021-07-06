using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player2 : MonoBehaviour // A�IKLAMA : Bu Script'tede  OKUMA ��LEM�N� yap�caz.
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
        Load(); // Kaydettikten sonra hemen datay�  ekranda okumak i�in.
    }

    public void Load()
    {
        // Oyun ilk a��ld���nda buras� hata verir. ��nk� dosya olmayaca�� i�in okuma i�lemide olmaz.

        PlayerData data = SaveSystem2.LoadPlayer2(this);

        puanText.text = data.puan.ToString();
        adText.text = data.ad;

        puan = data.puan;
        ad = data.ad;
      
    }
    
}
