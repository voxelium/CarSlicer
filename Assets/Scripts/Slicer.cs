using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using BzKovSoft.ObjectSlicer;
using BzKovSoft.ObjectSlicer.Samples;

public class Slicer : MonoBehaviour
{
    [SerializeField] GameObject _cutter;
    [SerializeField] float _cutTime;

    private BzKnife _knife;
    private float _delayBetWeenCuts;
    private Quaternion startRotation = Quaternion.Euler(0, 0, -60);
    private Vector3 startPosition = new Vector3(2.8f, 0.5f, -2.8f);

    private float _timeAfterCut;

    private void Start()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
        _delayBetWeenCuts = _cutTime * 2;

        _knife = _cutter.GetComponentInChildren<BzKnife>();

        Rigidbody cutterRigidbody = _cutter.GetComponentInChildren<Rigidbody>();

    }


    private void Update()
    {
        _timeAfterCut += Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {

            if (_timeAfterCut > _delayBetWeenCuts)
            {
                _knife.BeginNewSlice();

                transform.DORotate(new Vector3(0, 0, 0), _cutTime, RotateMode.Fast).SetLoops(2, LoopType.Yoyo).SetEase(Ease.InSine);

                _timeAfterCut = 0;
            }
        }

    }





}