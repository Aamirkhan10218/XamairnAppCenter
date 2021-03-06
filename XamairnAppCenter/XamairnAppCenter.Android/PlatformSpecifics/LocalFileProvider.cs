﻿using System.IO;
using System.Threading.Tasks;
using XamairnAppCenter.Droid.PlatformSpecifics;
using XamairnAppCenter.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocalFileProvider))]
namespace XamairnAppCenter.Droid.PlatformSpecifics
{
    public class LocalFileProvider : ILocalFileProvider
    {
        //[System.Obsolete]
        //private readonly string _rootDir = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.Path, "DBR");

        public async Task<string> SaveFileToDisk(Stream pdfStream, string fileName)
        {



            //if (!Directory.Exists(_rootDir))
            //    Directory.CreateDirectory(_rootDir);

            var _rootDir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            // var libFolder = Path.Combine(_rootDir, fileName);

            var filePath = Path.Combine(_rootDir, fileName);

            using (var memoryStream = new MemoryStream())
            {
                await pdfStream.CopyToAsync(memoryStream);
                File.WriteAllBytes(filePath, memoryStream.ToArray());
            }

            return filePath;
        }
    }
}