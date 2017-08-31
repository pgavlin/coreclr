using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_reli_vfld__il_reli_vfld_
    {
        [OuterLoop]
        [Fact]
        public void _ELEMENT_TYPE_IU__il_reli_vfld__il_reli_vfld_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_reli_vfld\\_il_reli_vfld.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
