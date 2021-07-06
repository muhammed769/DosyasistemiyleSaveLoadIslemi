
using UnityEngine;
using System.IO; // Giriþ Cýkýþlarý yapabildiðimiz bu NAMESPACE'i DAHÝL ETTÝK ! ! !
using System.Runtime.Serialization.Formatters.Binary; // Binary formatýyla biz verileri KAYDETCEZ.



public  static  class SaveSystem  // SaveSystem Sýnýfý Monobehaviour 'dan almýcak o yüzden sildik Monobehaviour'u ve bu Class'ý Static Yaptýk ki DIÞARIDAN ERÝÞEBÝLEYÝM ! ! !
{

    #region AÇIKLAMA 

    /*     
        Mika = 056 817 66 Binary( bit ) NameSpace'i verileri bu gibi  sayýsal degerle  ÞÝFRELER. //  .bin uzantýlý dosyaya bu verileri   KAYDEDER.
        45 = 1234 1101 1201

    */

    #endregion


    public static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream("player.bin",FileMode.Create);

        /* FileStream dosya iþlemini baþlatmaya yarar ! ! ! Ýlk yazdýðýmýz veri dosyamýzýn ADI = Player.bin olsun dedik.
                                                         
         FileMode : Dosyayý NÝÇÝN çaðýrmak istediðimizi söylemiþ oluyoruz. Create 'ý seçtik çünkü dosyayý önce oluþturmamýz gerekiyor.

         Þimdi Bu 2 kod satýrýný birleþtirerek VERÝYÝ yazmam gerekiyor.Yani Þöyle : 

        */

        formatter.Serialize(stream, Verilerimiz.puan);
        // Serialize =  VEriyi Binary formatýnda þuraya KAYDET DEMEKTÝR.
        // Önce kaydedecek olduðu dosyanýn ismini verdik  ve daha sonra bizden kaydetmek istediði veriyi girdik.

        formatter.Serialize(stream, Verilerimiz.ad);

        stream.Close(); // Dosyaya veriyi ekledikten sonra KAPATTIK.Çünkü kapatmakta fayda var.
        

    }



    public static void LoadPlayer()
    {

        string dosyaadi = "player.bin";

        if(File.Exists(dosyaadi)) // Exists : Bu dosya var mý yok mu onun kontrolünü yapar.
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(dosyaadi, FileMode.Open); // Veriyi AÇTIK.

            Verilerimiz.puan =  ( int ) formatter.Deserialize(stream); //  Deserialize : Veriyi OKUDUK. Object türünü int türüne çeviremezdi bizde o yüzden ( int ) yazdýk ! 

            Verilerimiz.ad = (string)formatter.Deserialize(stream);

            stream.Close();
        }

        else
        {
            Debug.Log("DOSYA YOK ! ! !");
        }


    }

// ÖNEMLÝ NOT : Unity tarafýnda bu oluþturmuþ oldugumuz dosyayý göremezsin Assets => Sað týkla => Show in Explorer'a týkla BURDA player.bin dosyasýný  görebilirsin ! ! ! !!

}
