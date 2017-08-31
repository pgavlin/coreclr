using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Burgers_Burgers_Burgers_
    {
        [Fact]
        public void _CodeQuality_Burgers_Burgers_Burgers_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Burgers\\Burgers\\Burgers.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
