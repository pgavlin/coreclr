using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_array__il_relcastclass_ldlen__il_relcastclass_ldlen_
    {
        [OuterLoop]
        [Fact]
        public void _casts_array__il_relcastclass_ldlen__il_relcastclass_ldlen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\array\\_il_relcastclass_ldlen\\_il_relcastclass_ldlen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
