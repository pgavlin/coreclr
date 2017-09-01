using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_regress_asurt_141358_uncaughtException_d_uncaughtException_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_regress_asurt_141358_uncaughtException_d_uncaughtException_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\asurt\\141358\\uncaughtException_d\\uncaughtException_d.cmd");
        }
    }
}
