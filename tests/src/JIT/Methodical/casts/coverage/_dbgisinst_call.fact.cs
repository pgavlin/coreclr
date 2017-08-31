using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__dbgisinst_call__dbgisinst_call_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__dbgisinst_call__dbgisinst_call_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_dbgisinst_call\\_dbgisinst_call.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
