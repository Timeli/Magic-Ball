using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Accelerometr : MonoBehaviour
{
    public event UnityAction Shaked;

    private int _shakeNumber = 12;
    private int _shakeCounter;

    private bool _isFinish;

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (_isFinish == false)
            ShakePhone();
    }

    private void ShakePhone()
    {
        if (Mathf.Abs(Input.acceleration.y) > 1.7f)
        {
            _shakeCounter++;
            if (_shakeCounter >= _shakeNumber)
            {
                _isFinish = true;
                _audioSource.Play();

                Shaked?.Invoke();
            }
        }
    }
}
