using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _localloc_localloc3_cs_do_localloc3_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_localloc3_cs_do_localloc3_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\localloc\\localloc3_cs_do\\localloc3_cs_do.cmd");
        }
    }
}
