using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_severalnesteddeadehregions_r_severalnesteddeadehregions_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_severalnesteddeadehregions_r_severalnesteddeadehregions_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\severalnesteddeadehregions_r\\severalnesteddeadehregions_r.cmd");
        }
    }
}
