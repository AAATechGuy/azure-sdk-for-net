// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Language.Conversations.Authoring;
using Azure.AI.Language.Conversations.Authoring.Models;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Language.Conversations.Authoring.Tests.Samples
{
    public partial class Sample9_ConversationsAuthoring_GetModelEvaluationResultsAsync : SamplesBase<AuthoringClientTestEnvironment>
    {
        [Test]
        [AsyncOnly]
        public async Task GetModelEvaluationResultsAsync()
        {
            Uri endpoint = TestEnvironment.Endpoint;
            AzureKeyCredential credential = new(TestEnvironment.ApiKey);
            ConversationAnalysisAuthoringClient client = new ConversationAnalysisAuthoringClient(endpoint, credential);

            #region Snippet:Sample9_ConversationsAuthoring_GetModelEvaluationResultsAsync
            string projectName = "SampleProject";
            string trainedModelLabel = "SampleModel";
            ConversationAuthoringTrainedModel trainedModelClient = client.GetTrainedModel(projectName, trainedModelLabel);
            StringIndexType stringIndexType = StringIndexType.Utf16CodeUnit;

            AsyncPageable<UtteranceEvaluationResult> results = trainedModelClient.GetModelEvaluationResultsAsync(
                stringIndexType: stringIndexType
            );

            await foreach (UtteranceEvaluationResult result in results)
            {
                Console.WriteLine($"Text: {result.Text}");
                Console.WriteLine($"Language: {result.Language}");

                // Print intents result
                Console.WriteLine($"Expected Intent: {result.IntentsResult.ExpectedIntent}");
                Console.WriteLine($"Predicted Intent: {result.IntentsResult.PredictedIntent}");

                // Print entities result
                Console.WriteLine("Expected Entities:");
                foreach (UtteranceEntityEvaluationResult entity in result.EntitiesResult.ExpectedEntities)
                {
                    Console.WriteLine($" - Category: {entity.Category}, Offset: {entity.Offset}, Length: {entity.Length}");
                }

                Console.WriteLine("Predicted Entities:");
                foreach (UtteranceEntityEvaluationResult entity in result.EntitiesResult.PredictedEntities)
                {
                    Console.WriteLine($" - Category: {entity.Category}, Offset: {entity.Offset}, Length: {entity.Length}");
                }

                Console.WriteLine();
            }
            #endregion
        }
    }
}
