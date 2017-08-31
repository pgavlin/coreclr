using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_External_dev11_145295_CSharpPart_CSharpPart_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_145295_CSharpPart_CSharpPart_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_145295\\CSharpPart\\CSharpPart.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
