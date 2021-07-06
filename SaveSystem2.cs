using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class SaveSystem2: MonoBehaviour
{
  
    public static void SavePlayer2(Player2 player2)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream("player2.bin", FileMode.Create);

        PlayerData data = new PlayerData(player2,false);
        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static PlayerData LoadPlayer2(Player2 player2)
    {
        string dosyaAdi = "player2.bin";


        if (!File.Exists(dosyaAdi)) // Oyun a��l�r a��lmaz player2.bin  olu�turmam�z� sa�lad�.
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("player2.bin", FileMode.Create);

            PlayerData data = new PlayerData(player2, true);
            formatter.Serialize(stream, data);

            stream.Close();
        }




        if (File.Exists(dosyaAdi))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(dosyaAdi, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data; // ��z�lm�� olan de�erleri D�ND�RM�� OLDUK ! ! !

        }

        else
        {
            Debug.LogError("DOSYA YOK ! ");
            return null;
        }
    }
  
}
