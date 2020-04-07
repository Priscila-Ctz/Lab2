<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Select</title>
</head>
<body>
    <a href="/Home"> ↞ Volver al menú 🏡</a>
    <br />  
    <h1 class="style2"> <strong>Videos enlistados: </strong> </h1>

        <% foreach (System.Data.DataRow ren in ((System.Data.DataTable) ViewData ["Video"]).Rows)  
           { %>
           
             <ul>
                 <li>  <%: ren["IDVideo"].ToString()  %> </li>
                 <li>  <%: ren["titulo"].ToString()  %> </li>
                 <li>  <%: ren["Url"].ToString()  %> </li>
                 <li>  <%: ren["reproduccion"].ToString()  %> </li>
    </ul>

        <% }
             %>
</body>
</html>
