using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_tryfinallyloop_d_tryfinallyloop_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_tryfinallyloop_d_tryfinallyloop_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\tryfinallyloop_d\\tryfinallyloop_d.cmd");
        }
    }
}
