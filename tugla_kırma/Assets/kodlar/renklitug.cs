using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renklitug : MonoBehaviour
{
    [SerializeField]
    private Sprite kirikresim;

    int vurus = 0;
    gamemager Gamenager;
    private void Awake()
    {
        Gamenager = Object.FindObjectOfType<gamemager>();
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag=="top")
        {
            vurus++;
            if(vurus==1)
            {
                GetComponent<SpriteRenderer>().sprite = kirikresim;

            }
            else if(vurus==2)
            {
                Destroy(gameObject);
                Gamenager.skorguncel(2);
            }
           
        }
    }
}
