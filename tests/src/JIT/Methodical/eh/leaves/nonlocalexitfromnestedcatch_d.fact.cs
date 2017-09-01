using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_nonlocalexitfromnestedcatch_d_nonlocalexitfromnestedcatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_nonlocalexitfromnestedcatch_d_nonlocalexitfromnestedcatch_d_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\nonlocalexitfromnestedcatch_d\\nonlocalexitfromnestedcatch_d.cmd");
        }
    }
}
