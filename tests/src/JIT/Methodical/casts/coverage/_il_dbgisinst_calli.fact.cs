using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_dbgisinst_calli__il_dbgisinst_calli_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__il_dbgisinst_calli__il_dbgisinst_calli_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_dbgisinst_calli\\_il_dbgisinst_calli.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
