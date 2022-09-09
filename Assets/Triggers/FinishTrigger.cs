using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.Ecs;

public class FinishTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) {
        Player player = collider.gameObject.GetComponent<Player>();
        player._entity.Get<Movement>().Speed = 0;
        player._entity.Get<RigidbodyRef>().Rigidbody.isKinematic = true;

        Debug.Log("Finish");
    }
}
