using UnityEngine;

/// <summary>
/// Entity의 공통된 로직과 데이터를 저장하는 ScriptableObject
/// </summary>
[CreateAssetMenu(fileName = "NewEntityData", menuName = "Entity Data")]
public class EntityData: ScriptableObject
{
    #region id
    /// <summary>
    /// 해당 유형 Entity의 기본 아이디
    /// </summary>
    [SerializeField, Tooltip("해당 유형 Entity의 기본 아이디")]
    protected EntityID id;

    /// <summary>
    /// Entity의 아이디 (변경 불가능)
    /// </summary>
    public EntityID ID => id;
    #endregion

    #region name
    /// <summary>
    /// 해당 유형 Entity의 기본 이름
    /// </summary>
    [SerializeField, Tooltip("해당 유형 Entity의 기본 이름")]
    protected string defaultName;

    /// <summary>
    /// Entity의 기본 이름 (변경 불가능)
    /// </summary>
    public string Name => defaultName;
    #endregion

    #region description
    /// <summary>
    /// 해당 유형 Entity의 기본 설명
    /// </summary>
    [SerializeField, Tooltip("해당 유형 Entity의 기본 설명")]
    [TextArea(3, 5)]protected string defaultDescription;
    
    /// <summary>
    /// Entity의 기본 설명 (변경 불가능)
    /// </summary>
    public string Description => defaultDescription;
    #endregion

    //TODO: Entity의 속성 enum을 key로 하고 그에 따른 구현체를 value로 하는 dictionary 만듦
}
