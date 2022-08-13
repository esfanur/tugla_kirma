using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class topkont : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float zaman = 450f;
    [SerializeField]
    bool oyuniçi;
    gamemager Gamemanager;//menager kýsmýndan lives cekmek ýcýn ekledýk

     public Transform baslamayer;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Gamemanager = Object.FindObjectOfType<gamemager>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Gamemanager.gameover)
        {
            return;
        }
        if(!oyuniçi)
        {
            transform.position = baslamayer.position;
        }
        if(Input.GetButtonDown("Jump") && !oyuniçi)
        {
            oyuniçi = true;
            rb.AddForce(Vector2.up * zaman);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.name=="alt")
        {
            rb.velocity = Vector2.zero; //hýzýný kestýk
            Gamemanager.guncekle(-1);
            oyuniçi = false;
        }
    }
}
