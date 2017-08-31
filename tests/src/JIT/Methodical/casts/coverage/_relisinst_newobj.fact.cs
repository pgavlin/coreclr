using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__relisinst_newobj__relisinst_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__relisinst_newobj__relisinst_newobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_relisinst_newobj\\_relisinst_newobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
