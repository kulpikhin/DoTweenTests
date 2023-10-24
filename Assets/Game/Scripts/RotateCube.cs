using UnityEngine;
using DG.Tweening;

public class RotateCube : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.DORotate(new Vector3(0, 360, 0), _rotateSpeed, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }
}
