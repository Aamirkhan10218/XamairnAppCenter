﻿using System.IO;
using System.Threading.Tasks;

namespace XamairnAppCenter.Interfaces
{
    public interface ILocalFileProvider
    {
        Task<string> SaveFileToDisk(Stream stream, string fileName);
    }
}