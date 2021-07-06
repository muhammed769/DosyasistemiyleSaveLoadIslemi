using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // Bu script dosyasýný sistemde rahatça dolaþtýrabilecek  yeniden kontrol edilebilecek þekilde SERÝLEÞTÝRECEK.
                      // SERÝLEÞTÝRME : Veri yapýlarýný veya  nesne durumlarýný Unity'nin  daha sonra DEPOLAYABÝLECEÐÝ VE YENÝDEN YAPILANDIRABÝLECEÐÝ BÝR DÖNÜÞTÜRME ÞEKLÝDÝR ! ! ! ! ! ! 

                      //  SERÝLEÞTÝRMEMÝZÝN  bir diðer nedeni bu script herhangi bir objeye baðlý OLMADIÐI ÝÇÝN sistemde dolaþabilmesi için SERÝLEÞTÝRMEMÝZ GEREKÝR ! !  ! ! ! ! ! ! !
public class PlayerData 
{
    // ÖNEMLÝ AÇIKLAMA MUTLAKA OKU : Player2 Scriptinden  puan ve ad deðerleri ANLIK bir þekilde alarak SaveSystem2 Script'iyle beraber paralel bir þekilde ÇALIÞABÝLMESÝNÝ
    //                               saðlýcaz.


    public int puan;
    public string ad;


    public PlayerData (Player2 player2,bool ilkmi) // Player2 Script dosyasýndan gelen deðerleri buraya alýnmasýný bu metotla SAÐLADIK ! ! ! ! ! YANÝ ÖNEMLÝ ! ! ! ! ! 
    {

        if (ilkmi)
        {
            puan = 0;
            ad = "---";
        }
        else
        {
            puan = player2.puan;
            ad = player2.ad;
        }
      

    }
}
