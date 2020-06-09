using System;


namespace R5T.Southampton
{
    public interface ISourceControlOperator
    {
        void Add(string path);
        void Checkout(string repositoryUrl, string localDirectoryPath, string username, string password);
        void CommitToRemote(string path, string message);
        /// <summary>
        /// Gets information about the source-control operator.
        /// </summary>
        /// <returns></returns>
        SourceControlOperatorInformation GetOperatorInformation();
        /// <summary>
        /// Gets the repository URL for the repository in which <paramref name="path"/> is tracked.
        /// </summary>
        string GetRemoteRepositoryUrl(string path);
        /// <summary>
        /// Given a path in a repository, return the repository root directory path.
        /// </summary>
        string GetRepositoryRootDirectoryPath(string path);
        bool IsUnderSourceControl(string path);
        void Update(string path);
    }
}
