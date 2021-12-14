using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticalSystem : MonoBehaviour
{
    [SerializeField] private Accelerometr _accelerometr;

    private ParticleSystem _particleSystem;


    private void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
    }


    private void OnEnable()
    {
        _accelerometr.Shaked += VelocityChange;
    }


    private void OnDisable()
    {
        _accelerometr.Shaked -= VelocityChange;
    }


    private void VelocityChange()
    {
        var velocityOverLifetime = _particleSystem.velocityOverLifetime;
        velocityOverLifetime.orbitalZ = 0f;
        velocityOverLifetime.z = -10f;
    }

}
