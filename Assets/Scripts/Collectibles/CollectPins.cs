using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPins : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        CollectableControl.pinCount += 1;
        this.gameObject.SetActive(false);
    }

}
