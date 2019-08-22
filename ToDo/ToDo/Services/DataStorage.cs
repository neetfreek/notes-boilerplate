/************************************************************************************
* Responsible for creating, accessing, deleting, local device storage folders,      *
*   reading from, writing to local device storage files.                            *
* https://github.com/dsplaisted/PCLStorage                                          *
*************************************************************************************/
using System.Threading.Tasks;
using PCLStorage;

namespace ToDo.Services
{
    class DataStorage
    {
        IFolder rootFolder = FileSystem.Current.LocalStorage;


        private async Task<IFile> GetDataFileAsync()
        {
            IFolder folder = await rootFolder.CreateFolderAsync("ToDoDataFolder", CreationCollisionOption.OpenIfExists);
            IFile fileSave = await rootFolder.CreateFileAsync("todoDateFile", CreationCollisionOption.ReplaceExisting);

            return fileSave;
        }

        private async void DeleteFileAsync(string fileName, IFolder rootFolder = null)
        {
            if (await CheckFileExistsAsync(fileName))
            {
                IFile fileToDelete = await rootFolder.GetFileAsync(fileName);
                await fileToDelete.DeleteAsync();
            }
        }

        private async Task<bool> CheckFileExistsAsync(string fileName)
        {
            IFolder folder = rootFolder ?? FileSystem.Current.LocalStorage;
            ExistenceCheckResult fileExists = await folder.CheckExistsAsync(fileName);
            if (fileExists == ExistenceCheckResult.FileExists)
            {
                return true;
            }

            return false;
        }

