using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Activecolor
{
    public Color color;
    public bool active;
    public Activecolor(Color colorr, bool activer = false)
    {
        color = colorr;
        active = activer;
    }
}

public class Buttoncolors : MonoBehaviour
{
    public int vybor;
    public Button but;
    
    static Activecolor[] list_color;
    static bool a=false;
    static int i_but=0;
    void Start()
    {
        if (a == false)
        {
            
            a = true;
            Buttoncolors.list_color = new Activecolor[]
            {
                new Activecolor (new Color(255, 0, 0)),
                new Activecolor (new Color(0, 255, 0)),
                new Activecolor (new Color(0, 0, 255)),
                new Activecolor (new Color(255, 255, 0)),
                new Activecolor (new Color(255, 0, 255)),
                new Activecolor (new Color(0, 255, 255)),
                new Activecolor (new Color(0, 0, 0)),
                new Activecolor (new Color(255, 255, 255))
            };
        }
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void saveColor()
    {
        int i = 0;
        while (i < list_color.Length)
        {
            if (!Buttoncolors.list_color[i].active)
            { 
                Buttoncolors.list_color[i].active = true;
                but.image.color=Buttoncolors.list_color[i].color;
            }
            
        }

    }
    public void ChangeColor()
    {
        //Transform[] a= content.GetComponentsInChildren<Transform>();
        //int indbutton= 0;
        //for (int ii = 0; ii<a.Length; ii++)
        //{
        //    if (but == a[ii]) { indbutton = ii-3; }
        //}
        while (true)
        {
            if (Buttoncolors.i_but >=7) { Buttoncolors.i_but = 0;  continue;}
            else
            {
                if (!Buttoncolors.list_color[i_but].active)
                {
                    if (Buttoncolors.i_but +1 == 8)
                    {
                        Buttoncolors.list_color[Buttoncolors.i_but].active = false;
                        but.image.color= Buttoncolors.list_color[Buttoncolors.i_but +1].color;
                        Buttoncolors.i_but = 0;
                    }
                    else
                    {
                        Buttoncolors.list_color[Buttoncolors.i_but].active = false;
                        but.image.color = Buttoncolors.list_color[Buttoncolors.i_but + 1].color;
                        Buttoncolors.i_but++;
                    }
                    break;
                }
                
            }
            Buttoncolors.i_but++;
        }
    }
}
