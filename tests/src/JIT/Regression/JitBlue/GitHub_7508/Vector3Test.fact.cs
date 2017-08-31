using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _JitBlue_GitHub_7508_Vector3Test_Vector3Test_
    {
        [Fact]
        public void _JitBlue_GitHub_7508_Vector3Test_Vector3Test_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\JitBlue\\GitHub_7508\\Vector3Test\\Vector3Test.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
