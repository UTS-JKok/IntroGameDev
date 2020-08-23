using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    public Renderer rend;

    private int count;
    private int randomNumber;

    void Start()
    {
        count = 0;
        randomNumber = Random.Range(200, 251);              // Between 200 and 250 inclusive
    }

    void Update()
    {
        // Frame counter
        Debug.Log($"{gameObject.name}: {++count}");

        // Hide
        switch (gameObject.tag)
        {
            case "Red":
                if (count == 100) {
                    gameObject.SetActive(false);
                }
                break;

            case "Blue":
                if (count == randomNumber) {
                    rend.enabled = false;
                }
                break;
        }
    }
}
