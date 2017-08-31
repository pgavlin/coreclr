using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _VS_ia64_JIT_M00_b102759_b102759_b102759_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b102759_b102759_b102759_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b102759\\b102759\\b102759.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
