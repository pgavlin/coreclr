using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_threads1_cs_r_threads1_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_threads1_cs_r_threads1_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\threads1_cs_r\\threads1_cs_r.cmd");
        }
    }
}
