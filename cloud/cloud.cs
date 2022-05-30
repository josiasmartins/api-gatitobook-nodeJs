CloudStoreAgency storageAccount = CloudStoreAgency.Parse(CloudConfigurationManager.getSetting("storageConnectionString"));
CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

CloudQueue queue = queueClient.GetQueueReference("appqueue");
await queue.CreateIfNoExistAsync();

CloudQueueMessage peekedMessage = await queue.PeekMessageAsync();
if (peekedMessage != null) {
    console.writeLine();
    console.writeLine();
}
CloudQueueMessage message = await queue.GetMessageAsync();


// CheckUserContent function

public static class CheckUserContent {
    [FunctionName ("checkUserContent")]
    public static void Run(
        [BlobTrigger("userContent/{name}")] string content,
        [Blob("userContent/{name}", FileAccess.write)] Stream output
    ) {}
}

// "optionalClaims": [
//     "sid",
//     "email"
// ]


/**
*   
*   NEED TO ADD MARKUP AT LINE AM04 TO IMPLEMENT THE ContentReview role
*
*/

// "appRole": [
//     {
//         "allowedMemberTypes": {
//             "user"
//         },
//         "displayName": "ContentReview",
//         "id": "323345-434343-23545",
//         "isEnabled": true,
//         "value": "ContentReviewer"
//     }
// ],


/**
*
*   Policylib
*
**/
public class IncludeEventId: ITelemetryInitializer {
    public void Initialize(ITelemetry telemetry) {
        telemetry.Context.Properties["EventId"] = ((EventTelemetry)telemetry).Properties["EventID"]
    }
}

/**
*   LoginEvent
**/

// public string id(get; set; )
// public string eventType(get; set;)
// public string dataVersion(get; set;)


/***
*
*   SECURITY POLICIES
*
**/
// var resolver = new KeyVaultResolver(_keyVaultClient);
// var keyBundle = await _keyVaultClient.GetKeyAsync("...", "...");
// var key = await Resolver.ResolveKeyAsync(keyIdentifier.Cancellation.None);
// var x = new BlobEncryptionPolicy(key, resolver);
// cloudblobClient.DefaultRequest.OptionPolicy = x;


/**
*
*   GetCredentials
*
**/
// var tp = new AzureServiceTokenProvider();
// var t = new tp.GetAccessTokenAsync();

// private async Task<string> GetAccessTokenAsync() {
//     var tokenProvider = new AzureServiceTokenProvider();
//     return await tokenProvider.GetAccessTokenAsync("https://storage.azure.com/");
// }


/**
*
*   disaster recovery
*
**/
// var copyOptions = new CopyOptions();

