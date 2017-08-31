using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_relu_vfld__il_relu_vfld_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_relu_vfld__il_relu_vfld_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_relu_vfld\\_il_relu_vfld.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
