using CoreclrTestLib;
using Xunit;

namespace managed_Compilation
{
    class _Compilation_Compilation_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [Fact]
        public void _Compilation_Compilation_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("managed\\Compilation\\Compilation\\Compilation.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
