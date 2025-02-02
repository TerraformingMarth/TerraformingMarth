using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Core.PropertyDrawers
{
    [CustomPropertyDrawer(typeof(Core.Collections.Serializable.Dictionary<,>), true)]
    public class DictionaryPropertyDrawer: PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.LabelField(position, label);

            position.y += EditorGUIUtility.singleLineHeight;
            EditorGUI.PropertyField(position, property.FindPropertyRelative("keys"), true);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (!property.isExpanded)
                return EditorGUIUtility.singleLineHeight;

            SerializedProperty keys = property.FindPropertyRelative("keys");
            return EditorGUIUtility.singleLineHeight * (keys.arraySize + 2);
        }
    }
}
