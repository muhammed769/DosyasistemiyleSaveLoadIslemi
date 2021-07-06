using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // Bu script dosyas�n� sistemde rahat�a dola�t�rabilecek  yeniden kontrol edilebilecek �ekilde SER�LE�T�RECEK.
                      // SER�LE�T�RME : Veri yap�lar�n� veya  nesne durumlar�n� Unity'nin  daha sonra DEPOLAYAB�LECE�� VE YEN�DEN YAPILANDIRAB�LECE�� B�R D�N��T�RME �EKL�D�R ! ! ! ! ! ! 

                      //  SER�LE�T�RMEM�Z�N  bir di�er nedeni bu script herhangi bir objeye ba�l� OLMADI�I ���N sistemde dola�abilmesi i�in SER�LE�T�RMEM�Z GEREK�R ! !  ! ! ! ! ! ! !
public class PlayerData 
{
    // �NEML� A�IKLAMA MUTLAKA OKU : Player2 Scriptinden  puan ve ad de�erleri ANLIK bir �ekilde alarak SaveSystem2 Script'iyle beraber paralel bir �ekilde �ALI�AB�LMES�N�
    //                               sa�l�caz.


    public int puan;
    public string ad;


    public PlayerData (Player2 player2,bool ilkmi) // Player2 Script dosyas�ndan gelen de�erleri buraya al�nmas�n� bu metotla SA�LADIK ! ! ! ! ! YAN� �NEML� ! ! ! ! ! 
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
