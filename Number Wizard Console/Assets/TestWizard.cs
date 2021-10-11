using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        int max = 60;
        int min = 10;
        Debug.Log("is 70..." + min + max);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Nice");
        }
    }
}
