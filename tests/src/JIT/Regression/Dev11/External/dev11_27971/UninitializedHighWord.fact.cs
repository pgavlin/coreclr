using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_External_dev11_27971_UninitializedHighWord_UninitializedHighWord_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_27971_UninitializedHighWord_UninitializedHighWord_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_27971\\UninitializedHighWord\\UninitializedHighWord.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
