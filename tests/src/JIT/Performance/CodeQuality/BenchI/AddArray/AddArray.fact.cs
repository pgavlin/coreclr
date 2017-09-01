using CoreclrTestLib;
using Xunit;

namespace JIT_Performance
{
    public class _CodeQuality_BenchI_AddArray_AddArray_AddArray_
    {
        [Fact]
        public void _CodeQuality_BenchI_AddArray_AddArray_AddArray_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Performance\\CodeQuality\\BenchI\\AddArray\\AddArray\\AddArray.cmd");
        }
    }
}
