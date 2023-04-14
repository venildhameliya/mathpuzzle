using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class home : MonoBehaviour
{
    public  GameObject homeobj, contobj,puzzleobj,exitobj;
    public void onclickcontinue()
    {
        homeobj.SetActive(false);
        contobj.SetActive(true);
    }
    public void onclickpuzzle()
    {
        homeobj.SetActive(false);
        puzzleobj.SetActive(true);
    }
    public void bckhome()
    {
        exitobj.SetActive(true);
    }
    public void NO()
    {
        exitobj.SetActive(false);
    }
    public void Yes()
    {
        exitobj.SetActive(false);
        homeobj.SetActive(true);
    }
}
