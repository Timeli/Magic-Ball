using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredicateGenerator : MonoBehaviour
{
    private string _predicate;

    private string[] _allPredicates = new string[]
    {
        "Бесспорно",
        "Предрешено",
        "Никаких сомнений",
        "Определённо да",
        "Можешь быть уверен в этом",

        "Мне кажется - \"да\"",
        "Вероятнее всего",
        "Хорошие перспективы",
        "Знатоки говорят - \"да\"",
        "Да",

        "Пока не ясно, попробуй снова",
        "Спроси позже",
        "Лучше не рассказывать",
        "Сейчас нельзя предсказать",
        "Сконцентрируйся и спроси опять",

        "Даже не думай",
        "Мой ответ - \"нет\"",
        "По моим данным - \"нет\"",
        "Перспективы не очень хорошие",
        "Весьма сомнительно"
    };

    private void Start()
    {
        print(GeneratePredicate());
    }

    private string GeneratePredicate()
    {
        int index = Random.Range(0, _allPredicates.Length);
        return _allPredicates[index];
    }
}
