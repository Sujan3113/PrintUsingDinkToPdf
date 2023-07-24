using System.Reflection;
using System.Runtime.Loader;

namespace GCSTemplateExample;

public class CustomAssemblyLoadContext: AssemblyLoadContext
{
    public IntPtr LoadUnmanagedLibrary(string absolutePath)
    {
        return LoadUnmanagedDll(absolutePath);
    }

    protected override nint LoadUnmanagedDll(string unmanagedDllName)
    {
        return base.LoadUnmanagedDll(unmanagedDllName);
    }

    protected override Assembly? Load(AssemblyName assemblyName)
    {
        return base.Load(assemblyName);
    }
}
