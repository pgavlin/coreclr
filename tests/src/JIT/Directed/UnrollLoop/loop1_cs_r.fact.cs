using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _UnrollLoop_loop1_cs_r_loop1_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop1_cs_r_loop1_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop1_cs_r\\loop1_cs_r.cmd");
        }
    }
}
