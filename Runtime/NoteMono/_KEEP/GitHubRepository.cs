namespace Eloi.Note {
    public class GitHubRepository : LinkNoteMono
    {
        private void Reset()
        {
            m_link = new NoteLink.NamedLink("GitHub Repository", "https://github.com/USER/REPOSITORY");
        }
    }
}

