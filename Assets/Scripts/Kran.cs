using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kran : MonoBehaviour
{
	private bool _isOpened;
    [SerializeField]private ParticleSystem _particleSystem;
	[SerializeField] private Animator _animator;


	public void OpenL()
	{
		_animator.SetBool("IsOpened", _isOpened);
        if(_isOpened == true)
        {
            _particleSystem.Play();
        }
        else
        {
            _particleSystem.Stop();
        }
		_isOpened = !_isOpened;
	}
}