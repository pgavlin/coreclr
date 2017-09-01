using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    public class _generics_Instantiation_Recursion_GenTypeItself_GenTypeItself_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Recursion_GenTypeItself_GenTypeItself_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Recursion\\GenTypeItself\\GenTypeItself.cmd");
        }
    }
}
