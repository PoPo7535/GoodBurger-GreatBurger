#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ReadOnlyAttribute))]

public class ReadOnlyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        GUI.enabled = false; // 비활성화 상태로 렌더링 (읽기 전용)
        EditorGUI.PropertyField(position, property, label, true);
        GUI.enabled = true;  // 원래대로 복구
    }
}
#endif
