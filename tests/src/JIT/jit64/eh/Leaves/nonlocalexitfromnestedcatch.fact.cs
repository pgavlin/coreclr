using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_Leaves_nonlocalexitfromnestedcatch_nonlocalexitfromnestedcatch_
    {
        [OuterLoop]
        [Fact]
        public void _eh_Leaves_nonlocalexitfromnestedcatch_nonlocalexitfromnestedcatch_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\Leaves\\nonlocalexitfromnestedcatch\\nonlocalexitfromnestedcatch.cmd");
        }
    }
}
