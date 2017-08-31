using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_relisinst_call__il_relisinst_call_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__il_relisinst_call__il_relisinst_call_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_relisinst_call\\_il_relisinst_call.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
