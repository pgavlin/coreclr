using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_reli_fld__il_reli_fld_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_reli_fld__il_reli_fld_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_reli_fld\\_il_reli_fld.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
