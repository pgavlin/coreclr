using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _zeroinit_init_int64_init_int64_
    {
        [OuterLoop]
        [Fact]
        public void _zeroinit_init_int64_init_int64_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_int64\\init_int64.cmd");
        }
    }
}
