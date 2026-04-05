namespace Eloi.Note
{
    public class YoutubeChannel : LinkNoteMono
    {
        private void Reset()
        {
            m_link = new NoteLink.NamedLink("Youtube", "https://www.youtube.com/@USERNAME");
        }

    }

    
}