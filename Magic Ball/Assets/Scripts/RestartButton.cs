using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Accelerometr _accelerometr;

    private Image _imageButton;

    private float _step = 0.01f;
    private float _delayBeforeShow = 1.5f;
    private float _duration = 3;


    private void OnEnable()
    {
        _accelerometr.Shaked += InitialShowButton;
        _restartButton.onClick.AddListener(RestartScene);
    }


    private void OnDisable()
    {
        _accelerometr.Shaked -= InitialShowButton;
        _restartButton.onClick.RemoveListener(RestartScene);
    }


    private void Awake()
    {
        _restartButton.enabled = false;
        _imageButton = GetComponent<Image>();
    }


    private void InitialShowButton()
    {
        _restartButton.enabled = true;
        StartCoroutine(ShowButton(_step, _delayBeforeShow));
    }


    private IEnumerator ShowButton(float step, float delay)
    {
        var s = new WaitForSeconds(step);
        float tmp = 0;

        // задержка перед появлением
        yield return new WaitForSeconds(delay);

        while (tmp <= _duration)
        {
            _imageButton.color =  new Color(_imageButton.color.r, 
                                            _imageButton.color.g, 
                                            _imageButton.color.b,
                                            tmp / _duration);
            tmp += step;
            yield return s;
        }
    }


    private void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

}
