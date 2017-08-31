using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_External_Dev11_90434_UseUnalignedDouble_UseUnalignedDouble_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_Dev11_90434_UseUnalignedDouble_UseUnalignedDouble_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\Dev11_90434\\UseUnalignedDouble\\UseUnalignedDouble.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
