@ModelType Core.Empresa
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Empresa</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PersonaContacto.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PersonaContacto.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.NIT)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NIT)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.EmpresaId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
