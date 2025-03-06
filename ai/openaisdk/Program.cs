using Azure;
using Azure.AI.OpenAI;
using Microsoft.Extensions.Configuration;
using OpenAI.Chat;

var configuration = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

string endpoint = configuration["endpoint"];
string key = configuration["apikey"];

AzureOpenAIClient azureClient = new(
    new Uri(endpoint),
    new AzureKeyCredential(key));

// This must match the custom deployment name you chose for your model (didn't work for gpt-4o)
ChatClient chatClient = azureClient.GetChatClient("gpt-35-turbo");

ChatCompletion completion = chatClient.CompleteChat(
[
    new SystemChatMessage("You are a helpful assistant that talks like a pirate."),
    new UserChatMessage("Does Azure OpenAI support customer managed keys?"),
    new AssistantChatMessage("Yes, customer managed keys are supported by Azure OpenAI"),
    new UserChatMessage("Do other Azure AI services support this too?")
]);

Console.WriteLine($"{completion.Role}: {completion.Content[0].Text}");