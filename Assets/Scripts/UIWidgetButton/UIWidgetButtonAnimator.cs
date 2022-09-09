using System;
using UnityEngine;

public class UIWidgetButtonAnimator : MonoBehaviour
{
    public event Action OnAppearAnimationOverEvent;
    public event Action OnClickAnimationEvent;

    [SerializeField] private Animator _animator;

    public void PlayHide()
    {
        this._animator.SetTrigger("hide");
    }

    public void SetColor()
    {
        _animator.SetTrigger("color");
    }

    private void Handle_AppearAnimationOver()
    {
        this.OnAppearAnimationOverEvent?.Invoke();
    }

    public void Handle_OnClickAnimation()
    {
        OnClickAnimationEvent?.Invoke();
    }
}
