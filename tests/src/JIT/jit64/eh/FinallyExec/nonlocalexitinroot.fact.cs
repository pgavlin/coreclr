using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_FinallyExec_nonlocalexitinroot_nonlocalexitinroot_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalexitinroot_nonlocalexitinroot_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalexitinroot\\nonlocalexitinroot.cmd");
        }
    }
}
