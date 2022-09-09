using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.Ecs;

public class FallTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        Player player = collider.gameObject.GetComponent<Player>();
        player._entity.Get<Movement>().Speed = 0;

        Debug.Log("Fail");
    }
}
