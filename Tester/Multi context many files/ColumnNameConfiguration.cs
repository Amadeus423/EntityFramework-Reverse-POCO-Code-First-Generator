// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Registered to: Simon Hughes
// Company      : Reverse POCO
// Licence Type : Commercial
// Licences     : 1
// Valid until  : 03 NOV 2020
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Connection String Name: "McmfMultiDatabase"
//     Connection String:      "Data Source=(local);Initial Catalog=EfrpgTest;Integrated Security=True"
//     Multi-context settings: "Data Source=(local);Initial Catalog=EfrpgTest_Settings;Integrated Security=True"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise
// Database Version       : 14.0.2027.2

// <auto-generated>
// ReSharper disable CheckNamespace
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedVariable
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantCast
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// ReSharper disable UsePatternMatching
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Tester.Multi_context_many_filesCherry
{
    // ColumnNames
    public class ColumnNameConfiguration : EntityTypeConfiguration<ColumnName>
    {
        public ColumnNameConfiguration()
            : this("dbo")
        {
        }

        public ColumnNameConfiguration(string schema)
        {
            ToTable("ColumnNames", schema);
            HasKey(x => x.Dollar);

            Property(x => x.Dollar).HasColumnName(@"$").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Pound).HasColumnName(@"£").HasColumnType("int").IsOptional();
            Property(x => x.StaticField).HasColumnName(@"static").HasColumnType("int").IsOptional();
            Property(x => x.Day).HasColumnName(@"readonly").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>

