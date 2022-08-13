using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class gamemager : MonoBehaviour
{
    public int lives;
    public int skor;
    public bool gameover;
    public GameObject oyunbpanel;
   

    public Text skorskor;
    public Text liveskor;
    private void Start()
    {
        liveskor.text = "LÝVES:" + lives.ToString();
        skorskor.text = "SKOR:" + skor.ToString();
        oyunbpanel.GetComponent<RectTransform>().localScale = Vector3.zero;
        oyunbpanel.GetComponent<CanvasGroup>().alpha = 0;
    }
    public void guncekle(int yasamsayisi)
    {
        lives += yasamsayisi;
        if(lives<=0)
        {
            oyunbitti();
            lives = 0;
        }
        liveskor.text = "LÝVES:" + lives.ToString();
       
    }
    public void skorguncel(int skorgun)
    {
       this.skor += skorgun;
        skorskor.text = "SKOR:" + skor.ToString();
    }
    void oyunbitti()
    {
        gameover = true;
        oyunbpanel.GetComponent<CanvasGroup>().DOFade(1, 0.4f);
        oyunbpanel.GetComponent<RectTransform>().DOScale(1, 0.6f);
      
    }

    public void yeniden()
    {
        SceneManager.LoadScene("tugla_kirma");

    }
    public void cikis()
    {
        Application.Quit();
    }
}
