using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_dbgisinst_newobj__speed_dbgisinst_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__speed_dbgisinst_newobj__speed_dbgisinst_newobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_dbgisinst_newobj\\_speed_dbgisinst_newobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
