using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _eh_leaves_nonlocalexitfromnestedcatch_do_nonlocalexitfromnestedcatch_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_nonlocalexitfromnestedcatch_do_nonlocalexitfromnestedcatch_do_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\nonlocalexitfromnestedcatch_do\\nonlocalexitfromnestedcatch_do.cmd");
        }
    }
}
