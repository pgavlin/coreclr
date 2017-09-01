using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _cctor_misc_threads2_cs_do_threads2_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _cctor_misc_threads2_cs_do_threads2_cs_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\cctor\\misc\\threads2_cs_do\\threads2_cs_do.cmd");
        }
    }
}
