﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class dbkolbeEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=dbkolbeEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property ages() As DbSet(Of age)
    Public Property aspnetroles() As DbSet(Of aspnetrole)
    Public Property aspnetuserclaims() As DbSet(Of aspnetuserclaim)
    Public Property aspnetuserlogins() As DbSet(Of aspnetuserlogin)
    Public Property aspnetusers() As DbSet(Of aspnetuser)
    Public Property civilians() As DbSet(Of civilian)
    Public Property confiscation_type() As DbSet(Of confiscation_type)
    Public Property contrabands() As DbSet(Of contraband)
    Public Property contraband_type() As DbSet(Of contraband_type)
    Public Property countries() As DbSet(Of country)
    Public Property dest_type() As DbSet(Of dest_type)
    Public Property excess_force() As DbSet(Of excess_force)
    Public Property form_type() As DbSet(Of form_type)
    Public Property incidents() As DbSet(Of incident)
    Public Property incident_involved() As DbSet(Of incident_involved)
    Public Property inmates() As DbSet(Of inmate)
    Public Property inmate_program() As DbSet(Of inmate_program)
    Public Property intervals() As DbSet(Of interval)
    Public Property locations() As DbSet(Of location)
    Public Property location_parent() As DbSet(Of location_parent)
    Public Property moves() As DbSet(Of move)
    Public Property move_type() As DbSet(Of move_type)
    Public Property move_type_det() As DbSet(Of move_type_det)
    Public Property offence_nature() As DbSet(Of offence_nature)
    Public Property officers() As DbSet(Of officer)
    Public Property p_location() As DbSet(Of p_location)
    Public Property params() As DbSet(Of param)
    Public Property programs() As DbSet(Of program)
    Public Property reasons() As DbSet(Of reason)
    Public Property search_type() As DbSet(Of search_type)
    Public Property t_verdict() As DbSet(Of t_verdict)
    Public Property teams() As DbSet(Of team)
    Public Property tribunals() As DbSet(Of tribunal)
    Public Property u_locale() As DbSet(Of u_locale)
    Public Property u_module() As DbSet(Of u_module)
    Public Property u_permissions() As DbSet(Of u_permissions)
    Public Property units() As DbSet(Of unit)
    Public Property users() As DbSet(Of user)
    Public Property v_act_code() As DbSet(Of v_act_code)
    Public Property violations() As DbSet(Of violation)
    Public Property violation_act() As DbSet(Of violation_act)
    Public Property weapons() As DbSet(Of weapon)

End Class