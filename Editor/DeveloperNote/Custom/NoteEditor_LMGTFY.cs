using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Eloi.Note
{
    [CustomEditor(typeof(LMGTFY))]
    public class NoteEditor_LMGTFY : Editor
    {


        public override void OnInspectorGUI()
        {
            LMGTFY myScript = (LMGTFY)target;

            if (GUILayout.Button("Let's me google that for you"))
            {
                myScript.OpenLMGTFY();
            }
            
           
            base.DrawDefaultInspector();
        }
    }
}
