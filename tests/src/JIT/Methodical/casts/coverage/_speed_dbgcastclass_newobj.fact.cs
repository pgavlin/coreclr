using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__speed_dbgcastclass_newobj__speed_dbgcastclass_newobj_
    {
        [Fact]
        public void _casts_coverage__speed_dbgcastclass_newobj__speed_dbgcastclass_newobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_speed_dbgcastclass_newobj\\_speed_dbgcastclass_newobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
