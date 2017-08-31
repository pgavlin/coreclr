using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_array__il_dbgcastclass_ldlen__il_dbgcastclass_ldlen_
    {
        [OuterLoop]
        [Fact]
        public void _casts_array__il_dbgcastclass_ldlen__il_dbgcastclass_ldlen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\array\\_il_dbgcastclass_ldlen\\_il_dbgcastclass_ldlen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
