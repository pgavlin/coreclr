using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_dbgisinst_call__il_dbgisinst_call_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__il_dbgisinst_call__il_dbgisinst_call_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_dbgisinst_call\\_il_dbgisinst_call.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
