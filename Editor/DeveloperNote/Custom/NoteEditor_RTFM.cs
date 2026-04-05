using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Eloi.Note
{
    [CustomEditor(typeof(RTFMs))]
    public class NoteEditor_RTFM : Editor
    {
        public override void OnInspectorGUI()
        {
            RTFMs myScript = (RTFMs)target;

            NoteEditor_Links.DrawLinks(myScript, "Read the manuals");
          
            base.DrawDefaultInspector();
        }
    }
}
