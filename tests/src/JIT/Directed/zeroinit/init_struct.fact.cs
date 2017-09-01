using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _zeroinit_init_struct_init_struct_
    {
        [Fact]
        public void _zeroinit_init_struct_init_struct_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\zeroinit\\init_struct\\init_struct.cmd");
        }
    }
}
