using CoreclrTestLib;
using Xunit;

namespace readytorun_tests
{
    class _mainv2_mainv2_
    {
        [Fact]
        public void _mainv2_mainv2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("readytorun\\tests\\mainv2\\mainv2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
