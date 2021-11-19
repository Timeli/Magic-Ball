using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Accelerometr _accelerometr;

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

    private void InitialShowButton()
    {

    }

    private IEnumerator ShowButton(float duration)
    {
        var delay = new WaitForSeconds(duration);

        yield return delay;
    }


    private void RestartScene()
    {
        SceneManager.LoadScene(0);
    }

}
