using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Accelerometr : MonoBehaviour
{
    public event UnityAction Shaked;

    private int _shakeCount;
    private bool _isFinish;

    private void FixedUpdate()
    {
        if (_isFinish == false)
            ShakePhone();
    }

    private void ShakePhone()
    {
        if (Mathf.Abs(Input.acceleration.y) > 1.8f)
        {
            //print(Input.acceleration.x);
            //print(_shakeCount);
            _shakeCount++;
            if (_shakeCount >= 10)
            {
                _isFinish = true;
                Handheld.Vibrate();
                Shaked?.Invoke();
            }
        }
    }
}
