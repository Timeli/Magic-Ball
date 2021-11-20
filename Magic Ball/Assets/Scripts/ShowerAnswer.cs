using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class ShowerAnswer : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private PredicateGenerator _generator;

    private CanvasGroup _canvasGroup;

    private void OnEnable()
    {
        _generator.PredicateEnded += ShowPredicate;
    }

    private void OnDisable()
    {
        _generator.PredicateEnded -= ShowPredicate;
    }

    private void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    private void ShowPredicate(string predicate)
    {
        _text.text = predicate;
        StartCoroutine(ShowText(0.02f));
    }

    private IEnumerator ShowText(float duration)
    {
        var s = new WaitForSeconds(duration);
        float step = 100;

        for (int i = 0; i < step; i++)
        {
            _canvasGroup.alpha = i / step;

            yield return s;
        }
    }



}
