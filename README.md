# Sample of delivery report system (.NETCore)

This sample constructed with .NETCore 3.0 using VSCode. To run this sample on VSCode:

- Download the sample as ZIP file & extract
- Restore all dependencies, use <code>dotnet restore</code>
- Run app by using <code>dotnet run</code>
- By default, this app is using port 5011, but you may change it to any available port by going to <code>Program.cs</code> file 
- Use __Postman, Insomnia__ or any API test tool, then navigate to <code>http://localhost:5011</code> (or your custom port number), use the POST request, and add these to the JSON request body:

```
{
	"gw-from": "Sender",
	"TO": "Receiver",
	"status": "OK",
	"errorCode": null,
	"msgId": "ID09218309123"
}
```
- Send the request. If success, you should get these response:
```
SUCCESS. Value received:

From: Sender
To: Receiver
Status: OK
ErrCode: 
MsgId: ID09218309123
```
