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
using Azure.ResourceManager.SpringAppDiscovery;

namespace Azure.ResourceManager.SpringAppDiscovery.Samples
{
    public partial class Sample_SpringBootSiteSummaryCollection
    {
        // Summaries_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SummariesGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/Summaries_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "libzegdqkcxmhqhhhcxm";
            string resourceGroupName = "rgspringbootdiscovery";
            string siteName = "xxkzlvbihwxunadjcpjpjmghmhxrqyvghtpfps";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootSiteSummaryResource
            SpringBootSiteSummaryCollection collection = springBootSite.GetSpringBootSiteSummaries();

            // invoke the operation
            string summaryName = "vjB";
            SpringBootSiteSummaryResource result = await collection.GetAsync(summaryName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootSiteSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Summaries_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SummariesGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/Summaries_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "libzegdqkcxmhqhhhcxm";
            string resourceGroupName = "rgspringbootdiscovery";
            string siteName = "xxkzlvbihwxunadjcpjpjmghmhxrqyvghtpfps";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootSiteSummaryResource
            SpringBootSiteSummaryCollection collection = springBootSite.GetSpringBootSiteSummaries();

            // invoke the operation
            string summaryName = "vjB";
            bool result = await collection.ExistsAsync(summaryName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Summaries_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SummariesGetMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/Summaries_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "libzegdqkcxmhqhhhcxm";
            string resourceGroupName = "rgspringbootdiscovery";
            string siteName = "xxkzlvbihwxunadjcpjpjmghmhxrqyvghtpfps";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootSiteSummaryResource
            SpringBootSiteSummaryCollection collection = springBootSite.GetSpringBootSiteSummaries();

            // invoke the operation
            string summaryName = "vjB";
            NullableResponse<SpringBootSiteSummaryResource> response = await collection.GetIfExistsAsync(summaryName);
            SpringBootSiteSummaryResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootSiteSummaryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Summaries_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SummariesGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/Summaries_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "libzegdqkcxmhqhhhcxm";
            string resourceGroupName = "rgspringbootdiscovery";
            string siteName = "xxkzlvbihwxunadjcpjpjmghmhxrqyvghtpfps";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootSiteSummaryResource
            SpringBootSiteSummaryCollection collection = springBootSite.GetSpringBootSiteSummaries();

            // invoke the operation
            string summaryName = "vjB";
            SpringBootSiteSummaryResource result = await collection.GetAsync(summaryName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SpringBootSiteSummaryData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Summaries_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SummariesGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/Summaries_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "libzegdqkcxmhqhhhcxm";
            string resourceGroupName = "rgspringbootdiscovery";
            string siteName = "xxkzlvbihwxunadjcpjpjmghmhxrqyvghtpfps";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootSiteSummaryResource
            SpringBootSiteSummaryCollection collection = springBootSite.GetSpringBootSiteSummaries();

            // invoke the operation
            string summaryName = "vjB";
            bool result = await collection.ExistsAsync(summaryName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Summaries_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SummariesGetMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/Summaries_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Summaries_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "libzegdqkcxmhqhhhcxm";
            string resourceGroupName = "rgspringbootdiscovery";
            string siteName = "xxkzlvbihwxunadjcpjpjmghmhxrqyvghtpfps";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootSiteSummaryResource
            SpringBootSiteSummaryCollection collection = springBootSite.GetSpringBootSiteSummaries();

            // invoke the operation
            string summaryName = "vjB";
            NullableResponse<SpringBootSiteSummaryResource> response = await collection.GetIfExistsAsync(summaryName);
            SpringBootSiteSummaryResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootSiteSummaryData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Summaries_ListBySite_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SummariesListBySiteMaximumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/Summaries_ListBySite_MaximumSet_Gen.json
            // this example is just showing the usage of "Summaries_ListBySite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "libzegdqkcxmhqhhhcxm";
            string resourceGroupName = "rgspringbootdiscovery";
            string siteName = "xxkzlvbihwxunadjcpjpjmghmhxrqyvghtpfps";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootSiteSummaryResource
            SpringBootSiteSummaryCollection collection = springBootSite.GetSpringBootSiteSummaries();

            // invoke the operation and iterate over the result
            await foreach (SpringBootSiteSummaryResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootSiteSummaryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Summaries_ListBySite_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SummariesListBySiteMinimumSetGen()
        {
            // Generated from example definition: specification/offazurespringboot/resource-manager/Microsoft.OffAzureSpringBoot/preview/2023-01-01-preview/examples/Summaries_ListBySite_MinimumSet_Gen.json
            // this example is just showing the usage of "Summaries_ListBySite" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SpringBootSiteResource created on azure
            // for more information of creating SpringBootSiteResource, please refer to the document of SpringBootSiteResource
            string subscriptionId = "libzegdqkcxmhqhhhcxm";
            string resourceGroupName = "rgspringbootdiscovery";
            string siteName = "xxkzlvbihwxunadjcpjpjmghmhxrqyvghtpfps";
            ResourceIdentifier springBootSiteResourceId = SpringBootSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            SpringBootSiteResource springBootSite = client.GetSpringBootSiteResource(springBootSiteResourceId);

            // get the collection of this SpringBootSiteSummaryResource
            SpringBootSiteSummaryCollection collection = springBootSite.GetSpringBootSiteSummaries();

            // invoke the operation and iterate over the result
            await foreach (SpringBootSiteSummaryResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SpringBootSiteSummaryData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
