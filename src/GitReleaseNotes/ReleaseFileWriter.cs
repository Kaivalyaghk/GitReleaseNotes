namespace GitReleaseNotes
{
    public class ReleaseFileWriter
    {
        private readonly IFileSystem _fileSystem;

        public ReleaseFileWriter(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public void OutputReleaseNotesFile(string releaseNotesOutput, string outputFile)
        {
            if (string.IsNullOrEmpty(outputFile))
                return;
            _fileSystem.WriteAllText(outputFile, releaseNotesOutput);
        }
    }
}