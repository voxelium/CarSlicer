using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
	[SerializeField] private float _explosionPower;
	[SerializeField] private float _explosionRadius;
	[SerializeField] private float _explosionUpModifier;
	[SerializeField] Transform _explosionObject;

	private Vector3 _explosionPosition;

    private void Start()
    {
		_explosionPosition = _explosionObject.transform.position;
    }

    private void OnTriggerExit(Collider other)
	{
		other.attachedRigidbody.AddExplosionForce(_explosionPower, _explosionPosition, _explosionRadius, _explosionUpModifier);
	}  
}