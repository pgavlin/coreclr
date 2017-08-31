using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__il_relfilter__il_relfilter_
    {
        [Fact]
        public void _casts_SEH__il_relfilter__il_relfilter_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_il_relfilter\\_il_relfilter.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
