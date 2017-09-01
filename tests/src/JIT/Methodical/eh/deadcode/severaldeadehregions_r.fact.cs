using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_severaldeadehregions_r_severaldeadehregions_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_severaldeadehregions_r_severaldeadehregions_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\severaldeadehregions_r\\severaldeadehregions_r.cmd");
        }
    }
}
