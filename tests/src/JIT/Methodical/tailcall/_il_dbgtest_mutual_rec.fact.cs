using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _tailcall__il_dbgtest_mutual_rec__il_dbgtest_mutual_rec_
    {
        [Fact]
        public void _tailcall__il_dbgtest_mutual_rec__il_dbgtest_mutual_rec_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\tailcall\\_il_dbgtest_mutual_rec\\_il_dbgtest_mutual_rec.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
