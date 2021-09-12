using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneOf.Extensions
{
    internal static class DiagnosticCollectionExtensions
    {
        /// <summary>
        /// Report the diagnostics and return false if any are present
        /// </summary>
        /// <param name="diagnostics">the collection of diagnostics to analyze</param>
        /// <param name="context">the code generation context</param>
        /// <returns>false if there is some diagnostic on the collection</returns>
        public static bool ReportIfAny(this IEnumerable<Diagnostic> diagnostics, GeneratorExecutionContext context)
        {
            if (diagnostics != null && diagnostics.Any())
            {
                foreach (var diag in diagnostics)
                    context.ReportDiagnostic(diag);

                return false;
            }

            return true;
        }

    }
}
