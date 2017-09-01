using CoreclrTestLib;
using Xunit;

namespace managed_Compilation
{
    public class _Compilation_Compilation_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _Compilation_Compilation_cmd()
        {
            CoreclrTestWrapperLib.RunTest("managed\\Compilation\\Compilation\\Compilation.cmd");
        }
    }
}
