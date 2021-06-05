using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RazgovorSaOarousom : MonoBehaviour
{
    public GameObject txtBox;
    public GameObject slika;
    public GameObject Opcija1;
    public GameObject Opcija2;
    public GameObject Opcija3;
    public GameObject Opcija4;
    public GameObject Opcija5;
    int brojacIzbora = 0;

    private void Start()
    {
        slika.SetActive(true);
        txtBox.SetActive(true);
        txtBox.GetComponent<Text>().text = "Oarous: Ja sam Oarous. Sto hoces beznacajna gnjido?";

    }

    public void MogucaOpcija1()
    {
        txtBox.GetComponent<Text>().text = "Zasto bi to ucinio. Oni nisu napravili hrane za moje orlove!?";
        brojacIzbora = 1;
    }
    public void MogucaOpcija2()
    {
        txtBox.GetComponent<Text>().text = "Oarous: Ha HA HAHAHAHA aha. To bi voljeo vidjeti.";
        brojacIzbora = 2;
    }
    public void MogucaOpcija3()
    {
        txtBox.GetComponent<Text>().text = "Oarous: Hvala ti na informaciji. Nikad nisam vjerovao tom prevarantu! Bit ce SANKCIJA!!!";
        brojacIzbora = 3;
    }
    public void MogucaOpcija4()
    {
        //pokrece se boss fight
        SceneManager.LoadScene("BossRoomCipus");
    }
    public void MogucaOpcija5()
    {
        SceneManager.LoadScene("Credits");
    }
    private void Update()
    {
        if (brojacIzbora == 1)
        {
            Opcija1.SetActive(false);
            Opcija2.SetActive(true);
            Opcija3.SetActive(true);
        }
        if (brojacIzbora == 2)
        {
            Opcija2.SetActive(false);
            Opcija3.SetActive(false);
            Opcija4.SetActive(true);
        }
        if (brojacIzbora == 3)
        {
            Opcija2.SetActive(false);
            Opcija3.SetActive(false);
            Opcija5.SetActive(true);
        }
    }
}
