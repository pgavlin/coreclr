using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_throw_cs_r_throw_cs_r_
    {
        [Fact]
        public void _cctor_misc_throw_cs_r_throw_cs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\throw_cs_r\\throw_cs_r.cmd");
        }
    }
}
