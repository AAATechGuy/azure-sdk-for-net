// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridContainerService;
using Azure.ResourceManager.HybridContainerService.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridContainerService.Samples
{
    public partial class Sample_HybridContainerServiceVirtualNetworkCollection
    {
        // GetVirtualNetwork
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVirtualNetwork()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/stable/2024-01-01/examples/GetVirtualNetwork.json
            // this example is just showing the usage of "virtualNetworks_Retrieve" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a3e42606-29b1-4d7d-b1d9-9ff6b9d3c71b";
            string resourceGroupName = "test-arcappliance-resgrp";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridContainerServiceVirtualNetworkResource
            HybridContainerServiceVirtualNetworkCollection collection = resourceGroupResource.GetHybridContainerServiceVirtualNetworks();

            // invoke the operation
            string virtualNetworkName = "test-vnet-static";
            HybridContainerServiceVirtualNetworkResource result = await collection.GetAsync(virtualNetworkName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridContainerServiceVirtualNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GetVirtualNetwork
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetVirtualNetwork()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/stable/2024-01-01/examples/GetVirtualNetwork.json
            // this example is just showing the usage of "virtualNetworks_Retrieve" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a3e42606-29b1-4d7d-b1d9-9ff6b9d3c71b";
            string resourceGroupName = "test-arcappliance-resgrp";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridContainerServiceVirtualNetworkResource
            HybridContainerServiceVirtualNetworkCollection collection = resourceGroupResource.GetHybridContainerServiceVirtualNetworks();

            // invoke the operation
            string virtualNetworkName = "test-vnet-static";
            bool result = await collection.ExistsAsync(virtualNetworkName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // GetVirtualNetwork
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetVirtualNetwork()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/stable/2024-01-01/examples/GetVirtualNetwork.json
            // this example is just showing the usage of "virtualNetworks_Retrieve" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a3e42606-29b1-4d7d-b1d9-9ff6b9d3c71b";
            string resourceGroupName = "test-arcappliance-resgrp";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridContainerServiceVirtualNetworkResource
            HybridContainerServiceVirtualNetworkCollection collection = resourceGroupResource.GetHybridContainerServiceVirtualNetworks();

            // invoke the operation
            string virtualNetworkName = "test-vnet-static";
            NullableResponse<HybridContainerServiceVirtualNetworkResource> response = await collection.GetIfExistsAsync(virtualNetworkName);
            HybridContainerServiceVirtualNetworkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridContainerServiceVirtualNetworkData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PutVirtualNetwork
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PutVirtualNetwork()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/stable/2024-01-01/examples/PutVirtualNetwork.json
            // this example is just showing the usage of "virtualNetworks_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a3e42606-29b1-4d7d-b1d9-9ff6b9d3c71b";
            string resourceGroupName = "test-arcappliance-resgrp";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridContainerServiceVirtualNetworkResource
            HybridContainerServiceVirtualNetworkCollection collection = resourceGroupResource.GetHybridContainerServiceVirtualNetworks();

            // invoke the operation
            string virtualNetworkName = "test-vnet-static";
            HybridContainerServiceVirtualNetworkData data = new HybridContainerServiceVirtualNetworkData(new AzureLocation("westus"))
            {
                Properties = new HybridContainerServiceVirtualNetworkProperties()
                {
                    InfraVnetHci = new HciInfraVnetProfile()
                    {
                        MocGroup = "target-group",
                        MocLocation = "MocLocation",
                        MocVnetName = "vnet1",
                    },
                    VipPool =
{
new KubernetesVirtualIPItem()
{
EndIP = "192.168.0.50",
StartIP = "192.168.0.10",
}
},
                    VmipPool =
{
new VirtualMachineIPItem()
{
EndIP = "192.168.0.130",
StartIP = "192.168.0.110",
}
},
                    DnsServers =
{
"192.168.0.1"
},
                    Gateway = "192.168.0.1",
                    IPAddressPrefix = "192.168.0.0/16",
                    VlanId = 10,
                },
                ExtendedLocation = new HybridContainerServiceExtendedLocation()
                {
                    ExtendedLocationType = HybridContainerServiceExtendedLocationType.CustomLocation,
                    Name = "/subscriptions/a3e42606-29b1-4d7d-b1d9-9ff6b9d3c71b/resourcegroups/test-arcappliance-resgrp/providers/microsoft.extendedlocation/customlocations/testcustomlocation",
                },
            };
            ArmOperation<HybridContainerServiceVirtualNetworkResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, virtualNetworkName, data);
            HybridContainerServiceVirtualNetworkResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridContainerServiceVirtualNetworkData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ListVirtualNetworkByResourceGroup
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListVirtualNetworkByResourceGroup()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/stable/2024-01-01/examples/ListVirtualNetworkByResourceGroup.json
            // this example is just showing the usage of "virtualNetworks_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "a3e42606-29b1-4d7d-b1d9-9ff6b9d3c71b";
            string resourceGroupName = "test-arcappliance-resgrp";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this HybridContainerServiceVirtualNetworkResource
            HybridContainerServiceVirtualNetworkCollection collection = resourceGroupResource.GetHybridContainerServiceVirtualNetworks();

            // invoke the operation and iterate over the result
            await foreach (HybridContainerServiceVirtualNetworkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                HybridContainerServiceVirtualNetworkData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
