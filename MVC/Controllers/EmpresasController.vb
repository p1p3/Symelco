Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Core
Imports Infraestructura

Namespace Controllers
    Public Class EmpresasController
        Inherits System.Web.Mvc.Controller

        Dim db As Core.IRepositorio(Of Empresa)

        Public Sub New(ByVal db As Core.IRepositorio(Of Empresa))
            Me.db = db
        End Sub

        ' GET: Empresas
        Function Index() As ActionResult
            Return View(db.GetAll().ToList())
        End Function

        ' GET: Empresas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empresa As Empresa = db.FindById(id)
            If IsNothing(empresa) Then
                Return HttpNotFound()
            End If
            Return View(empresa)
        End Function

        ' GET: Empresas/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Empresas/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="EmpresaId,Nombre,NIT,ContactoId")> ByVal empresa As Empresa) As ActionResult
            If ModelState.IsValid Then
                db.Add(empresa)
                Return RedirectToAction("Index")
            End If
            Return View(empresa)
        End Function

        ' GET: Empresas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empresa As Empresa = db.FindById(id)
            If IsNothing(empresa) Then
                Return HttpNotFound()
            End If
            Return View(empresa)
        End Function

        ' POST: Empresas/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="EmpresaId,Nombre,NIT,ContactoId")> ByVal empresa As Empresa) As ActionResult
            If ModelState.IsValid Then
                db.Edit(empresa)
                Return RedirectToAction("Index")
            End If
            Return View(empresa)
        End Function

        ' GET: Empresas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim empresa As Empresa = db.FindById(id)
            If IsNothing(empresa) Then
                Return HttpNotFound()
            End If
            Return View(empresa)
        End Function

        ' POST: Empresas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim empresa As Empresa = db.FindById(id)
            db.Remove(empresa.EmpresaId)
            Return RedirectToAction("Index")
        End Function

    End Class
End Namespace
