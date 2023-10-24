using UnityEngine;
using DG.Tweening;

public class FillColor : MonoBehaviour
{
    private bool _canRepeat;
    private MeshRenderer _meshRender;

    private void Awake()
    {
        _canRepeat = true;
        _meshRender = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        if (_canRepeat)
            _meshRender.material.DOColor(Random.ColorHSV(), 1.2f).OnComplete(ChangeColor);
    }
}
