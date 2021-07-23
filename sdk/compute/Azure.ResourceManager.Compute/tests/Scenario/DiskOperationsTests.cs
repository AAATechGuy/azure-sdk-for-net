﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute.Tests.Helpers;
using NUnit.Framework;

namespace Azure.ResourceManager.Compute.Tests
{
    public class DiskOperationsTests : ComputeTestBase
    {
        public DiskOperationsTests(bool isAsync)
            : base(isAsync)//, RecordedTestMode.Record)
        {
        }

        private async Task<Disk> CreateDiskAsync(string diskName)
        {
            var container = (await CreateResourceGroupAsync()).GetDisks();
            var input = DiskHelper.GetEmptyDiskData(DefaultLocation, new Dictionary<string, string>() { { "key", "value" } });
            return await container.CreateOrUpdateAsync(diskName, input);
        }

        [TestCase]
        [RecordedTest]
        public async Task Delete()
        {
            var diskName = Recording.GenerateAssetName("testDisk-");
            var disk = await CreateDiskAsync(diskName);
            await disk.DeleteAsync();
        }

        [TestCase]
        [RecordedTest]
        public async Task StartDelete()
        {
            var diskName = Recording.GenerateAssetName("testDisk-");
            var disk = await CreateDiskAsync(diskName);
            var deleteOp = await disk.StartDeleteAsync();
            await deleteOp.WaitForCompletionResponseAsync();
        }

        [TestCase]
        [RecordedTest]
        public async Task Get()
        {
            var diskName = Recording.GenerateAssetName("testDisk-");
            var disk1 = await CreateDiskAsync(diskName);
            Disk disk2 = await disk1.GetAsync();

            DiskHelper.AssertDisk(disk1.Data, disk2.Data);
        }
    }
}
