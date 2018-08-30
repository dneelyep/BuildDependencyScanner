using Core.Domain;
using NDepend.Path;
using System;

namespace Core.BuildDependencyDocumentParser
{
    public class BuildDependencyDocumentParser
    {
        public const string FileExtension = ".bdd";

        public BuildDependencyDocument Parse(IFilePath documentFilePath)
        {
            if (documentFilePath == null)
            {
                throw new ArgumentNullException(nameof(documentFilePath));
            }

            if (documentFilePath.FileExtension != FileExtension)
            {
                throw new ArgumentException($"Invalid file extension: {documentFilePath.FileExtension}");
            }

            return null;
        }
    }
}