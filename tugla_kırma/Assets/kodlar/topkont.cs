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
    bool oyuni�i;
    gamemager Gamemanager;//menager k�sm�ndan lives cekmek �c�n ekled�k

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
        if(!oyuni�i)
        {
            transform.position = baslamayer.position;
        }
        if(Input.GetButtonDown("Jump") && !oyuni�i)
        {
            oyuni�i = true;
            rb.AddForce(Vector2.up * zaman);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.name=="alt")
        {
            rb.velocity = Vector2.zero; //h�z�n� kest�k
            Gamemanager.guncekle(-1);
            oyuni�i = false;
        }
    }
}
