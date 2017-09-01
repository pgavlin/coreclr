using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_regress_asurt_141358_uncaughtException_do_uncaughtException_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_regress_asurt_141358_uncaughtException_do_uncaughtException_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\asurt\\141358\\uncaughtException_do\\uncaughtException_do.cmd");
        }
    }
}
