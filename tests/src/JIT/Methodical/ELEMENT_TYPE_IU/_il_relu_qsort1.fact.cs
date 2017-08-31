using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_relu_qsort1__il_relu_qsort1_
    {
        [Fact]
        public void _ELEMENT_TYPE_IU__il_relu_qsort1__il_relu_qsort1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_relu_qsort1\\_il_relu_qsort1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
