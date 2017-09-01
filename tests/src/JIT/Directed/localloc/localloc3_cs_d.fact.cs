using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _localloc_localloc3_cs_d_localloc3_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_localloc3_cs_d_localloc3_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\localloc\\localloc3_cs_d\\localloc3_cs_d.cmd");
        }
    }
}
