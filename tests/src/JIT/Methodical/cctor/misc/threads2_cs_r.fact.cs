using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_threads2_cs_r_threads2_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_threads2_cs_r_threads2_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\threads2_cs_r\\threads2_cs_r.cmd");
        }
    }
}
