
using System.Diagnostics;
using UnityEngine;

public class InstantWinLoss : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (_animator == null)
        {
            UnityEngine.Debug.LogError("Animator component not found.");
            return;
        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            _animator.SetTrigger("Win");
            UnityEngine.Debug.LogError("Win");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            _animator.SetTrigger("Die");
            UnityEngine.Debug.LogError("Death");
        }
    }
}
