using Microsoft.CodeAnalysis;

namespace OneOf.SourceGenerator
{
    internal class DiagnosticErrors
    {

        public static readonly DiagnosticDescriptor TopLevelError = new(id: "ONEOFGEN001",
                                                                                              title: "Class must be top level",
                                                                                              messageFormat: "Class '{0}' using OneOfGenerator must be top level",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor WrongBaseType = new(id: "ONEOFGEN002",
                                                                                              title: "Class must inherit from OneOfBase",
                                                                                              messageFormat: "Class '{0}' does not inherit from OneOfBase",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor ClassIsNotPublic = new(id: "ONEOFGEN003",
                                                                                              title: "Class must be public",
                                                                                              messageFormat: "Class '{0}' is not public",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor ObjectIsOneOfType = new(id: "ONEOFGEN004",
                                                                                              title: "Object is not a valid type parameter",
                                                                                              messageFormat: "Defined conversions to or from a base type are not allowed for class '{0}'",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor WrongNumberOfTypeNames = new(id: "ONEOFGEN005",
                                                                                              title: "Wrong number of names",
                                                                                              messageFormat: "Expected zero or {0} names but got {1}",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor TypeNameCannotBeNullOrEmpty = new(id: "ONEOFGEN006",
                                                                                              title: "Name cannot be null or empty",
                                                                                              messageFormat: "Name at position {0} cannot be null or empty",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);

        public static readonly DiagnosticDescriptor InvalidTypeName = new(id: "ONEOFGEN007",
                                                                                              title: "Invalid name",
                                                                                              messageFormat: "The name '{0}' cannot produce valid property or method names",
                                                                                              category: "OneOfGenerator",
                                                                                              DiagnosticSeverity.Error,
                                                                                              isEnabledByDefault: true);


    }
}