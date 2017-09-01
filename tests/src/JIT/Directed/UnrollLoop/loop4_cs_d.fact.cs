using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _UnrollLoop_loop4_cs_d_loop4_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop4_cs_d_loop4_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop4_cs_d\\loop4_cs_d.cmd");
        }
    }
}
