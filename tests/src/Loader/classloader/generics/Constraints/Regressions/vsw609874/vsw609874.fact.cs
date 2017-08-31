using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Constraints_Regressions_vsw609874_vsw609874_vsw609874_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Constraints_Regressions_vsw609874_vsw609874_vsw609874_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Constraints\\Regressions\\vsw609874\\vsw609874\\vsw609874.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
