using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_relcastclass_call__speed_relcastclass_call_
    {
        [Fact]
        public void _casts_coverage__speed_relcastclass_call__speed_relcastclass_call_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_relcastclass_call\\_speed_relcastclass_call.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
