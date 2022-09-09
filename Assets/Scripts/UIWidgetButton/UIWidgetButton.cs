using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIWidgetButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private UIWidgetButtonAnimator _animator;
    [SerializeField] private float _lifeTime;

    private void OnEnable()
    {
        this._animator.OnAppearAnimationOverEvent += OnAppearAnimationOver;
    }

    private void OnDisable()
    {
        this._animator.OnAppearAnimationOverEvent -= OnAppearAnimationOver;
    }

    private void OnAppearAnimationOver()
    {
        StartCoroutine(LifeRoutine());
    }

    private IEnumerator LifeRoutine()
    {
        yield return new WaitForSeconds(this._lifeTime);
        this._animator.PlayHide();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        this._animator.OnClickAnimationEvent += OnClickAnimation;

        _animator.Handle_OnClickAnimation();
    }

    private void OnClickAnimation()
    {
        StopCoroutine(LifeRoutine());
        this._animator.SetColor();
    }
}
