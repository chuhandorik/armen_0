using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorButtonsrc : MonoBehaviour
{
    // Start is called before the first frame update
    public int o;
    [SerializeField] Button but;
    void Start()
    {
        switch (o)
        {
            case 0:
                but.image.color = Color.white; break;
            case 1:
                but.image.color = Color.black; break;
            case 2:
                but.image.color = Color.red; break;
            case 3:
                but.image.color = Color.green; break;
            case 4:
                but.image.color = Color.blue; break;
            case 5:
                but.image.color = Color.yellow; break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Swin()
    {
        o += 1;
        if (o == 6) o = 0;
        Start();
        
    }

}
