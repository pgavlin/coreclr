using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__dbgisinst_ldloc__dbgisinst_ldloc_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__dbgisinst_ldloc__dbgisinst_ldloc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_dbgisinst_ldloc\\_dbgisinst_ldloc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
