using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_reli_conv__il_reli_conv_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_reli_conv__il_reli_conv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_reli_conv\\_il_reli_conv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
