using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_relu_qsort2__il_relu_qsort2_
    {
        [Fact]
        public void _ELEMENT_TYPE_IU__il_relu_qsort2__il_relu_qsort2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_relu_qsort2\\_il_relu_qsort2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
