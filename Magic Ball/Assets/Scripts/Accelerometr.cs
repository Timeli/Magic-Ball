using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Accelerometr : MonoBehaviour
{
    public event UnityAction Shaked;

    private int _shakeCount;
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
            _shakeCount++;
            if (_shakeCount >= 12)
            {
                _isFinish = true;
                Handheld.Vibrate();
                _audioSource.Play();
                Shaked?.Invoke();
            }
        }
    }
}
