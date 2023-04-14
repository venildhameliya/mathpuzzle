using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class continuep : MonoBehaviour
{
    public GameObject homeobj,contobj,puzzleobj,winobj,skipobj,hintobj;
    public string[] trueans = {"1","2","3"};
    string str = "";
    public Text txt,leveltxt, leveltxt2;
    int levelno = 0;
    public Image puzzleimage;
    public Sprite[] allpuzzles;
    public int score = 0;
    public void OnEnable()
    {
        levelno = PlayerPrefs.GetInt("levelno", 1);
        leveltxt.text = "PUZZLE " + levelno;
        puzzleimage.sprite = allpuzzles[levelno - 1];
    }
    public void onclickbtn(int n)
    {
        txt.text = txt.text + n.ToString();
    }
    public void del()
    {
        if (txt.text.Length > 0)
        {
            txt.text = txt.text.Substring(0, txt.text.Length - 1);
            txt.text += str;
        }
    }
    public void submit()
    {
        if (txt.text == trueans[levelno - 1])
        {
            score = score + 10;
            leveltxt2.text = "PUZZLE " + levelno + " COMPLETE";
            levelno++;
            PlayerPrefs.SetInt("levelno",levelno);
            contobj.SetActive(false);
            winobj.SetActive(true);
            txt.text = str;
            print(levelno);
        }
        else
        {
            txt.text = str;
            //txt.text = txt.text.Substring(0, txt.text.Length - txt.text.Length);
        }
    }
    
    public void menu()
    {
        winobj.SetActive(false);
        homeobj.SetActive(true);
    }
    public void wincon()
    {
        winobj.SetActive(false);
        contobj.SetActive(true);
    }
    public void skip()
    {
        skipobj.SetActive(true);
    }
    public void cancel()
    {
        skipobj.SetActive(false);
    }
    public void ok()
    {
        levelno++;
        PlayerPrefs.SetInt("levelno", levelno);
        skipobj.SetActive(false);
        contobj.SetActive(true);
        leveltxt.text = "PUZZLE " + levelno;
        puzzleimage.sprite = allpuzzles[levelno - 1];
        print(levelno);
    }
    public void hint()
    {
        hintobj.SetActive(true);
        if (score >= 20)
        {
            score = score + 20;
        }
    }
    public void hintclose()
    {
        hintobj.SetActive(false);
    }
}
