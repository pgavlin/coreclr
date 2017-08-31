using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_dev11_DevDiv_376412_DevDiv_376412_DevDiv_376412_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_dev11_DevDiv_376412_DevDiv_376412_DevDiv_376412_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\dev11\\DevDiv_376412\\DevDiv_376412\\DevDiv_376412.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
