using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    public HealthBehavior Health => _health;
    [SerializeField]
    private HealthBehavior _health;

}

public class HelathBarManager : MonoBehaviour
{
    [SerializeField] 
    private HealthBar _healthBarPrefab;
    [SerializeField] 
    private List<HealthBehavior> _healthBehaviors;

    private void Awake()
    {
        foreach (var health in _healthBehaviors)    
        {
            CreateHealthBar(health);
        }
        
    }

    private void CreateHealthBar(HealthBehavior health)
    {
        var healthBarInstance = Instantiate(_healthBarPrefab, transform);
        healthBarInstance.InitializeHP(health);
    }
}
public class HealthBar : MonoBehaviour

{
    [SerializeField] private ProgressBar _progressBar;
    private HealthBehavior _healthBehavior;
    private RectTransform _rectTransform;

    private void Awake()
    {
        _rectTransform = transform as RectTransform;
    }

    public void InitializeHP(HealthBehavior healthBehavior)
    {
        _healthBehavior = healthBehavior;
    }

    private void Update()
    {
        UpdateProgressBarPosition(_healthBehavior.transform);
        UpdateProgressBarValue(_healthBehavior);
    }

    private void UpdateProgressBarPosition(Transform followingObject)
    {
        var worldPosition = followingObject.transform.position;
        var screenPoint = Camera.main.WorldToScreenPoint(worldPosition);
        var healthBarParent = transform.parent as RectTransform;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(healthBarParent, screenPoint, null, out var localPoint);
        _rectTransform = transform as RectTransform;
        _rectTransform.anchoredPosition = localPoint;
    }

    private void UpdateProgressBarValue(HealthBehavior healthBehavior)
    {
        _progressBar.SetProgress(healthBehavior.Health / (float)healthBehavior.MaXHealth);
    }
}