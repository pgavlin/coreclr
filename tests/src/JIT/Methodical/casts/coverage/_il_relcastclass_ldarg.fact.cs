using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_relcastclass_ldarg__il_relcastclass_ldarg_
    {
        [Fact]
        public void _casts_coverage__il_relcastclass_ldarg__il_relcastclass_ldarg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_relcastclass_ldarg\\_il_relcastclass_ldarg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
