using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.Ecs;

public class Player : MonoBehaviour
{
    [SerializeField] private Movement _movement;
    public EcsEntity _entity;
    public void CreateEntity(EcsWorld world) {
        _entity = world.NewEntity();
        _entity.Get<PlayerTag>();

        ref var transformRef = ref _entity.Get<TransformRef>();
        transformRef.Transform = transform;

        ref var rigidbodyRef = ref _entity.Get<RigidbodyRef>();
        rigidbodyRef.Rigidbody = GetComponent<Rigidbody>();

        _entity.Get<Movement>() = _movement;
    }
}
