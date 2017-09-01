using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _UnrollLoop_loop1_cs_d_loop1_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop1_cs_d_loop1_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop1_cs_d\\loop1_cs_d.cmd");
        }
    }
}
