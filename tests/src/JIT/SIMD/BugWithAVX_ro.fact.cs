using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _BugWithAVX_ro_BugWithAVX_ro_
    {
        [OuterLoop]
        [Fact]
        public void _BugWithAVX_ro_BugWithAVX_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\BugWithAVX_ro\\BugWithAVX_ro.cmd");
        }
    }
}
