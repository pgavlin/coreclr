using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _regressions_dev10_568786_4_Misc_MethodCalls_MethodCalls_
    {
        [OuterLoop]
        [Fact]
        public void _regressions_dev10_568786_4_Misc_MethodCalls_MethodCalls_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\regressions\\dev10_568786\\4_Misc\\MethodCalls\\MethodCalls.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
