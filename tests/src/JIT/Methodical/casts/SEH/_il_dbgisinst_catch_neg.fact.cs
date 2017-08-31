using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__il_dbgisinst_catch_neg__il_dbgisinst_catch_neg_
    {
        [Fact]
        public void _casts_SEH__il_dbgisinst_catch_neg__il_dbgisinst_catch_neg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_il_dbgisinst_catch_neg\\_il_dbgisinst_catch_neg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
