using UnityEngine;
using DG.Tweening;

public class MoveCube : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _moveSpeed;

    private Tweener _tweenMove;

    private void Awake()
    {
        _tweenMove = transform.DOMove(_target.position, _moveSpeed).SetEase(Ease.Linear).SetAutoKill(false);
        _moveSpeed = 2;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _tweenMove.ChangeEndValue(_target.position, true).Restart();
    }
}
