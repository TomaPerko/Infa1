using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PocetakDijalogaGradonacelnik : MonoBehaviour
{
    public GameObject txtBox;
    public GameObject slika;
    public GameObject zadnji_botun;
    public GameObject Opcija1;
    public GameObject Opcija2;
    public GameObject Opcija3;
    public GameObject Opcija4;
    public GameObject Opcija5;
    public GameObject Opcija6;
    public GameObject Opcija7;
    public GameObject Opcija8;
    public GameObject Opcija9;
    public GameObject Opcija10;
    public GameObject Igrac;
    int brojacIzbora = 0;
    private void Start()
    {
        slika.SetActive(true);
        txtBox.SetActive(true);
        txtBox.GetComponent<Text>().text = "Gradonacelnik: Jesi li nas dosao spasiti ili donosis jos nevolja?";

    }
    public void MogucaOpcija1()
    {
        txtBox.GetComponent<Text>().text = "Bjezi iz mog grada nitkove!";
        brojacIzbora = 5;
        //da ti 10 dmga
        Igrac.GetComponent<PlayerHealth>().TakeDamage(10);
    }
    public void MogucaOpcija2a()
    {
        txtBox.GetComponent<Text>().text = "Gradonacelnik: Jesi li ubio ijednog orla?";
        brojacIzbora = 1;
    }
    public void MogucaOpcija3()
    {
        txtBox.GetComponent<Text>().text = "Gradonacelnik: Idiote! Sve si nas osudio na propast!";
        brojacIzbora = 6;
        //Daj 10 dmga.
        Igrac.GetComponent<PlayerHealth>().TakeDamage(10);

    }
    public void MogucaOpcija4()
    {
        txtBox.GetComponent<Text>().text = "Gradonacelnik: U redu. Onda moras nastaviti do dvorca Oarousa i objasniti mu da je za sve kriv Atrabus koji je potajno pojeo svu hranu za orlove. Onda ce nas postedjeti, a njega ce kazniti.";
        brojacIzbora = 2;
    }
    public void MogucaOpcija5()
    {
        txtBox.GetComponent<Text>().text = "Gradonacelnik: Hvala ti hrabi ratnice. Primi ovaj mali doprinos tvojoj opasnoj avanturi u znak zahvale.";
        brojacIzbora = 3;
        //da ti 10 hpa
        Igrac.GetComponent<PlayerHealth>().TakeDamage(-10);
    }
    public void MogucaOpcija6()
    {
        txtBox.GetComponent<Text>().text = "Gradonacelnik: U redu. Ne mogu te na to natjerati, ali nisi dobrodosao u mom gradu dok god branis Atrabusa!";
        brojacIzbora = 4;
    }
    public void MogucaOpcija7()
    {
        txtBox.SetActive(false);
        Opcija7.SetActive(false);
        slika.SetActive(false);
    }
    public void MogucaOpcija8()
    {
        txtBox.SetActive(false);
        Opcija8.SetActive(false);
        slika.SetActive(false);
    }
    void Update()
    {
        if (brojacIzbora == 1)
        {
            Opcija1.SetActive(false);
            Opcija2.SetActive(false);
            Opcija3.SetActive(true);
            Opcija4.SetActive(true);
        }
        if (brojacIzbora == 2)
        {
            Opcija3.SetActive(false);
            Opcija4.SetActive(false);
            Opcija5.SetActive(true);
            Opcija6.SetActive(true);
        }
        if (brojacIzbora == 3)
        {
            Opcija5.SetActive(false);
            Opcija6.SetActive(false);
            Opcija7.SetActive(true);
        }
        if (brojacIzbora == 4)
        {
            Opcija5.SetActive(false);
            Opcija6.SetActive(false);
            Opcija8.SetActive(true);
        }
        if (brojacIzbora == 5)
        {
            Opcija1.SetActive(false);
            Opcija2.SetActive(false);
            Opcija9.SetActive(true);
        }
        if (brojacIzbora == 6)
        {
            Opcija3.SetActive(false);
            Opcija4.SetActive(false);
            Opcija9.SetActive(true);
        }
    }
}
