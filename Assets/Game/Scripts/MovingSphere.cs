using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingSphere : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private float _speed = 1.5f;

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        transform.DOMove(_target.transform.position, _speed).SetEase(Ease.InOutSine).SetLoops(-1,LoopType.Yoyo);
    }
}
