﻿using System.Collections.Generic;
using Microsoft.WindowsAzure.Storage.Blob;

namespace WhiteLabel.Data.Azure.Base
{
    public interface IBlobStorageRepository
    {
        IEnumerable<IListBlobItem> FindAll(CloudBlobContainer container);
        CloudBlockBlob Get(string fileName, string containerName);
        CloudBlobContainer GetContainer(string containerName);
    }
}