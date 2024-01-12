// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ChatBotApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\_Imports.razor"
using ChatBotApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\_Imports.razor"
using ChatBotApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\Pages\Index.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\ChatBotApp\Pages\Index.razor"
       
    public string default1 = "Deprem nedir?";
    public string default2 = "Tektonik nedir?";
    public string default3 = "Sismograf nedir?";
    public string default4 = "Jeoloji nedir?";

    public string message;
    public string testing;
    public List<string> messages = new List<string>();
    private static HttpClient Http = new HttpClient();

    protected override async Task OnInitializedAsync()
    {

    }

    public async Task HandleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await SendMessage();
            message = "";
        }
    }

    public async Task SendMessage()
    {
        var promptMessage = " Lütfen doğruluğundan %100 emin olduğun bilgileri ver, eğer cevabından emin değilsen sadece 'Bilmiyorum' diyerek yanıtla.";
        Http = new HttpClient();
        messages.Add(message + promptMessage);

        // Replace [INSERT_YOUR_OWN_API_KEY] with a valid OpenAI API key
        var apiKey = "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";
        Http.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        // JSON content for the API call
        var jsonContent = new
        {
            prompt = message,
            model = "text-davinci-003",
            max_tokens = 1000
        };

        message = "";

        // Make the API call
        var responseContent = await Http.PostAsync("https://api.openai.com/v1/completions", new StringContent(JsonConvert.SerializeObject(jsonContent), Encoding.UTF8, "application/json"));

        // Read the response as a string
        var resContext = await responseContent.Content.ReadAsStringAsync();

        // Deserialize the response into a dynamic object
        var data = JsonConvert.DeserializeObject<dynamic>(resContext);
        messages.Add(data.choices[0].text.ToString());
        StateHasChanged();
    }

    public async Task SendDefaultQuestion(string defaultQuestion)
    {
        message = defaultQuestion;
        await SendMessage();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
