using System;
using UnityEngine;

// Author: Brett DeWitt
//
// Date created: 05/03/2025
//
// Description:
// Defines events that game objects may broadcast and subscribe to. Once
// defined, game objects can subscribe to an event by referencing the
// definition in this class, ie
//     GameEvents.DefinedEvent += HandlerFunction
// The handler function in the subscribing class will be called when
// the subscribed event is broadcast.
// 
// Example:
//   Definition:
//      public static Action OnEnemyKilled;
//      public static void EnemyKilled() => OnEnemyKilled?.Invoke();
//
//   Broadcasting:
//      GameEvents.EnemyKilled(this);
//
//   Subscribing:
//      void OnEnable()
//      {
//          GameEvents.OnEnemyKilled += HandleEnemyKilled;
//      {
//
//   Unsubscribing:
//      void OnDisable()
//      {
//          GameEvents.OnEnemyKilled -= HandleEnemyKilled;
//      }

public static class GameEvents
{
    // EnemyKilled
    public static Action<EnemyController> OnEnemyKilled;
    public static void EnemyKilled(EnemyController enemy) => OnEnemyKilled?.Invoke(enemy);

    // EnemyReachedGoal
    public static Action<EnemyController> OnEnemyReachedGoal;
    public static void EnemyReachedGoal(EnemyController enemy) => OnEnemyReachedGoal?.Invoke(enemy);

    // PlayerGoldChanged
    public static Action<int> OnPlayerGoldChanged;
    public static void PlayerGoldChanged(int updatedPlayerGold) => OnPlayerGoldChanged?.Invoke(updatedPlayerGold);

    // PlayerHealthChanged
    public static Action<int> OnPlayerHealthChanged;
    public static void PlayerHealthChanged(int updatedPlayerHealth) => OnPlayerHealthChanged?.Invoke(updatedPlayerHealth);

    // TowerPlacementRequest
    public static Action<Vector3, GameObject> OnTowerPlacementRequest;
    public static void TowerPlacementRequest(Vector3 globalPosition, GameObject tower) => OnTowerPlacementRequest?.Invoke(globalPosition, tower);

    // TowerPlacementExecute
    public static Action<Vector3, GameObject> OnTowerPlacementExecute;
    public static void TowerPlacementExecute(Vector3 globalPosition, GameObject tower) => OnTowerPlacementExecute?.Invoke(globalPosition, tower);

    // TowerPlacementBlocked
    public static Action<int, int> OnTowerPlacementInvalid;
    public static void TowerPlacementInvalid(int gridX, int gridY) => OnTowerPlacementInvalid?.Invoke(gridX, gridY);

    // TowerPlacementSuccess
    public static Action<GameObject> OnTowerPlacementSuccess;
    public static void TowerPlacementSuccess(GameObject tower) => OnTowerPlacementSuccess?.Invoke(tower);

    // Game Over
    public static Action OnGameOver;
    public static void GameOver() => OnGameOver?.Invoke();

    // Game Clear
    public static Action OnGameClear;
    public static void GameClear() => OnGameClear?.Invoke();
}
