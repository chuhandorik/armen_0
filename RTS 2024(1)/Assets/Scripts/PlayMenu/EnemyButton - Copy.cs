using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using System.Linq;
using Unity.VisualScripting;
public class EnemyButton : MonoBehaviour
{
    
    [SerializeField] private TMP_Dropdown dropdown1;
    public int vybor;
    public RectTransform prefab;
    public RectTransform content;
    public int a;
    public int chil_cou;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(content.GetComponentsInChildren<Transform>());
        //var dropdown1 = transform.GetComponent<Dropdown>();

        //List<string> list_drop = new List<string>();
        //for (int i = 0; i < 7; i++)
        //{
        //    list_drop.Add($"{i}");
        //}

        //foreach (var i in list_drop)
        //{
        //    dropdown1.options.Add(new Dropdown.OptionData() { text = i });
        //}
        //DropItemSelected(dropdown1);
        //dropdown1.onValueChanged.AddListener(delegate { DropItemSelected(dropdown1); });

        //Instantiate(prefab, content);
        
    }
    void DropItemSelected(Dropdown dropdown1)
    {
        //vybor = Convert.ToInt16(dropdown1.options[dropdown1.value].text);
        vybor = dropdown1.value;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CreateEnemyButton()
    {
        
        a = dropdown1.value;

        chil_cou=content.childCount-3;
        Debug.Log(chil_cou);
        if (a > chil_cou)
        {
            for (int i = 0; i < a-chil_cou; i++)
            {
                Instantiate(prefab, content);
            }
        }
        else
        {
            for (int i = 0; i < chil_cou-a; i++)
            {
                DestroyImmediate(content.GetChild(content.childCount - 1).gameObject);

            }
        }
    }
}
