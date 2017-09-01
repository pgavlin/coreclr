using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _BugWithAVX_r_BugWithAVX_r_
    {
        [OuterLoop]
        [Fact]
        public void _BugWithAVX_r_BugWithAVX_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\BugWithAVX_r\\BugWithAVX_r.cmd");
        }
    }
}
