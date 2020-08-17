using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 0;
    public Renderer rend;
    private int a;

    // Start is called before the first frame update
    void Start()
    {
        a = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(gameObject.name+":"+i);
        i++;
        if (i == 100 && gameObject.tag == "Red")
        {
            gameObject.SetActive(false);   
        }
        if (i == a && gameObject.tag == "Blue")
        {
            rend.enabled = false;
        }

    }
}
