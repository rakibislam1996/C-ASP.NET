using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    // Violating DIP
    public class Handler
    {
        FileSystemManager fileSystemManager = new FileSystemManager();
        public void Handle()
        {
            fileSystemManager.Save();
        }
    }
    public class FileSystemManager
    {
        public void Save()
        {
            // Do Something
        }
    }
    // In the above segment  higher-level class Handler is directly
    // depending upon the lower level FileSystemManager class.

    // Supporting DIP
    public interface IStorage
    {
        public void Save();
    }
    public class HandlerModified
    {
        private readonly IStorage _storage;
        public HandlerModified(IStorage storage)
        {
            _storage = storage;
        }
        public void Handle()
        {
            _storage.Save();
        }
    }
    public class FileSystemManagerModified : IStorage
    {
        public void Save()
        {
            // Do Something
        }
    }
}
