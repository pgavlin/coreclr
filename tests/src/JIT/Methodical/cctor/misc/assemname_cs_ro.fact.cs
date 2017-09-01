using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_assemname_cs_ro_assemname_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_assemname_cs_ro_assemname_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\assemname_cs_ro\\assemname_cs_ro.cmd");
        }
    }
}
