using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V2_0_Beta2_b423755_Desktop_b423755_b423755_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V2_0_Beta2_b423755_Desktop_b423755_b423755_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-Beta2\\b423755\\Desktop\\b423755\\b423755.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
