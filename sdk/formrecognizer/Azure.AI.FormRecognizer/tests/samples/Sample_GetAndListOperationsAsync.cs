﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer.DocumentAnalysis.Tests;
using Azure.Core.TestFramework;

namespace Azure.AI.FormRecognizer.DocumentAnalysis.Samples
{
    public partial class DocumentAnalysisSamples : SamplesBase<DocumentAnalysisTestEnvironment>
    {
        [RecordedTest]
        public async Task GetAndListOperationsAsync()
        {
            string endpoint = TestEnvironment.Endpoint;
            string apiKey = TestEnvironment.ApiKey;

            #region Snippet:FormRecognizerSampleGetAndListOperations

            var client = new DocumentModelAdministrationClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            // Make sure there is at least one operation, so we are going to build a custom model.
#if SNIPPET
            Uri blobContainerUri = new Uri("<blobContainerUri>");
#else
            Uri blobContainerUri = new Uri(TestEnvironment.BlobContainerSasUrl);
#endif
            BuildDocumentModelOperation operation = await client.BuildDocumentModelAsync(WaitUntil.Completed, blobContainerUri, DocumentBuildMode.Template);

            // List the first ten or fewer operations that have been executed in the last 24h.
            AsyncPageable<OperationSummary> operationSummaries = client.GetOperationsAsync();

            string operationId = string.Empty;
            int count = 0;
            await foreach (OperationSummary operationSummary in operationSummaries)
            {
                Console.WriteLine($"Model operation summary:");
                Console.WriteLine($"  Id: {operationSummary.OperationId}");
                Console.WriteLine($"  Kind: {operationSummary.Kind}");
                Console.WriteLine($"  Status: {operationSummary.Status}");
                Console.WriteLine($"  Percent completed: {operationSummary.PercentCompleted}");
                Console.WriteLine($"  Created on: {operationSummary.CreatedOn}");
                Console.WriteLine($"  LastUpdated on: {operationSummary.LastUpdatedOn}");
                Console.WriteLine($"  Resource location of successful operation: {operationSummary.ResourceLocation}");

                if (count == 0)
                    operationId = operationSummary.OperationId;

                if (++count == 10)
                    break;
            }

            // Get an operation by ID
            OperationDetails operationDetails = await client.GetOperationAsync(operationId);

            if (operationDetails.Status == DocumentOperationStatus.Succeeded)
            {
                Console.WriteLine($"My {operationDetails.Kind} operation is completed.");

                // Extract the result based on the kind of operation. Currently only Build, CopyTo, and
                // Compose operations are supported.
                DocumentModelDetails result = operationDetails switch
                {
                    DocumentModelBuildOperationDetails buildOp => buildOp.Result,
                    DocumentModelCopyToOperationDetails copyToOp => copyToOp.Result,
                    DocumentModelComposeOperationDetails composeOp => composeOp.Result,
                    _ => null
                };

                if (result != null)
                {
                    Console.WriteLine($"Model ID: {result.ModelId}");
                }
            }
            else if (operationDetails.Status == DocumentOperationStatus.Failed)
            {
                Console.WriteLine($"My {operationDetails.Kind} operation failed.");
                ResponseError error = operationDetails.Error;
                Console.WriteLine($"Code: {error.Code}: Message: {error.Message}");
            }
            else
                Console.WriteLine($"My {operationDetails.Kind} operation status is {operationDetails.Status}");
            #endregion
        }
    }
}
