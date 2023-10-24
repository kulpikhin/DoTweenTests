using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System;

public class TextChanger : MonoBehaviour
{
    private Text _text;
    private int _number;

    private void Awake()
    {
        _number = Convert.ToInt32(_text);
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        ChangeText();
    }

    private void ChangeText()
    {
        _number++;
        _text.DOText(Convert.ToString(_number), 1).OnComplete(AddText);
    }

    private void AddText()
    {
        _number++;
        _text.DOText(Convert.ToString(_number), 1).SetRelative().OnComplete(BreakText);
    }

    private void BreakText()
    {
        _number++;
        _text.DOText(Convert.ToString(_number), 1, true, ScrambleMode.All).OnComplete(ChangeText);
    }
}
