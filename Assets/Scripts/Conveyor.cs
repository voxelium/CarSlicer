using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed;

    private void OnTriggerStay(Collider other)
    {
        other.transform.position = Vector3.MoveTowards(other.transform.position, _endPoint.transform.position, _speed);
    }

}
