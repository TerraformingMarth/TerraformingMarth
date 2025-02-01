using System.Collections.Generic;
using EntitySystem.Controllers;
using UnityEditor;
using UnityEngine;

namespace EntitySystem
{
    /// <summary>
    /// Entity의 공통된 로직과 데이터를 저장하는 ScriptableObject
    /// </summary>
    [CreateAssetMenu(fileName = "NewEntityData", menuName = "Entity Data")]
    public class EntityData : ScriptableObject
    {
        #region id
        /// <summary>
        /// 해당 유형 Entity의 기본 아이디
        /// </summary>
        [SerializeField, Tooltip("해당 유형 Entity의 기본 아이디")]
        protected ID id;

        /// <summary>
        /// Entity의 아이디 (변경 불가능)
        /// </summary>
        public ID ID => id;
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
        [TextArea(3, 5)] protected string defaultDescription;

        /// <summary>
        /// Entity의 기본 설명 (변경 불가능)
        /// </summary>
        public string Description => defaultDescription;
        #endregion

        #region controllers
        /// <summary>
        /// Entity의 Controller를 담아두는 Dictionary
        /// </summary>
        [SerializeField] protected Dictionary<Type, AbstractController> controllers = new Dictionary<Type, AbstractController>();

        /// <summary>
        /// Entity의 Controller를 담아두는 Dictionary
        /// </summary>
        public AbstractController this[Type key]
        {
            get
            {
                if (controllers.TryGetValue(key, out AbstractController value))
                {
                    return value;
                }
                else
                {
                    return null; // 또는 throw new KeyNotFoundException($"Key '{key}' not found.");
                }
            }
        }

        /// <summary>
        /// 유효한 Controller인지 확인하는 메서드
        /// </summary>
        private void isValidController()
        {
            foreach (var controller in controllers)
            {
                if (controller.Key.Equals(controller.Value.Type))
                {
                    //TODO: Exception 처리
                }
            }

        }
        #endregion

        protected void Awake()
        {
            try
            {
                isValidController();
            }
            catch (System.Exception e)
            {
                Debug.LogError(e);
                EditorApplication.isPlaying = false;
            }
            
        }
    }

}

