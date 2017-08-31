using CoreclrTestLib;
using Xunit;

namespace readytorun_tests
{
    class _mainv1_mainv1_
    {
        [Fact]
        public void _mainv1_mainv1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("readytorun\\tests\\mainv1\\mainv1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
