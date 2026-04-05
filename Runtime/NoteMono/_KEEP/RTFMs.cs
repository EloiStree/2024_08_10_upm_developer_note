using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Eloi.Note
{

    public class RTFMs : LinksNoteMono
    {
        [ContextMenu("Open RTFM")]
        public void OpenRTFM() {
            base.OpenLinks();
        }
    }
}
