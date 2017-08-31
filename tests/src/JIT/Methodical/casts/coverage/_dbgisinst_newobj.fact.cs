using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__dbgisinst_newobj__dbgisinst_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__dbgisinst_newobj__dbgisinst_newobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_dbgisinst_newobj\\_dbgisinst_newobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
