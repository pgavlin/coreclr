using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_throw_cs_do_throw_cs_do_
    {
        [Fact]
        public void _cctor_misc_throw_cs_do_throw_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\throw_cs_do\\throw_cs_do.cmd");
        }
    }
}
