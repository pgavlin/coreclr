using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _zeroinit_init_uint32_init_uint32_
    {
        [OuterLoop]
        [Fact]
        public void _zeroinit_init_uint32_init_uint32_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_uint32\\init_uint32.cmd");
        }
    }
}
