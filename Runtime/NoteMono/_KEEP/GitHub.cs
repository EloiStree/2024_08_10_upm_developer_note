namespace Eloi.Note {
    public class GitHub : LinkNoteMono
    {
        private void Reset()
        {
            m_link = new NoteLink.NamedLink("GitHub", "https://github.com/USERNAME");
        }
    }
}

