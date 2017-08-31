using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_Dev11_468598_Test_HndIndex_10_Plain_Test_HndIndex_10_Plain_
    {
        [Fact]
        public void _Dev11_Dev11_468598_Test_HndIndex_10_Plain_Test_HndIndex_10_Plain_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\Dev11_468598\\Test_HndIndex_10_Plain\\Test_HndIndex_10_Plain.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
