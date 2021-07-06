
using UnityEngine;
using System.IO; // Giri� C�k��lar� yapabildi�imiz bu NAMESPACE'i DAH�L ETT�K ! ! !
using System.Runtime.Serialization.Formatters.Binary; // Binary format�yla biz verileri KAYDETCEZ.



public  static  class SaveSystem  // SaveSystem S�n�f� Monobehaviour 'dan alm�cak o y�zden sildik Monobehaviour'u ve bu Class'� Static Yapt�k ki DI�ARIDAN ER��EB�LEY�M ! ! !
{

    #region A�IKLAMA 

    /*     
        Mika = 056 817 66 Binary( bit ) NameSpace'i verileri bu gibi  say�sal degerle  ��FRELER. //  .bin uzant�l� dosyaya bu verileri   KAYDEDER.
        45 = 1234 1101 1201

    */

    #endregion


    public static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream("player.bin",FileMode.Create);

        /* FileStream dosya i�lemini ba�latmaya yarar ! ! ! �lk yazd���m�z veri dosyam�z�n ADI = Player.bin olsun dedik.
                                                         
         FileMode : Dosyay� N���N �a��rmak istedi�imizi s�ylemi� oluyoruz. Create '� se�tik ��nk� dosyay� �nce olu�turmam�z gerekiyor.

         �imdi Bu 2 kod sat�r�n� birle�tirerek VER�Y� yazmam gerekiyor.Yani ��yle : 

        */

        formatter.Serialize(stream, Verilerimiz.puan);
        // Serialize =  VEriyi Binary format�nda �uraya KAYDET DEMEKT�R.
        // �nce kaydedecek oldu�u dosyan�n ismini verdik  ve daha sonra bizden kaydetmek istedi�i veriyi girdik.

        formatter.Serialize(stream, Verilerimiz.ad);

        stream.Close(); // Dosyaya veriyi ekledikten sonra KAPATTIK.��nk� kapatmakta fayda var.
        

    }



    public static void LoadPlayer()
    {

        string dosyaadi = "player.bin";

        if(File.Exists(dosyaadi)) // Exists : Bu dosya var m� yok mu onun kontrol�n� yapar.
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(dosyaadi, FileMode.Open); // Veriyi A�TIK.

            Verilerimiz.puan =  ( int ) formatter.Deserialize(stream); //  Deserialize : Veriyi OKUDUK. Object t�r�n� int t�r�ne �eviremezdi bizde o y�zden ( int ) yazd�k ! 

            Verilerimiz.ad = (string)formatter.Deserialize(stream);

            stream.Close();
        }

        else
        {
            Debug.Log("DOSYA YOK ! ! !");
        }


    }

// �NEML� NOT : Unity taraf�nda bu olu�turmu� oldugumuz dosyay� g�remezsin Assets => Sa� t�kla => Show in Explorer'a t�kla BURDA player.bin dosyas�n�  g�rebilirsin ! ! ! !!

}
