using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RemoveComponentName))]
public class RemoveComponentNameEditor : Editor {

  public override void OnInspectorGUI() {
    DrawDefaultInspector();

    RemoveComponentName rmc = (RemoveComponentName)target;

    if (GUILayout.Button("Remove ComponentName")) {
      rmc.RemoveComponents();
    }
  }
}