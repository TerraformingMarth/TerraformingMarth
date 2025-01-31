using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 게임 내 아이템의 속성과 동작 로직을 저장하는 ScriptableObject
/// </summary>
[CreateAssetMenu(fileName = "UnnamedItemData", menuName="ItemData")]
public class ItemData : ScriptableObject
{
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class의 기본 아이템 아이디
    /// </summary>
    [SerializeField, Tooltip("이 ItemData를 갖는 Wrapper Class의 기본 아이템 아이디")]
    private ItemID id = ItemID.AIR;
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class의 기본 이름
    /// </summary>
    [SerializeField, Tooltip("이 ItemData를 갖는 Wrapper Class의 기본 이름")]
    private string defaultName = "";
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class의 기본 설명
    /// </summary>
    [TextArea(3, 10)]
    [SerializeField, Tooltip("이 ItemData를 갖는 Wrapper Class의 기본 설명")]
    private string defaultDescription = "";
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class가 한 스택 당 최대 쌓을 수 있는 아이템 개수
    /// </summary>
    [SerializeField, Tooltip("이 ItemData를 갖는 Wrapper Class가 한 스택 당 최대 쌓을 수 있는 아이템 개수")]
    private int defaultMaxStackAmount = 64;
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class가 갖는 기본 Sprite 배열
    /// </summary>
    [SerializeField, Tooltip("이 ItemData를 갖는 Wrapper Class가 갖는 기본 Sprite 배열")]
    private Sprite[] defaultSprites;
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class가 갖는 기본 Sprite Index
    /// </summary>
    [SerializeField, Tooltip("이 ItemData를 갖는 Wrapper Class가 갖는 기본 Sprite Index")]
    private int defaultSpriteIndex = 0;


    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class의 기본 아이템 아이디
    /// </summary>
    public Material Material => material;
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class의 기본 이름
    /// </summary>
    public string DefaultName => defaultName;
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class의 기본 설명
    /// </summary>
    public string DefaultDescription => defaultDescription;
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class가 한 스택 당 최대 쌓을 수 있는 아이템 개수
    /// </summary>
    public int DefaultMaxStackAmount => defaultMaxStackAmount;
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class가 갖는 기본 Sprite 배열
    /// </summary>
    public Sprite[] DefaultSprites => defaultSprites;
    /// <summary>
    /// 이 ItemData를 갖는 Wrapper Class가 갖는 기본 Sprite Index
    /// </summary>
    public int DefaultSpriteIndex => defaultSpriteIndex;
}
