using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__relcastclass_ldarg__relcastclass_ldarg_
    {
        [Fact]
        public void _casts_coverage__relcastclass_ldarg__relcastclass_ldarg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_relcastclass_ldarg\\_relcastclass_ldarg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
