namespace Unity.CompilationPipeline.Common.ILPostProcessing
{
    public interface ICompiledAssembly
    {
        InMemoryAssembly InMemoryAssembly { get; }
        string Name { get; }
        string[] References { get; }
        string[] Defines { get; }
    }

    public class InMemoryAssembly
    {
        public InMemoryAssembly(byte[] peData, byte[] pdbData)
        {
            PeData = peData;
            PdbData = pdbData;
        }

        public byte[] PeData { get; }
        public byte[] PdbData { get; }
    }
}

namespace Unity.CompilationPipeline.Common.Diagnostics
{
    public class DiagnosticMessage
    {
        public DiagnosticMessage() { }

        public string File { get; set; }
        public DiagnosticType DiagnosticType { get; set; }
        public string MessageData { get; set; }
        public int Line { get; set; }
        public int Column { get; set; }
    }

    public enum DiagnosticType
    {
        Error = 1,
        Warning = 2
    }
}
