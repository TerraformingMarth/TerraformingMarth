namespace Core
{
    /// <summary>
    /// Project 내에서 사용할 상수들을 모아놓은 Static Class
    /// </summary>
    public static class Macros
    {
        /// <summary>
        /// <para>Foldout을 그릴 때 label과 icon 사이의 공백</para>
        /// <para>도대체 왜 이 문자인지 나는 모르겠음</para>
        /// <para>그냥 일반 공백 문자처럼 Visual Studio 상에서 보일건데 전혀 같은거 아님</para>
        /// </summary>
        public const string INSPECTOR_FOLDOUT_SPACE = " ";

        /// <summary>
        /// Inspector에서 Prefix를 그릴 때 사용 할 공백
        /// </summary>
        public const int INSPECTOR_PREFIX_SPACE = 10;

        /// <summary>
        /// Inspector에서 Indent 기본 크기
        /// </summary>
        public const int INSPECTOR_INDENT_SPACE = 15;
    }
}