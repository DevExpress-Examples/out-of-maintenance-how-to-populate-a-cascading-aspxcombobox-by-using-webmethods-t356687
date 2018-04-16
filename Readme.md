# How to populate a cascading ASPxComboBox by using WebMethods


<p>This example explains how to populate a cascading <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxComboBoxtopic">ASPxComboBox</a> by using <a href="https://msdn.microsoft.com/en-us/library/byxd99hx(v=vs.90).aspx">WebMethods</a>. On the client side, the master <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxComboBoxtopic">ASPxComboBox</a> is subscribed to the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientComboBox_SelectedIndexChangedtopic">SelectedIndexChanged</a> event. When the event is raised, it sends a request to the server by WebMethod. If the request is successful, a child <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxComboBoxtopic">ASPxComboBox</a> is populated with the response object.</p>
<p>On the client side, WebMethod is called by the following code:</p>


```js
PageMethods.GetData(id, OnSuccess);
```


<br>
<p>On the server side, <a href="https://msdn.microsoft.com/en-us/library/bb398863.aspx">ScriptManager</a> is used with <a href="https://msdn.microsoft.com/en-us/library/system.web.ui.scriptmanager.enablepagemethods.aspx">EnablePageMethods</a> set to "True":</p>


```aspx
<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
```


<br>
<p>The C# method is marked by <a href="https://msdn.microsoft.com/en-us/library/system.web.services.webmethodattribute.aspx">WebMethodAttribute</a>:</p>


```cs
using System.Web.Services;

[WebMethod]
public static List<Product> GetData(string categoryID) {
        //method code
}
```


<br><br>

<br/>


