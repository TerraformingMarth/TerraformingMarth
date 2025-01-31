using UnityEngine;

/// <summary>
/// 아이템을 사용했을 때 로직을 담당하는 클래스
/// </summary>
public abstract class Consumable : ScriptableObject
{
    /// <summary>
    /// 아이템을 사용했을 때의 로직
    /// </summary>
    public abstract void Consume(/*LivingEntity entity*/);
}
