using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_FinallyExec_nonlocalexitinhandler_nonlocalexitinhandler_
    {
        [OuterLoop]
        [Fact]
        public void _eh_FinallyExec_nonlocalexitinhandler_nonlocalexitinhandler_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\FinallyExec\\nonlocalexitinhandler\\nonlocalexitinhandler.cmd");
        }
    }
}
