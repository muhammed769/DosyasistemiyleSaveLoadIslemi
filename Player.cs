using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // TextMeshPro'yu EKLEDÝK.
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public InputField GelenPuanDegeri;
    public InputField GelenAdDegeri;
    public TextMeshProUGUI PuanText;
    public TextMeshProUGUI AdText;



    void Start()
    {
        Load();
    }


    public void Save()
    {
        Verilerimiz.puan = int.Parse(GelenPuanDegeri.text);
        Verilerimiz.ad = GelenAdDegeri.text;

        SaveSystem.SavePlayer();

    }


    public void Load()
    {
        SaveSystem.LoadPlayer();
        PuanText.text = Verilerimiz.puan.ToString();
        AdText.text = Verilerimiz.ad;


    }
}
