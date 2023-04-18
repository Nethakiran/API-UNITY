using OpenAI;

public class ListFilesExample : MonoBehaviour
{
    async void Start()
    {
        var client = new OpenAIClient("YOUR_API_KEY_HERE");
        var response = await client.Files.List();
        foreach (var file in response.Data)
        {
            Debug.Log(file.Filename);
        }
    }
}
