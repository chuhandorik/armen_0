using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Prokrutka : MonoBehaviour
{
    public Transform paren;
    
    public int kolvo;
    // Start is called before the first frame update
    void Start()
    {
        var a = transform.GetComponent<Dropdown>();
        kolvo = 1;
        a.onValueChanged.AddListener(delegate { xz(a); });
        xz(a);
    }
    void xz(Dropdown a)
    {
        int index = a.value;
        Debug.Log(index);
        
        for (int i = 0; i < index; i++)
        {
            GameObject newbut = new GameObject($"newbut_{i + 1}", typeof(Button), typeof(LayoutElement));
            newbut.transform.SetParent(paren);
            newbut.GetComponent<LayoutElement>().minHeight = 20;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
