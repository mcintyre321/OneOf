using Microsoft.CodeAnalysis;

namespace OneOf
{
    public class GeneratorDiagnosticDescriptors
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

        public static readonly DiagnosticDescriptor UserDefinedConversionsToOrFromAnInterfaceAreNotAllowed = new(id: "ONEOFGEN005",
                                                                                            title: "user-defined conversions to or from an interface are not allowed",
                                                                                            messageFormat: "user-defined conversions to or from an interface are not allowed",
                                                                                            category: "OneOfGenerator",
                                                                                            DiagnosticSeverity.Error,
                                                                                            isEnabledByDefault: true);
    }
}
