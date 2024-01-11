
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
        if (Input.GetKey(KeyCode.Alpha1))
        {
            _animator.SetTrigger("Win");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            _animator.SetTrigger("Die");
        }
    }
}
