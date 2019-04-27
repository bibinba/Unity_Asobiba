using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hairetu : MonoBehaviour
{
    public Text arrayText;
    private string[] stringArray = new string[10];

    // Start is called before the first frame update
    void Start()
    {
        arrayText.text = "";
        for (int i=0; i<stringArray.Length; i++)
        {
            stringArray[i] = Random.Range(1, 100).ToString();
            arrayText.text = arrayText.text + stringArray[i] + ",";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
