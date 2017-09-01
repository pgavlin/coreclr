using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _MinMax_ro_MinMax_ro_
    {
        [Fact]
        public void _MinMax_ro_MinMax_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\MinMax_ro\\MinMax_ro.cmd");
        }
    }
}
