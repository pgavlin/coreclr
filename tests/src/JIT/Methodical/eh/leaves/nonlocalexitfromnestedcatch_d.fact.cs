using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_nonlocalexitfromnestedcatch_d_nonlocalexitfromnestedcatch_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_nonlocalexitfromnestedcatch_d_nonlocalexitfromnestedcatch_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\nonlocalexitfromnestedcatch_d\\nonlocalexitfromnestedcatch_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
