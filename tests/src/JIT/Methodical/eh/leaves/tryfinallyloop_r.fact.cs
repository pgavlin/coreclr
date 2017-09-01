using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_tryfinallyloop_r_tryfinallyloop_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_tryfinallyloop_r_tryfinallyloop_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\tryfinallyloop_r\\tryfinallyloop_r.cmd");
        }
    }
}
