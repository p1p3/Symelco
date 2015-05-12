@ModelType IEnumerable(Of Core.Empresa)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.PersonaContacto.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NIT)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PersonaContacto.Nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NIT)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.EmpresaId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.EmpresaId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.EmpresaId })
        </td>
    </tr>
Next

</table>
