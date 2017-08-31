using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_relisinst_call__speed_relisinst_call_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_relisinst_call__speed_relisinst_call_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_relisinst_call\\_speed_relisinst_call.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
