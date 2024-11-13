using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Downlist : MonoBehaviour
{
    public static int kolvo;
    private int val;
    [SerializeField] TMP_Dropdown dropdown;
    
    // Start is called before the first frame update
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetValueehj()
    {
        Debug.Log("adsfasdfasdf"+dropdown.value);
        kolvo = dropdown.value;
    }
}
