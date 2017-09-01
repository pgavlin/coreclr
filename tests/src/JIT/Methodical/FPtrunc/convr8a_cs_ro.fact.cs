using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _FPtrunc_convr8a_cs_ro_convr8a_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _FPtrunc_convr8a_cs_ro_convr8a_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\FPtrunc\\convr8a_cs_ro\\convr8a_cs_ro.cmd");
        }
    }
}
