using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_leaves_nonlocalexitfromnestedcatch_r_nonlocalexitfromnestedcatch_r_
    {
        [OuterLoop]
        [Fact]
        public void _eh_leaves_nonlocalexitfromnestedcatch_r_nonlocalexitfromnestedcatch_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\leaves\\nonlocalexitfromnestedcatch_r\\nonlocalexitfromnestedcatch_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
