using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    public HealthBehavior Health => _health;
    [SerializeField]
    private HealthBehavior _health;

}