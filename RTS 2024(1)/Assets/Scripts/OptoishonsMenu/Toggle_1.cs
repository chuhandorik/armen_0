using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle_1 : MonoBehaviour
{
    [SerializeField] GameObject vkl_on;
    [SerializeField] GameObject vkl_off;
    bool vkl;
    // Start is called before the first frame update
    void Start()
    {
        vkl = true;
        vkl_off.SetActive(!vkl);
        vkl_on.SetActive(vkl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Switch()
    {
        if (vkl) {
            vkl = !vkl;
            vkl_off.SetActive(!vkl);
            vkl_on.SetActive(vkl);
        }
        else {
            vkl = !vkl;
            vkl_off.SetActive(!vkl);
            vkl_on.SetActive(vkl);
        }
    }
}
