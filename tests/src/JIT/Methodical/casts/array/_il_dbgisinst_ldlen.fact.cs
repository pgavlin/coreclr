using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_array__il_dbgisinst_ldlen__il_dbgisinst_ldlen_
    {
        [OuterLoop]
        [Fact]
        public void _casts_array__il_dbgisinst_ldlen__il_dbgisinst_ldlen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\array\\_il_dbgisinst_ldlen\\_il_dbgisinst_ldlen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
