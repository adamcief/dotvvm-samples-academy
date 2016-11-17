﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DotvvmAcademy.Lessons;
using DotvvmAcademy.Steps.StepsBases;
using DotvvmAcademy.Steps.Validation;
using DotvvmAcademy.Steps.Validation.Interfaces;
using DotVVM.Framework.Configuration;
using DotVVM.Framework.ViewModel;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace DotvvmAcademy.Steps
{
    public class CodeStepCsharp : CodeStepBase<ICSharpCodeStepValidationObject>
    {
        public CodeStepCsharp(LessonBase currentLesson) : base(currentLesson)
        {
        }

        public override ICSharpCodeStepValidationObject Validator { get; set; }

        [Bind(Direction.None)]
        public List<string> AllowedTypesConstructed { get; private set; } = new List<string>();

        [Bind(Direction.None)]
        public List<string> AllowedMethodsCalled { get; private set; } = new List<string>();

        [Bind(Direction.None)]
        public List<Assembly> ReferencedAssemblies { get; } = new List<Assembly>
        {
            typeof(object).GetTypeInfo().Assembly,
            typeof(DotvvmConfiguration).GetTypeInfo().Assembly, // DotVVM.Framework
            typeof(BindAttribute).GetTypeInfo().Assembly // DotVVM.Core
        };


        [Bind(Direction.None)]
        public List<string> OtherFiles { get; } = new List<string>();

        protected override IEnumerable<string> GetErrors()
        {
            try
            {
                var tree = (CSharpSyntaxTree) CSharpSyntaxTree.ParseText(Code);
                var compilation = CSharpCompilation.Create(
                    Guid.NewGuid().ToString(),
                    new[] {tree}.Concat(OtherFiles.Select(c => CSharpSyntaxTree.ParseText(c))),
                    ReferencedAssemblies.Select(a => MetadataReference.CreateFromFile(a.Location)).ToArray(),
                    new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary)
                );

                var assembly = compilation.CompileToAssembly();
                var model = compilation.GetSemanticModel(tree);

                var validationVisitor = new CSharpCodeSafetyVisitor(this, compilation, tree, model);

                validationVisitor.Visit(tree.GetCompilationUnitRoot());

                Validator.Validate(compilation, tree, model, assembly);

                return Enumerable.Empty<string>();
            }
            catch (CodeValidationException ex)
            {
                return new[] {ex.Message};
            }
        }
    }
}