using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    class _CodeQuality_BenchI_LogicArray_LogicArray_LogicArray_
    {
        [Fact]
        public void _CodeQuality_BenchI_LogicArray_LogicArray_LogicArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\LogicArray\\LogicArray\\LogicArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
