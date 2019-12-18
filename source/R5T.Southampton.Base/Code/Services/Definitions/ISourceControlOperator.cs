using System;


namespace R5T.Southampton
{
    public interface ISourceControlOperator
    {
        void Add(string localPath);
        void Checkout(string repositoryUrl, string localDirectoryPath);
        void CommitToRemote(string localPath, string message);
    }
}
