using UnityEngine;

namespace DefaultNamespace
{
    public class Health : MonoBehaviour
    {
        private float _health;

        public void SetHealth(float value)
        {
            if (_health + value > 0)
            {
                _health += value;
            }
            else
            {
                Death();
            }
        }

        private void Death()
        {
            print("Oh no, i'm death!");
            Destroy(gameObject);
        }
    }
}