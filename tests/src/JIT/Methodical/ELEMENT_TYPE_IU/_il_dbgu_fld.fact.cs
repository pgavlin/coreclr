using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ELEMENT_TYPE_IU__il_dbgu_fld__il_dbgu_fld_
    {
        [Fact]
        public void _ELEMENT_TYPE_IU__il_dbgu_fld__il_dbgu_fld_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ELEMENT_TYPE_IU\\_il_dbgu_fld\\_il_dbgu_fld.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
