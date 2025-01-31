using UnityEngine;

/// <summary>
/// 게임 시스템 상 Entity로 분류되는 GameObject에 부착되는 컴포넌트의 기본 클래스
/// </summary>
public abstract class Entity: MonoBehaviour
{

    #region entityData
    /// <summary>
    /// Entity의 공통 로직을 담고 있는 ScriptableObject
    /// </summary>
    [SerializeField, Tooltip("Entity의 공통 로직을 담고 있는 ScriptableObject")]
    protected EntityData entityData;

    /// <summary>
    /// Entity의 공통 로직을 담고 있는 ScriptableObject
    /// </summary>
    public EntityData EntityData => entityData;
    #endregion

    #region name
    /// <summary>
    /// Entity의 표시될 이름
    /// </summary>
    [SerializeField, Tooltip("Entity의 표시될 이름")]
    protected string displayName;

    /// <summary>
    /// Entity의 표시될 이름
    /// </summary>
    public string DisplayName
    {
        get
        {
            if (string.IsNullOrEmpty(displayName))
            {
                return entityData.Name;
            }
            return displayName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                displayName = null;
                return;
            }
            displayName = value;
        }
    }
    #endregion

    #region description
    /// <summary>
    /// Entity의 설명
    /// </summary>
    [SerializeField, TextArea(3, 5), Tooltip("Entity의 표시될 설명")] protected string displayDescription;

    /// <summary>
    /// Entity의 설명
    /// </summary>
    public string DisplayDescription
    {
        get
        {
            if (string.IsNullOrEmpty(displayDescription))
            {
                return entityData.Description;
            }
            return displayDescription;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                displayDescription = null;
                return;
            }
            displayDescription = value;
        }
    }
    #endregion

}