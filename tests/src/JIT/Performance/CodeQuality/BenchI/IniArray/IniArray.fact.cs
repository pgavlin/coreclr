using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_IniArray_IniArray_IniArray_
    {
        [Fact]
        public void _CodeQuality_BenchI_IniArray_IniArray_IniArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\IniArray\\IniArray\\IniArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
