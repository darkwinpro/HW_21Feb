using System.Collections.Generic;
using UnityEngine;

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