using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.Ecs;

public class PlayerMovementSystem : IEcsRunSystem
{
    private EcsFilter<PlayerTag, TransformRef, RigidbodyRef, Movement> _filter;

    public void Run() {
        foreach (var i in _filter) {
            var direction = _filter.Get4(i).Direction;
            if (Input.GetMouseButtonDown(0)) {
                direction = direction == 0 ? 1 : 0;
            }
            _filter.Get4(i).Direction = direction;

            var velocity = direction == 0 ? Vector3.forward : Vector3.right;
            velocity *= _filter.Get4(i).Speed;
            velocity.y = _filter.Get3(i).Rigidbody.velocity.y;
            _filter.Get3(i).Rigidbody.velocity = velocity;
        }
    }
}
