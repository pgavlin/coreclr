using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_seh__dbgfilter__dbgfilter_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_seh__dbgfilter__dbgfilter_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\seh\\_dbgfilter\\_dbgfilter.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
