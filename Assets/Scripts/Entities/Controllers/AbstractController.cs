using UnityEngine;

namespace EntitySystem.Controllers
{
    /// <summary>
    /// Entity의 Controller를 정의하는 추상 클래스
    /// </summary>
    public abstract class AbstractController : ScriptableObject
    {
        /// <summary>
        /// Controller의 유형
        /// </summary>
        [SerializeField] protected Type type;

        /// <summary>
        /// Controller의 유형 (변경 불가능)
        /// </summary>
        public Type Type => type;

        /// <summary>
        /// Controller의 동작을 정의하는 메서드
        /// </summary>
        public abstract void Execute();
    }
}