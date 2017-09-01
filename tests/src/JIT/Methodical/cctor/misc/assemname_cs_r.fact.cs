using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_assemname_cs_r_assemname_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_assemname_cs_r_assemname_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\assemname_cs_r\\assemname_cs_r.cmd");
        }
    }
}
