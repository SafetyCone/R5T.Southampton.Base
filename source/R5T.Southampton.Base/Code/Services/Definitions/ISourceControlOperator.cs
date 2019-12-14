using System;


namespace R5T.Southampton
{
    public interface ISourceControlOperator
    {
        void Checkout(string repositoryUrl, string localDirectoryPath);
    }
}
