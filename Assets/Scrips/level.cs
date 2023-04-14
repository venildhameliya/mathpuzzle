using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class level : MonoBehaviour
{
    int i,levelNo = 0;
    public Button[] allbtns;
    public Sprite ticksign;
    public GameObject homeobj, contobj, puzzleobj,puzzleback,puzzlenext,puzzlenext1,puzzleback1,puzzlenext2,puzzleback2;

    private void OnEnable()
    {
        levelNo = PlayerPrefs.GetInt("levelno", 1);
        
        for (i = 0; i < levelNo; i++)
        {
            allbtns[i].interactable = true;
            if (i == levelNo - 1)
            {
                allbtns[i].GetComponent<Image>().sprite = null;
                allbtns[i].GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            }
            else
            {
                allbtns[i].GetComponent<Image>().sprite = ticksign;
            }
            allbtns[i].GetComponentInChildren<Text>().text = (i + 1).ToString();
        }
    }
    public void levbtn(int n)
    {
        print(n);
        PlayerPrefs.SetInt("levelno", n);
        puzzleobj.SetActive(false);
        contobj.SetActive(true);
    }
    public void bckhome()
    {
        puzzleobj.SetActive(false);
        homeobj.SetActive(true);
    }
    public void next()
    {
        puzzleobj.SetActive(false);
        puzzlenext.SetActive(true);
    }
    public void next2()
    {
        puzzlenext.SetActive(false);
        puzzlenext1.SetActive(true);
    }
    public void next3()
    {
        puzzlenext1.SetActive(false);
        puzzlenext2.SetActive(true);
    }
    public void back()
    {
        puzzleback.SetActive(false);
        puzzleobj.SetActive(true);
    }
    public void back2()
    {
        puzzleback1.SetActive(false);
        puzzleback.SetActive(true);
    }
    public void back3()
    {
        puzzleback2.SetActive(false);
        puzzleback1.SetActive(true);
    }
}
