namespace Eloi.Note
{
    public class Bluesky : LinkNoteMono
    {
        private void Reset()
        {
            m_link = new NoteLink.NamedLink("Bluesky", "https://@USERNAME.bsky.social");
        }

    }
    
}