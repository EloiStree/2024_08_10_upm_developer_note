namespace Eloi.Note {
    public class GitHubIssues : LinkNoteMono
    {
        private void Reset()
        {
            m_link = new NoteLink.NamedLink("GitHub Issue", "https://github.com/USER/REPO/issues");
        }
    }
}

