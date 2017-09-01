using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _zeroinit_init_int32_init_int32_
    {
        [OuterLoop]
        [Fact]
        public void _zeroinit_init_int32_init_int32_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_int32\\init_int32.cmd");
        }
    }
}
