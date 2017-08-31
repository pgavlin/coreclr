using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_relcastclass_call__il_relcastclass_call_
    {
        [Fact]
        public void _casts_coverage__il_relcastclass_call__il_relcastclass_call_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_relcastclass_call\\_il_relcastclass_call.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
