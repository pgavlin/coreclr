using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__il_relisinst_catch__il_relisinst_catch_
    {
        [Fact]
        public void _casts_SEH__il_relisinst_catch__il_relisinst_catch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_il_relisinst_catch\\_il_relisinst_catch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
