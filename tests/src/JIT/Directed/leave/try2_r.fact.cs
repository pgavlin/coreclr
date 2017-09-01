using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _leave_try2_r_try2_r_
    {
        [OuterLoop]
        [Fact]
        public void _leave_try2_r_try2_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\leave\\try2_r\\try2_r.cmd");
        }
    }
}
