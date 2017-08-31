using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_V8_Richards_Richards_Richards_
    {
        [Fact]
        public void _CodeQuality_V8_Richards_Richards_Richards_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\V8\\Richards\\Richards\\Richards.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
