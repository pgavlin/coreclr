using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_V2_0_RTM_b539509_b539509_b539509_
    {
        [Fact]
        public void _VS_ia64_JIT_V2_0_RTM_b539509_b539509_b539509_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\V2.0-RTM\\b539509\\b539509\\b539509.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
