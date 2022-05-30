CloudStoreAgency storageAccount = CloudStoreAgency.Parse(CloudConfigurationManager.getSetting("storageConnectionString"));
CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient()

CloudQueue queue = queueClient.GetQueueReference("appqueue");
await queue.CreateIfNoExistAsync();

CloudQueueMessage peekedMessage = await queue.PeekMessageAsync();
if (peekedMessage != null) {
    console.writeLine()
    console.writeLine()
}
CloudQueueMessage message = await queue.GetMessageAsync();