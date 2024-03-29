﻿/************************************************************************************
* Responsible for creating, accessing, deleting, local device storage folders,      *
*   reading from, writing to local device storage files.                            *
* https://github.com/dsplaisted/PCLStorage                                          *
*************************************************************************************/
using System.Threading.Tasks;
using PCLStorage;

namespace ToDo.Services
{
    public class DataStorage
    {
        public static async Task WriteToFileAsync(string fileName, string contents = "")
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder dataFolder = await rootFolder.CreateFolderAsync(VariablesGlobal.NAME_FOLDER_DATA, CreationCollisionOption.OpenIfExists);
            IFile dataFile = await dataFolder.CreateFileAsync(VariablesGlobal.NAME_FILE_DATA, CreationCollisionOption.ReplaceExisting);

            await dataFile.WriteAllTextAsync(contents);
        }

        public static async Task<string> ReadFromFileAsync(string fileName)
        {
            string contents = "";

            IFile dataFile = await GetDataFileAsync(fileName);

            if (dataFile != null)
            {
                contents = await dataFile.ReadAllTextAsync();
            }

            return contents;
        }

        public static async void DeleteFileAsync(string fileName)
        {
            IFile dataFile = await GetDataFileAsync(fileName);

            if (dataFile != null)
            {
                await dataFile.DeleteAsync();
            }
        }


        private static async Task<IFile> GetDataFileAsync(string fileName)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = rootFolder ?? FileSystem.Current.LocalStorage;

            ExistenceCheckResult dataFolderExists = await folder.CheckExistsAsync(VariablesGlobal.NAME_FOLDER_DATA);
            if (dataFolderExists == ExistenceCheckResult.FolderExists)
            {
                IFolder dataFolder = await rootFolder.GetFolderAsync(VariablesGlobal.NAME_FOLDER_DATA);

                ExistenceCheckResult fileExists = await dataFolder.CheckExistsAsync(fileName);
                if (fileExists == ExistenceCheckResult.FileExists)
                {
                    return await dataFolder.GetFileAsync(fileName);
                }
            }

            return null;
        }
    }
}