using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _Dev11_Dev11_468598_Test_HndIndex_10_Reordered_Test_HndIndex_10_Reordered_
    {
        [Fact]
        public void _Dev11_Dev11_468598_Test_HndIndex_10_Reordered_Test_HndIndex_10_Reordered_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\Dev11_468598\\Test_HndIndex_10_Reordered\\Test_HndIndex_10_Reordered.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
