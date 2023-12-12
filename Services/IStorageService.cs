using Supabase.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest2.Services
{
    public interface IStorageService
    {
        public Task<IEnumerable<String>> GetAllBuckets();
        public Task<IEnumerable<String>> GetBuckets();
        public Task<IEnumerable<byte[]>> GetFilesFromBucket(String bucket);
        public Task<byte[]> GetFileFromBucket(String bucket, String filename);
    }
}
