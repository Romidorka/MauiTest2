using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest2.Services
{
    public class StorageService : IStorageService
    {
        private Supabase.Client _client;

        public StorageService(Supabase.Client client)
        {
            _client = client;
        }

        async public Task<IEnumerable<string>> GetAllBuckets()
        {
            var buckets = await _client.Storage.ListBuckets();
            return buckets.Select(it => it.Name);
        }

        async public Task<IEnumerable<string>> GetBuckets()
        {
            var buckets = await _client.Storage.ListBuckets();
            return (IEnumerable<string>)buckets;
        }

        async public Task<byte[]> GetFileFromBucket(string bucket, string filename)
        {
            var file = await _client.Storage.From("bucket").Download(filename, null);
            return file;
        }

        async public Task<IEnumerable<byte[]>> GetFilesFromBucket(string bucket)
        {
            var files = await _client.Storage.From(bucket).List();
            return (IEnumerable<byte[]>)files;
        }
    }
}
