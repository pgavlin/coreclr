using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    class _DblAvg2_DblAvg2_
    {
        [OuterLoop]
        [Fact]
        public void _DblAvg2_DblAvg2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\DblAvg2\\DblAvg2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
