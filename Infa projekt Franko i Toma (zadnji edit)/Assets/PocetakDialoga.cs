using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocetakDialoga : MonoBehaviour
{
    //public Animator animator;
    public GameObject Dijalogbox;
    public GameObject tekst;
    
    private bool Prica=false;
    private void Start()
    {
        //animator.SetBool("IsOpen", false);
        Dijalogbox.SetActive(false);
        Prica = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Prica = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(Prica == true)
        {
            //animator.SetBool("IsOpen", true);
            Dijalogbox.SetActive(true);
            tekst.SetActive(true);


        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //animator.SetBool("IsOpen", false);
        Dijalogbox.SetActive(false);
        Prica = false;
    }
}
