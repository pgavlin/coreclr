using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _MinMax_r_MinMax_r_
    {
        [Fact]
        public void _MinMax_r_MinMax_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\MinMax_r\\MinMax_r.cmd");
        }
    }
}
