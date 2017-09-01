using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_FinallyExec_nonlocalexitinfinally_nonlocalexitinfinally_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalexitinfinally_nonlocalexitinfinally_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalexitinfinally\\nonlocalexitinfinally.cmd");
        }
    }
}
