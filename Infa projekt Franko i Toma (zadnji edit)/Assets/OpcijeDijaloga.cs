using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpcijeDijaloga : MonoBehaviour
{
    public GameObject txtBox;
    public GameObject slika;
    public GameObject zadnji_botun;
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
        txtBox.GetComponent<Text>().text = "Atrabus: Bjezi nesretnice, jer pred tobom je veoma opasan put!";
        
    }
    public void MogucaOpcija1()
    {
        txtBox.GetComponent<Text>().text = "Atrabus: Bio sam sluga gospodara orlova Oarousa. Ponestalo je hrane za orlove. Orlovi su pobjegli trazeci hranu i sad teroriziraju nevine ljude a ja sam izbacen iz gospodareva dvorca.";
        brojacIzbora = 1;
    }
    public void MogucaOpcija2()
    {
        Application.Quit();
    }
    public void MogucaOpcija3()
    {
        txtBox.GetComponent<Text>().text = "Uistinu si hrabar ili si samo jako glup.";
        brojacIzbora = 2;
    }
    public void MogucaOpcija4()
    {
        txtBox.SetActive(false);
        Opcija5.SetActive(false);
        slika.SetActive(false);
        zadnji_botun.SetActive(false);
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
        }
    }
}
