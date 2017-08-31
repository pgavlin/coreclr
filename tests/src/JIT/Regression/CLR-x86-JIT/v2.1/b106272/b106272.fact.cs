using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_v2_1_b106272_b106272_b106272_
    {
        [Fact]
        public void _CLR_x86_JIT_v2_1_b106272_b106272_b106272_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\v2.1\\b106272\\b106272\\b106272.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
