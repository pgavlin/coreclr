using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _leave_try1_r_try1_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_try1_r_try1_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\leave\\try1_r\\try1_r.cmd");
        }
    }
}
