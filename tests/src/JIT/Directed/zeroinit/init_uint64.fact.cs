using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _zeroinit_init_uint64_init_uint64_
    {
        [OuterLoop]
        [Fact]
        public void _zeroinit_init_uint64_init_uint64_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_uint64\\init_uint64.cmd");
        }
    }
}
