using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_dbgi_ref__il_dbgi_ref_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_dbgi_ref__il_dbgi_ref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_dbgi_ref\\_il_dbgi_ref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
