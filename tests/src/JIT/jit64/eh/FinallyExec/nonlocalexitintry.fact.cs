using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_FinallyExec_nonlocalexitintry_nonlocalexitintry_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalexitintry_nonlocalexitintry_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalexitintry\\nonlocalexitintry.cmd");
        }
    }
}
