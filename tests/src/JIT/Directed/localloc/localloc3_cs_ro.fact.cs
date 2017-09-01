using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _localloc_localloc3_cs_ro_localloc3_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_localloc3_cs_ro_localloc3_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\localloc\\localloc3_cs_ro\\localloc3_cs_ro.cmd");
        }
    }
}
