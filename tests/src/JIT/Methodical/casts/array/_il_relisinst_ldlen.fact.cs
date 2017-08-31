using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_array__il_relisinst_ldlen__il_relisinst_ldlen_
    {
        [OuterLoop]
        [Fact]
        public void _casts_array__il_relisinst_ldlen__il_relisinst_ldlen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\array\\_il_relisinst_ldlen\\_il_relisinst_ldlen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
