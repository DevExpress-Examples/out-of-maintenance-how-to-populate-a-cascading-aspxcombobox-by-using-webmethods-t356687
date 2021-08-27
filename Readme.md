<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128531906/15.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T356687)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to populate a cascading ASPxComboBox by using WebMethods
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t356687/)**
<!-- run online end -->


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


