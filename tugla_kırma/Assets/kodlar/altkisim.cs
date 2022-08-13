using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altkisim : MonoBehaviour
{
    [SerializeField]
    float hiz, solhiza, saghiza;
    gamemager Gamobject;
    private void Awake()
    {
        Gamobject = Object.FindObjectOfType<gamemager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Gamobject.gameover)
            return;
        float h = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * h *Time.deltaTime*hiz);
        
                if(transform.position.x<solhiza)
                {
                    transform.position = new Vector2(solhiza, transform.position.y);
                }

                if (transform.position.x > saghiza)
                {
                    transform.position = new Vector2(saghiza, transform.position.y);
                }
    }
    private void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag=="can")
        {
            Gamobject.guncekle(1);
            Destroy(temas.gameObject);
        }
    }
}
