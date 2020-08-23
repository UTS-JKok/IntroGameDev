using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    public Renderer rend;

    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Not sure if the instructions mean this should start printing 0 or 1
        // Increment every frame i guess also includes first frame so setting to start at 1
        count++;
        Debug.Log($"{gameObject.name}: {count}");
    }
}
