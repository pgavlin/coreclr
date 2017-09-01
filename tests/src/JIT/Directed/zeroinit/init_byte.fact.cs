using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _zeroinit_init_byte_init_byte_
    {
        [OuterLoop]
        [Fact]
        public void _zeroinit_init_byte_init_byte_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_byte\\init_byte.cmd");
        }
    }
}
