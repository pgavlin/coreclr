using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_relconvovf_i8_i__il_relconvovf_i8_i_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_relconvovf_i8_i__il_relconvovf_i8_i_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_relconvovf_i8_i\\_il_relconvovf_i8_i.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
