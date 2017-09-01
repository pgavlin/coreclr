using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_deadcode_severalnesteddeadehregions_d_severalnesteddeadehregions_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_deadcode_severalnesteddeadehregions_d_severalnesteddeadehregions_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\deadcode\\severalnesteddeadehregions_d\\severalnesteddeadehregions_d.cmd");
        }
    }
}
