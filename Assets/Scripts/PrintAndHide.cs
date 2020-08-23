using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    public Renderer rend;

    private int count;
    private int randNum;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;

        randNum = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        // Not sure if the instructions mean this should start printing 0 or 1
        // Increment every frame i guess also includes first frame so setting to start at 1
        count++;
        Debug.Log($"{gameObject.name}: {count}");

        // Hide
        switch (gameObject.tag)
        {
            case "Red":
                if (count == 100) {
                    gameObject.SetActive(false);
                }
                break;

            case "Blue":
                if (count == randNum) {
                    rend.enabled = false;
                }
                break;
        }
    }
}
