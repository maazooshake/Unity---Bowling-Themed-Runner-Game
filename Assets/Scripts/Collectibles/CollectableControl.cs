using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int pinCount;
    public GameObject pinCountDisplay;

    // Update is called once per frame
    void Update()
    {
        pinCountDisplay.GetComponent<Text>().text = "" + pinCount;
    }

}
