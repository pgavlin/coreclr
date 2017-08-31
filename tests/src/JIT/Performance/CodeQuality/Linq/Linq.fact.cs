using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_Linq_Linq_Linq_
    {
        [Fact]
        public void _CodeQuality_Linq_Linq_Linq_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\Linq\\Linq\\Linq.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
