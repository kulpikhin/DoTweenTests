using UnityEngine;
using DG.Tweening;

public class Scale : MonoBehaviour
{
    private float _scaleSpeed = 1;
    private float _minimumSale = 0.2f;

    private void Start()
    {
        ChangeScale();
    }

    private void ChangeScale()
    {
        transform.DOScale(_minimumSale, _scaleSpeed).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }
}
