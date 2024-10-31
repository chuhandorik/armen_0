using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyButton : MonoBehaviour
{
    public RectTransform prefab;
    public Text countText;
    public RectTransform content;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CreateEnemyButton()
    {
        Instantiate(prefab, content);
    }
}
