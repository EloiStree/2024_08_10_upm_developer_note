using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace Eloi.Note
{
    [CustomEditor(typeof(YoutubeThumbnail))]
    public class NoteEditor_YoutubeVideoWithThumbnail : Editor
    {

        //https://www.youtube.com/watch?v=s6TMa33niJo&t=133s
        public override void OnInspectorGUI()
        {
            YoutubeThumbnail myScript = (YoutubeThumbnail)target;
            if (myScript.m_link.m_thumbnail != null)
                DeveloperNoteEditorImageUtility.DrawImage(myScript.m_link.m_thumbnail, Open);
            if (GUILayout.Button("Open On youtube"))
            {
                myScript.OpenYoutube();
            }
            base.DrawDefaultInspector();
        }

        private void Open()
        {
            YoutubeThumbnail myScript = (YoutubeThumbnail)target;
            myScript.OpenYoutube();

        }

    }
}
