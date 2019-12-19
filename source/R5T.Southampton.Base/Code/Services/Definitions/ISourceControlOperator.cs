using System;


namespace R5T.Southampton
{
    public interface ISourceControlOperator
    {
        void Add(string path);
        void Checkout(string repositoryUrl, string localDirectoryPath);
        void CommitToRemote(string path, string message);
        /// <summary>
        /// Given a path in a repository, return the repository root directory path.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        string GetRepositoryRootDirectoryPath(string path);
        bool IsUnderSourceControl(string path);
        void Update(string path);
    }
}
