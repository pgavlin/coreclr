using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_163172_MethodImplFinal_MethodImplFinal_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_163172_MethodImplFinal_MethodImplFinal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\163172\\MethodImplFinal\\MethodImplFinal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
