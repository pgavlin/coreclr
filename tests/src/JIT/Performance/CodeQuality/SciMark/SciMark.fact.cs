using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_SciMark_SciMark_SciMark_
    {
        [Fact]
        public void _CodeQuality_SciMark_SciMark_SciMark_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\SciMark\\SciMark\\SciMark.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
