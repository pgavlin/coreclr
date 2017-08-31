using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_External_dev11_239804_ShowLocallocAlignment_ShowLocallocAlignment_
    {
        [ActiveIssue("7163, fails on both legacy backend and RyuJIT")]//, TestArchitectures.X86)]
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_239804_ShowLocallocAlignment_ShowLocallocAlignment_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_239804\\ShowLocallocAlignment\\ShowLocallocAlignment.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
