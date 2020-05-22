<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Create</title>
</head>
<body>
    <a href="/Home"> ↞ Volver al menú 🏡</a>

       <form action="/Video/Create" method="post">
    <fieldset>
        
    <legend>Inserta los datos:</legend>

        <label for="IdVideo">ID Video</label>
        <input type="text" name="IdVideo" />

        <label for="titulo">
        <br />
        Titulo</label>
        <input type="text" name="titulo" />

        <label for="reproduccion">
        <br />
        Reproducciones</label>
        <input type="text" name="reproduccion" />

        <label for="Url">
        <br />
        Liga del video</label>
        <input type="text" name="Url" /><br />
&nbsp;<hr />
        <input type="submit" value="Agregar Video " />


    </fieldset>
</body>
</html>
