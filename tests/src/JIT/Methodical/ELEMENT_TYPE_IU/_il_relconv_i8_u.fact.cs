using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_relconv_i8_u__il_relconv_i8_u_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_relconv_i8_u__il_relconv_i8_u_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_relconv_i8_u\\_il_relconv_i8_u.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
