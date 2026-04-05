using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Eloi.Note
{
    [CustomEditor(typeof(ImageInProject), true)]
    public class NoteEditor_ImageInProject : Editor
    {


        public override void OnInspectorGUI()
        {
            ImageInProject myScript = (ImageInProject)target;
            DeveloperNoteEditorImageUtility.DrawImage(myScript.m_note.m_image, () => { DeveloperNoteEditorImageUtility.OpenInBrowser(myScript.m_note.m_image); });
            base.DrawDefaultInspector();
        }
    }
}
