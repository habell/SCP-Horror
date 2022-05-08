namespace DefaultNamespace.Interfaces
{
    public interface IEnemy : ISpawnable
    {
        void SetEnemyManager(EnemyManager enemyManager);
    }
}