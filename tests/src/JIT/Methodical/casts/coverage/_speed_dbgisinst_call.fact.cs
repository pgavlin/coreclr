using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_dbgisinst_call__speed_dbgisinst_call_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_dbgisinst_call__speed_dbgisinst_call_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_dbgisinst_call\\_speed_dbgisinst_call.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
