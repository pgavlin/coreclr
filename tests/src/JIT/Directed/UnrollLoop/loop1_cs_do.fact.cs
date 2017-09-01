using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _UnrollLoop_loop1_cs_do_loop1_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _UnrollLoop_loop1_cs_do_loop1_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\UnrollLoop\\loop1_cs_do\\loop1_cs_do.cmd");
        }
    }
}
