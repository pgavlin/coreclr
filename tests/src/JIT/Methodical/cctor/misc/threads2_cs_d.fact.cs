using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_threads2_cs_d_threads2_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_threads2_cs_d_threads2_cs_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\threads2_cs_d\\threads2_cs_d.cmd");
        }
    }
}
