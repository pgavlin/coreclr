using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__dbgcastclass_newobj__dbgcastclass_newobj_
    {
        [Fact]
        public void _casts_coverage__dbgcastclass_newobj__dbgcastclass_newobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_dbgcastclass_newobj\\_dbgcastclass_newobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
