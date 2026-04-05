namespace Eloi.Note
{
    public class Twitch : LinkNoteMono
    {
        public Twitch()
        {
        }

        private void Reset()
        {
            m_link = new NoteLink.NamedLink("Twitch", "https://www.twitch.tv/USERNAME");
        }

    }

    
}