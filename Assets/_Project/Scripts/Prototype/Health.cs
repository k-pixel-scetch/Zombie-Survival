using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    [SerializeField] private int _maxHealth = 100;
    private int _currentHealth;

    [SerializeField] private bool _enemy = false;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(int damage) 
    { 
        _currentHealth -= damage;

        if (Die()) 
        { 
            ReactToDeath();
        }
    }

    private void ReactToDeath() 
    {
        if (_enemy)
        {
            Destroy(gameObject);
        }
        else 
        {
            _gameManager.Defeat();
        }
    }

    private bool Die()
    {
        return _currentHealth <= 0;
    }
}
