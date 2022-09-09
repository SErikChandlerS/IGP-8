using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        Debug.Log("Coin was collected!");
        Destroy(gameObject);
    }
}
