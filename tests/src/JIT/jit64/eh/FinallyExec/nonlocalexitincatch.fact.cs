using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_FinallyExec_nonlocalexitincatch_nonlocalexitincatch_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalexitincatch_nonlocalexitincatch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalexitincatch\\nonlocalexitincatch.cmd");
        }
    }
}
