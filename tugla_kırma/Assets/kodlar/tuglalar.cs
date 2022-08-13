using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuglalar : MonoBehaviour
{
    gamemager Gamenager;
   public  GameObject canball;
    private void Awake()
    {
        Gamenager = Object.FindObjectOfType<gamemager>();
    }
    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag=="top")
        {
            Gamenager.skorguncel(1);
            int rasgelecan = Random.Range(1, 100);
            if(rasgelecan>70)
            {
                Instantiate(canball, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }
}
