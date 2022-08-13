using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cantopu : MonoBehaviour
{
    public float zaman;
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * zaman);
    }
}
