using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Eloi.Note
{
    [CustomEditor(typeof(GoogleSearch), true)]
    public class NoteEditor_KeyWordsToGoogle : Editor
    {


        public override void OnInspectorGUI()
        {
            GoogleSearch myScript = (GoogleSearch)target;
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Google"))
            {
                myScript.SearchOnGoogle();
            }
            if (GUILayout.Button("Duck Duck"))
            {
                myScript.SearchOnDuckDuck();
            }
            if (GUILayout.Button("All"))
            {
                myScript.SearchOnAll();
            }
            GUILayout.EndHorizontal();
            base.DrawDefaultInspector();
        }
    }
}
