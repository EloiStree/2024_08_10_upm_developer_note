using Eloi.Note;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Eloi.Note
{
    [CustomEditor(typeof(YoutubeVideo))]
    public class NoteEditor_YoutubeVideo : Editor
    {


        public override void OnInspectorGUI()
        {

            YoutubeVideo myScript = (YoutubeVideo)target;
            
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Open on Youtube"))
            {
                myScript.OpenYoutube();
            }
            GUILayout.EndHorizontal();
            base.DrawDefaultInspector();
        }
    }
}
