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
	"gw-to": "Receiver",
	"gw-dlr-status": "OK",
	"gw-error-code": null,
	"gw-msgId": "ID09218309123"
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
Picture sample:


## How delivery report system work

In a production environment, this project should be hosted on a server that are accessible by our HTTP Server. An accessible URL pointed to this system should be assigned as DLR-URL before sending SMS to our HTTP Server. Then, when the delivery report for the SMS is ready, our HTTP Server will act as a HTTP Client & send the delivery report data by submitting the same JSON body above (HTTP POST), to the specified DLR-URL that you assigned before. Your hosted delivery report system should be able to read all 5 parameter & deserialize it into .NET object (in this sample case).

When our HTTP Server is successfully send the data, your web server should automatically returned status code 200 (OK) to us indicating that the delivery report process is success.
