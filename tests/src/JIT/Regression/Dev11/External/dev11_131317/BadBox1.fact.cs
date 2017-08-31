using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_External_dev11_131317_BadBox1_BadBox1_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_131317_BadBox1_BadBox1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_131317\\BadBox1\\BadBox1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
