using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_threads2_cs_ro_threads2_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_threads2_cs_ro_threads2_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\threads2_cs_ro\\threads2_cs_ro.cmd");
        }
    }
}
