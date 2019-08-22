/************************************************************************************
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
        public static async void WriteToFileAsync(string fileName, string contents = "")
        {
            IFile fileSave = await GetDataFileAsync();
            await fileSave.WriteAllTextAsync(contents);
        }

        public static async Task<string> ReadFromFileAsync()
        {
            string content = "";
            IFile fileSave = await GetDataFileAsync();
            content = await fileSave.ReadAllTextAsync();

            return content;
        }

        private static async Task<IFile> GetDataFileAsync()
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;

            IFolder folder = await rootFolder.CreateFolderAsync(VariablesGlobal.NAME_FOLDER_DATA, CreationCollisionOption.OpenIfExists);
            IFile fileSave = await rootFolder.CreateFileAsync(VariablesGlobal.NAME_FILE_DATA, CreationCollisionOption.ReplaceExisting);

            return fileSave;
        }

        private static async void DeleteFileAsync(string fileName, IFolder rootFolder = null)
        {
            if (await CheckFileExistsAsync(fileName))
            {
                IFile fileToDelete = await rootFolder.GetFileAsync(fileName);
                await fileToDelete.DeleteAsync();
            }
        }

        private static async Task<bool> CheckFileExistsAsync(string fileName)
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;

            IFolder folder = rootFolder ?? FileSystem.Current.LocalStorage;
            ExistenceCheckResult fileExists = await folder.CheckExistsAsync(fileName);
            if (fileExists == ExistenceCheckResult.FileExists)
            {
                return true;
            }

            return false;
        }
    }
}