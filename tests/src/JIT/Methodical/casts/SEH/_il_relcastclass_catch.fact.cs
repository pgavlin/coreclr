using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__il_relcastclass_catch__il_relcastclass_catch_
    {
        [Fact]
        public void _casts_SEH__il_relcastclass_catch__il_relcastclass_catch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_il_relcastclass_catch\\_il_relcastclass_catch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
