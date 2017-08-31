using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_Dev11_b473131_b473131_struct_b473131_struct_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_Dev11_b473131_b473131_struct_b473131_struct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\Dev11_b473131\\b473131_struct\\b473131_struct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
